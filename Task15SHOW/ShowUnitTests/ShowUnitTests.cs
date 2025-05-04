using System;
using Task15SHOW;

namespace ShowUnitTests
{
    [TestFixture]
    public class ShowUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var show = CreateTestShow();

            Assert.That(show.Title, Is.EqualTo("Импровизаторы"));
            Assert.That(show.Host, Is.EqualTo("Стас"));
            Assert.That(show.Description, Is.EqualTo("Комедийное шоу"));
            Assert.That(show.Periodicity, Is.EqualTo(ShowPeriodicity.Daily));
            Assert.That(show.ReleaseTime.ToString("t"), Is.EqualTo("20:00"));
            Assert.That(show.ReleaseDate, Is.Null);
        }

        [Test]
        public void GetInfoTest()
        {
            var show = CreateTestShow();
            var info = show.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Импровизаторы (Ведущий: Стас)"));
            Assert.That(info[1], Is.EqualTo("Периодичность: ежедневная. Время: 20:00"));
            Assert.That(info[2], Is.EqualTo("Описание: Комедийное шоу"));
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