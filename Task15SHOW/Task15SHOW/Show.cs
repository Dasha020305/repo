using System;

namespace Task15SHOW
{
    public class Show
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