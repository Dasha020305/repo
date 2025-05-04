using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Task_14;

namespace Task_14
{
    public class EducationalShow : Show
    {
        public string ScienceField { get; set; }
        public EducationalShow(string title, string host, string description, string scienceField)
            : base(title, host, description)
        {
            ScienceField = scienceField;
        }

        public override string[] GetInfo()
        {
            var info = new String[4];
            var showInfo = base.GetInfo();

            info[0] = showInfo[0];
            info[1] = showInfo[1];
            info[2] = showInfo[2];
            info[3] = $"Область науки: {ScienceField}";

            return info;
        }
    }
}