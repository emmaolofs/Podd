using Podd.Modeller;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Xml;

namespace Podd.Data
{
    public class EpisodHanterare
    {
        public static List<Episod> getEpisodes(string url)
        {
            List<Episod> episodListan = new List<Episod>();
            using (XmlReader reader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                foreach (SyndicationItem item in feed.Items)
                {
                    string Namn = item.Title.Text;
                    DateTime DatumFore = item.PublishDate.DateTime;
                    string Datum = DatumFore.Day + "/" + DatumFore.Month + " - " + DatumFore.Year;
                    string Beskrivning = item.Summary.Text;
                    string Url = url;
                    Episod episod = new Episod(Namn, Datum, Beskrivning, Url);
                    episodListan.Add(episod);
                }
            }
            return episodListan;
        }
    }
}
