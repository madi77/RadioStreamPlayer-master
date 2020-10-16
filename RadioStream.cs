using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class RadioStream
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public List<RadioStream> radiosList()
        {
            List<RadioStream> radioStreams = new List<RadioStream>
            {
                new RadioStream{Id=1,Name="Star FM", Url="http://fm05-ice.stream.khz.se/fm05_mp3?listenerid=5e56702d166d82982d8d8bd28b5486cb&awparams=companionAds%3Atrue&platform=web&aw_0_1st.playerid=mtgradio-web&aw_0_1st.skey=1550500824"},
                new RadioStream{Id=2,Name="Rix FM", Url="http://fm01-ice.stream.khz.se/fm01_mp3"},
                new RadioStream{Id=3,Name="Radio Antena Bor-Vrsac", Url="http://www.antenabor.com:8018/;"},

            };

            return radioStreams;
        }

        

    }
}

            