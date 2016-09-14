using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class ConcreteAggregate : Aggregate
    {
        public List<String> bands = new List<String>();
        public List<String> albums = new List<String>();

        public void createData()
        {
            albums.Add("A Thousand Suns");
            bands.Add("Linkin Park");
            albums.Add("Appeal To Reason");
            bands.Add("Rise Against");
            albums.Add("Avenged Sevenfold");
            bands.Add("Avenged Sevenfold");
            albums.Add("The Black Market");
            bands.Add("Rise Against");
            albums.Add("City Of Evil");
            bands.Add("Avenged Sevenfold");
            albums.Add("Dark Before Dawn");
            bands.Add("Breaking Benjamin");
            albums.Add("Dear Agony");
            bands.Add("Breaking Benjamin");
            albums.Add("Endgame");
            bands.Add("Rise Against");
            albums.Add("Hail To The King");
            bands.Add("Avenged Sevenfold");
            albums.Add("Human");
            bands.Add("Three Days Grace");
            albums.Add("The Hunting Party");
            bands.Add("Linkin Park");
            albums.Add("Hybrid Theory");
            bands.Add("Linkin Park");
            albums.Add("Life Starts Now");
            bands.Add("Three Days Grace");
            albums.Add("Living Things");
            bands.Add("Linkin Park");
            albums.Add("Meteora");
            bands.Add("Linkin Park");
            albums.Add("Minutes To Midnight");
            bands.Add("Linkin Park");
            albums.Add("Nightmare");
            bands.Add("Avenged Sevenfold");
            albums.Add("One-X");
            bands.Add("Three Days Grace");
            albums.Add("Phobia");
            bands.Add("Breaking Benjamin");
            albums.Add("Revolutions Per Minute");
            bands.Add("Rise Against");
            albums.Add("Saturate");
            bands.Add("Breaking Benjamin");
            albums.Add("Siren Song Of The Counter Culture");
            bands.Add("Rise Against");
            albums.Add("Sounding The Seventh Trumpet");
            bands.Add("Avenged Sevenfold");
            albums.Add("The Sufferer & The Witness");
            bands.Add("Rise Against");
            albums.Add("Three Days Grace");
            bands.Add("Three Days Grace");
            albums.Add("Transit Of Venus");
            bands.Add("Three Days Grace");
            albums.Add("The Unraveling");
            bands.Add("Rise Against");
            albums.Add("Waking The Fallen");
            bands.Add("Avenged Sevenfold");
            albums.Add("We Are Not Alone");
            bands.Add("Breaking Benjamin");
            albums.Add("---");
            bands.Add("---");
        }

        public override Iterator createIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
