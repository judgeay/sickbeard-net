using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SickBeard.NET
{
    /// <summary>
    /// Représente une série
    /// </summary>
    public class TVShow : INotifyPropertyChanged
    {
        public static List<TVShow> FromTheTVDB(string tvShowName)
        {
            var result = new List<TVShow>();

            tvShowName = tvShowName.ToLowerInvariant().Replace(' ', '+');
            while (tvShowName.Contains(' ')) tvShowName = tvShowName.Replace(" ", string.Empty);

            using (XmlReader reader = XmlReader.Create(string.Format("http://thetvdb.com/api/GetSeries.php?seriesname={0}", tvShowName)))
            {
                bool canRead = reader.Read();
                while (canRead)
                {
                    if ((reader.Name == "Series") && reader.IsStartElement())
                    {
                        while (reader.Name != "seriesid") reader.Read();
                        reader.Read();
                        string id = reader.Value;

                        while (reader.Name != "SeriesName") reader.Read();
                        reader.Read();
                        string name = reader.Value;

                        result.Add(new TVShow(id, name));
                    }
                    else canRead = reader.Read();
                }
            }
            //#if DEBUG
            //            var zip = ZipFile.ExtractToDirectory(@"D:\judgeay\Downloads\fr.zip", Environment.SpecialFolder.ApplicationData);
            //            foreach (var file in zip.Entries)
            //            {
            //                var xml = XElement.ReadFrom(XmlReader.Create(file.Open()));
            //                Console.WriteLine(xml);
            //            }
            //#endif

            return result;
        }

        private string _id;
        private string _name;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        public TVShow(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
