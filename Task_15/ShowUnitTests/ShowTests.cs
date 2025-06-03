using System;
using Task_15;

namespace ShowUnitTests
{
    [TestFixture]
    public class ShowTests
    {
        [Test]
        public void CompareToTest()
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

            Assert.That(show1.CompareTo(show2), Is.GreaterThan(0));
            Assert.That(show4.CompareTo(show3), Is.GreaterThan(0));
            Assert.That(show1.CompareTo(show3), Is.LessThan(0));
            Assert.That(show1.CompareTo(show1), Is.EqualTo(0));
            Assert.That(show5.CompareTo(show1), Is.LessThan(0));
            
        }
    }
}