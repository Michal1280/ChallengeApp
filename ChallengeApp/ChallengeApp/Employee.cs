using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee : Person

    {
        private const char sex = 'M';

        private List<float> grades = new List<float>();

        public Employee()
             : this("no name")
        {
        }
        public Employee(string name)
           : this("no name", "no surname", 'N')
        {
        }
        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {
        }


        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Data grade is invalid, should be 0-100");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }

        }
        public void AddGrade(float grade)
        {
            var valueInInt = (int)grade;
            this.AddGrade(valueInInt);
        }
        public void AddGrade(double grade)
        {
            var valueInInt = (int)grade;
            this.AddGrade(valueInInt);
        }
        public void AddGrade(long grade)
        {
            var valueInInt = (int)grade;
            this.AddGrade(valueInInt);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");

            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average = statistics.Average / this.grades.Count;
            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }


    }
}
