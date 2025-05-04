using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_14;

namespace ShowUnitTests
{
    [TestFixture]
    public class TVSeriesUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var show = GetTestTVSeries();
            Assert.That(show.SeasonNumber, Is.EqualTo(1));
            Assert.That(show.EpisodeNumber, Is.EqualTo(13));
        }

        [Test]
        public void GetInfo_TVSeries_FourStringInfo()
        {
            var show = GetTestTVSeries();
            var lines = new[]
            {
                "Закрытая школа (Ведущий: Антон Новосельцев)",
                "Периодичность: еженедельная. Время: 20:00",
                "Описание: Телесериал в жанре мистического триллера",
                "Номер сезона: 1. Номер эпизода: 13"
            };
            var info = show.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));

            for (var i = 0; i < info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private TVSeries GetTestTVSeries()
        {
            var show = new TVSeries("Закрытая школа", "Антон Новосельцев",
                "Телесериал в жанре мистического триллера", 1, 13);
            show.Periodicity = ShowPeriodicity.Weekly;
            show.ReleaseTime = DateTime.Parse("20:00");
            return show;
        }
    }
}
