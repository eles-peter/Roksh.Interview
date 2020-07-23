using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Roksh.Interview.Data
{
    public static class WebCrawler
    {

        public static List<string> GetProductNames(string url)
        {
            var client = new WebClient();
            var html = client.DownloadString(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var productNameItemList = htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("name ulined-link")).ToList();

            var productNameList = new List<string>();

            foreach (var productNameItem in productNameItemList)
            {
                string productName = productNameItem.Descendants("a").FirstOrDefault().GetAttributeValue("title", "").ToString();
                productNameList.Add(productName);
            }

            return productNameList;
        }
      


    }
}
