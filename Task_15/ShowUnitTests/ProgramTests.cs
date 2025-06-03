using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_15;

namespace ShowUnitTests
{
    [TestFixture]
    public class ProgramTests
    {
        Program program;
        Show[] shows;

        [SetUp]
        public void SetUp()
        {
            var show1 = new Show("Мастер Игры", "Юрий Колокольников", "Психологическое реалити шоу")
            { ReleaseDate = DateTime.Parse("07.06.2025"), ReleaseTime = DateTime.Parse("18:00") };
            var show2 = new Show("Шоу Воли", "Павел Воля", "Вечернее шоу со звездами")
            { ReleaseDate = DateTime.Parse("05.06.2025"), ReleaseTime = DateTime.Parse("20:00") };
            var show3 = new Show("Сокровища Императора", "Ольга Бузова и Михаил Галустян", "Приключенческое реалити-шоу")
            { ReleaseTime = DateTime.Parse("19:00") };
            var show4 = new Show("Битва Сильнейших", "Марат Башаров", "Мистическое шоу")
            { ReleaseTime = DateTime.Parse("21:00") };
            var show5 = new Show("Титаны", "Искуственный интеллект", "Спортивно-развлекательное шоу")
            { ReleaseDate = DateTime.Parse("07.06.2025"), ReleaseTime = DateTime.Parse("17:00") };

            shows = new Show[] { show1, show2, show3, show4, show5, show1 };
            program = new Program("07.06.2025", shows);
        }
        [Test]
        public void ConstructorTest()
        {
            Assert.That(program.Date, Is.EqualTo(DateTime.Parse("07.06.2025")));
            foreach (var show in shows)
            {
                if (show.ReleaseDate == program.Date)
                {
                    Assert.That(program.Contains(show), Is.True);
                }
                else
                {
                    Assert.That(program.Contains(show), Is.False);
                }
            }
        }
        [Test]
        public void CountTest()
        {
            Assert.That(program.Count, Is.EqualTo(2));
        }
        [Test]
        public void UniqueShowsTest() 
        {
            foreach (var show in program)
            {
                Assert.That(program.Count(s => s.Equals(show)), Is.EqualTo(1));
            }
        }
        [Test]
        public void IEnumerableTest()
        {
            var expectedShows = new[] { shows[0], shows[4] };

            var i = 0;

            foreach (var show in program)
                Assert.That(show, Is.SameAs(expectedShows[i++]));
        }
    }
}
