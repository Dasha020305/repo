using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14;

namespace ShowUnitTests.cs
{
    [TestFixture]
    public class EducationalShowTest
    {
            [Test]
            public void ConstructorTest()
            {
                var show = GetTestEducationalShow();
                Assert.That(show.ScienceField, Is.EqualTo("Физика"));
            }

            [Test]
            public void GetInfo_EducationalShow_FourStringInfo()
            {
                var show = GetTestEducationalShow();
                var lines = new[]
                {
                "Галилео (Ведущий: Александр Пушной)",
                "Периодичность: еженедельная. Время: 18:00",
                "Описание: Познавательная программа об устройстве мира",
                "Область науки: Физика"
            };
                var info = show.GetInfo();

                Assert.That(info.Length, Is.EqualTo(4));

                for (var i = 0; i < info.Length; i++)
                    Assert.That(info[i], Is.EqualTo(lines[i]));
            }

            private EducationalShow GetTestEducationalShow()
            {
                var show = new EducationalShow("Галилео", "Александр Пушной",
                    "Познавательная программа об устройстве мира", "Физика");
                show.Periodicity = ShowPeriodicity.Weekly;
                show.ReleaseTime = DateTime.Parse("18:00");
                return show;
            }
        }
    }

