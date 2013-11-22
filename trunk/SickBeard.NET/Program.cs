using System;
using System.ServiceModel.Syndication;
using System.Xml;

namespace SickBeard.NET
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var tvShow = TVShow.FromTheTVDB("How i met your mother");

        //    string search = "Game of Thrones";
        //    for (int i = 1; i < 10; ++i)
        //    {
        //        Console.WriteLine(@"/!\ Saison {0} /!\", i);
        //        var url = string.Format("https://gks.gs/rdirect.php?type=search&q={0}+s{1:00}&category=10&ak=addd66d7bfd55f7f618d2026c17a3929&exact", search.ToLowerInvariant().Replace(" ", "+"), i);
        //        Console.WriteLine(url);
        //        var gksRSS = XmlReader.Create(url);
        //        var dvdrip = SyndicationFeed.Load(gksRSS);
        //        gksRSS.Close();
        //        foreach (SyndicationItem dvdripItem in dvdrip.Items)
        //        {
        //            Console.WriteLine("{0} : {1}", dvdripItem.Title.Text, dvdripItem.Links[0].Uri);
        //        }
        //    }

        //    Console.ReadKey(true);
        //}
    }
}
