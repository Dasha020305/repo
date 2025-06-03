using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_15
{
    public class Program : IEnumerable<Show>
    {
        public DateTime Date;
        private List<Show> shows;

        public int Count { get => shows.Count; }

        public Program(string date, IEnumerable<Show> showsCollection)
        {
            Date = DateTime.Parse(date);
            shows = new List<Show>();
            foreach (var show in showsCollection)
            {
                if (show.ReleaseDate.HasValue &&
                    show.ReleaseDate.Value.Date == DateTime.Parse(date) &&
                    !shows.Contains(show))
                {
                    shows.Add(show);
                }
            }
        }

        public IEnumerator<Show> GetEnumerator() => shows.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}