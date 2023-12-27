using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Data is incorrect, grade should be 0-100");
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
                Console.WriteLine("String is not float");
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
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
            //var valueInInt = (int)grade;
            //this.AddGrade(valueInInt);
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
            switch(statistics.Average)
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
