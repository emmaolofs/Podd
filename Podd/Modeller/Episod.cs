namespace Podd.Modeller
{
    public class Episod
    {
        public Episod(string namn, string datum, string beskrivning, string url)
        {
            Namn = namn;
            Datum = datum;
            Beskrivning = beskrivning;
            Url = url;
        }

        public Episod(string namn, string datum, string url)
        {
            Namn = namn;
            Datum = datum;
            Url = url;
        }

        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string Datum { get; set; }
        public string Url { get; set; }
    }
}
