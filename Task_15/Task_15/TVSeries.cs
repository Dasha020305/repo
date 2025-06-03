using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_15;

namespace Task_15
{
    public class TVSeries : Show
    {
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }

        public TVSeries(string title, string host, string description, int seasonNumber, int episodeNumber)
            : base(title, host, description)
        {
            SeasonNumber = seasonNumber;
            EpisodeNumber = episodeNumber;
        }

        public override string[] GetInfo()
        {
            var info = new String[4];
            var showInfo = base.GetInfo();

            info[0] = showInfo[0];
            info[1] = showInfo[1];
            info[2] = showInfo[2];
            info[3] = $"Номер сезона: {SeasonNumber}. Номер эпизода: {EpisodeNumber}";

            return info;
        }
    }
}