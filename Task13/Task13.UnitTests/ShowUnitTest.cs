using NUnit.Framework;
using Task13;
using TVProgramLibrary;

namespace TVProgramLibrary.UnitTests
{
    [TestFixture]
    public class ShowUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var news = CreateTestShow();

            Assert.That(news.Title, Is.EqualTo("Импровизаторы"));
            Assert.That(news.Host, Is.EqualTo("Стас"));
            Assert.That(news.Description, Is.EqualTo("Комедийное шоу"));
            Assert.That(news.Periodicity, Is.EqualTo(ShowPeriodicity.Daily));
            Assert.That(news.ReleaseTime.ToString("t"), Is.EqualTo("20:00"));
            Assert.That(news.ReleaseDate, Is.Null);
        }

        [Test]
        public void GetInfoTest()
        {
            var news = CreateTestShow();
            var info = news.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Импровизаторы (Ведущий: Стас)"));
            Assert.That(info[1], Is.EqualTo("Периодичность: ежедневная. Время: 20:00. Описание: Комедийное шоу"));
        }

        [Test]
        public void GetInfoNonPeriodicTest()
        {
            var concert = new Show("Кто тут жулик", "Антон Шастун", "Интеллектуальное шоу")
            {
                Periodicity = ShowPeriodicity.NonPeriodic,
                ReleaseTime = DateTime.Parse("23:00"),
                ReleaseDate = DateTime.Parse("14.04.2025")
            };

            var info = concert.GetInfo();

            Assert.That(info[1], Is.EqualTo("Периодичность: непериодическая. Время: 23:00. Дата: 14.04.2025. Описание: Интеллектуальное шоу"));
        }

        private Show CreateTestShow()
        {
            return new Show("Импровизаторы", "Стас", "Комедийное шоу")
            {
                Periodicity = ShowPeriodicity.Daily,
                ReleaseTime = DateTime.Parse("20:00")
            };
        }
    }
}