using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace UpdateBug
{

    internal class Crawlers
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;
        public string status = "succeed";
        public string type;
        public List<Condition> list = new List<Condition>();

        public void Crawl()
        {
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)//找到一个还未下载的链接
                {
                    if ((bool)urls[url]) continue;//已经下载过的，不再下载
                    current = url;       //为current赋一个值
                }
                if (current == null || count > 10) break;   //已经全部下载完毕或者爬了十层
                
                string document = DownLoad(current); // 下载判断原网页是什么网页
                Regex ishtml = new Regex(@"^<!DOCTYPE html>"); //判断文档是否为HTML
                Regex ishtm = new Regex(@"^<!DOCTYPE htm>"); //判断文档是否为htm
                Regex isaspx = new Regex(@"^<!DOCTYPE aspx>"); //判断文档是否为aspx
                Regex isphp = new Regex(@"^<!DOCTYPE php>"); //判断文档是否为php
                Regex isjsp = new Regex(@"^<!DOCTYPE jsp>"); //判断文档是否为jsp
                urls[current] = true;       //
                count++;
                string temp = current;
                if (ishtml.IsMatch(document))
                {
                    Parse(document);//解析,并加入新的链接
                    status = "succeed";
                    type = "html";
                }
                else if(ishtm.IsMatch(document))
                {
                    Parse(document);
                    status = "succeed";
                    type = "htm";
                }
                else if(isaspx.IsMatch(document))
                {
                    Parse(document);
                    status = "succeed";
                    type = "aspx";
                }
                else if (isphp.IsMatch(document))
                {
                    Parse(document);
                    status = "succeed";
                    type = "php";
                }
                else if (isjsp.IsMatch(document))
                {
                    Parse(document);
                    status = "succeed";
                    type = "jsp";
                }
                else { status = "fail";
                      type = "error";
                };
                list.Add(new Condition(count, temp, status,type));
            }
        }


        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string document = webClient.DownloadString(url);
                string temp = FixUrl(url, document);
                string fileName = count.ToString();
                File.WriteAllText(fileName, document, Encoding.UTF8);
                return document;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";

            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        //解析URL的表达式
        public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //将相对路径转为绝对路径
        private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }

            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
