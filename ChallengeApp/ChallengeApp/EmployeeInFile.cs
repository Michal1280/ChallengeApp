
using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(int grade)
        {
            {
                if (grade >= 0 && grade <= 100)
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                    }
                }
                else
                {
                    throw new Exception("Data grade is invalid, should be 0-100");
                }
            }
        }

        public override void AddGrade(string grade)
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

        public override void AddGrade(float grade)
        {
            var valueInInt = (int)grade;
            this.AddGrade(valueInInt);
        }

        public override void AddGrade(double grade)
        {
            var valueInInt = (int)grade;
            this.AddGrade(valueInInt);
        }

        public override void AddGrade(char grade)
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

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0;
            result.Max = float.MinValue;
            result.Min = float.MaxValue;
            var num = 0;
            if (File.Exists(fileName))
            {
                using (StreamReader reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Average += number;
                        num++;
                        line = reader.ReadLine();
                    }
                }
            }
            result.Average = result.Average / num;
            switch (result.Average)
            {
                case var a when a >= 80:
                    result.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    result.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    result.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    result.AverageLetter = 'D';
                    break;
                default:
                    result.AverageLetter = 'E';
                    break;
            }
            return result;
        }
    }
}
