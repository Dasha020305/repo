using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_15;

namespace ShowUnitTests
{
    [TestFixture]
    public class FilmUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var show = GetTestFilm();
            Assert.That(show.Genre, Is.EqualTo("Мелодрама"));
            Assert.That(show.Director, Is.EqualTo("Джастин Бальдони"));
            Assert.That(show.Country, Is.EqualTo("США"));
            Assert.That(show.ReleaseYear, Is.EqualTo(2019));
        }

        [Test]
        public void GetInfo_Film_FourStringInfo()
        {
            var show = GetTestFilm();
            var lines = new[]
            {
                "В метре друг от друга (Ведущий: Коул Спроус)",
                "Периодичность: непериодическая. Время: 19:00. Дата: 14.03.2019",
                "Описание: Американская мелодрама",
                "Жанр: Мелодрама. Режиссер: Джастин Бальдони. Страна: США. Год выхода на экраны: 2019"
            };
            var info = show.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));

            for (var i = 0; i < info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private Film GetTestFilm()
        {
            var show = new Film("В метре друг от друга", "Коул Спроус",
                "Американская мелодрама", "Мелодрама", "Джастин Бальдони", "США", 2019);
            show.Periodicity = ShowPeriodicity.NonPeriodic;
            show.ReleaseTime = DateTime.Parse("19:00");
            show.ReleaseDate = DateTime.Parse("14.03.2019");
            return show;
        }
    }
}