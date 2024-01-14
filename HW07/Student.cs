using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotv_lesson7
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }

        public double AvgMarks { get; set; }

        private Random random;

        public Student()
        {
            Name = "";
            Birth = DateTime.MinValue;
            AvgMarks = 0;
        }
        public Student(string name, DateTime date, double avg)
        {
            random = new Random();
            Name = name;
            Birth = date;
            AvgMarks = avg;
        }

        public override string ToString() => $"{Name} | {Birth:dd-MM-yyyy} | {AvgMarks}";
    }
}
