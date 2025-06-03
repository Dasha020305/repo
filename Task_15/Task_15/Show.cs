using System;

namespace Task_15
{
    public class Show: IComparable<Show>
    {
        public string Title { get; set; }
        public string Host { get; set; }
        public string Description { get; set; }
        public ShowPeriodicity Periodicity;
        public DateTime ReleaseTime;
        public DateTime? ReleaseDate;
        public Show(string title, string host, string description)
        {
            Title = title;
            Host = host;
            Description = description;
        }

        public int CompareTo(Show other)
        {
            if (other == null) return 1;

            if (this.ReleaseDate.HasValue && other.ReleaseDate.HasValue)
            {
                int dateComparison = this.ReleaseDate.Value.CompareTo(other.ReleaseDate.Value);
                if (dateComparison != 0) return dateComparison;
            }

            return this.ReleaseTime.CompareTo(other.ReleaseTime);
        }



        public virtual string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"{Title} (Ведущий: {Host})";

            string periodicityStr;
            if (Periodicity == ShowPeriodicity.Daily)
                periodicityStr = "ежедневная";
            else if (Periodicity == ShowPeriodicity.Weekly)
                periodicityStr = "еженедельная";
            else if (Periodicity == ShowPeriodicity.Monthly)
                periodicityStr = "ежемесячная";
            else
                periodicityStr = "непериодическая";

            if (Periodicity == ShowPeriodicity.NonPeriodic)
            {
                info[1] = $"Периодичность: {periodicityStr}. Время: {ReleaseTime:t}. Дата: {ReleaseDate:d}";
            }
            else
            {
                info[1] = $"Периодичность: {periodicityStr}. Время: {ReleaseTime:t}";
            }

            info[2] = $"Описание: {Description}";

            return info;
        }
    }
}