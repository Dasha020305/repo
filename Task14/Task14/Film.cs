using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    public class Film : Show
    {
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public int ReleaseYear { get; set; }

        public Film(string title, string host, string description, string genre, string director, string country, int releaseYear)
            : base(title, host, description)
        {
            Genre = genre;
            Director = director;
            Country = country;
            ReleaseYear = releaseYear;
        }

        public override string[] GetInfo()
        {
            var info = new String[4];
            var showInfo = base.GetInfo();

            info[0] = showInfo[0];
            info[1] = showInfo[1];
            info[2] = showInfo[2];
            info[3] = $"Жанр: {Genre}. Режиссер: {Director}. Страна: {Country}. Год выхода на экраны: {ReleaseYear}";

            return info;
        }
    }
}
       
