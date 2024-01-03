namespace ChallengeApp;


public class Supervisor : IEmployee
{
    private List<float> grades = new List<float>();
    public Supervisor(string name, string surname, char sex)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = sex;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public char Sex { get; private set; }

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
        switch (grade)
        {
            case "6":
                AddGrade(100);
                break;
            case "6-":
            case "-6":
                AddGrade(95);
                break;
            case "5+":
            case "+5":
                AddGrade(85);
                break;
            case "5":
                AddGrade(80);
                break;
            case "5-":
            case "-5":
                AddGrade(75);
                break;
            case "4+":
            case "+4":
                AddGrade(70);
                break;
            case "4":
                AddGrade(60);
                break;
            case "4-":
            case "-4":
                AddGrade(55);
                break;
            case "3+":
            case "+3":
                AddGrade(50);
                break;
            case "3":
                AddGrade(40);
                break;
            case "3-":
            case "-3":
                AddGrade(35);
                break;
            case "2+":
            case "+2":
                AddGrade(30);
                break;
            case "2":
                AddGrade(20);
                break;
            case "2-":
            case "-2":
                AddGrade(15);
                break;
            case "1+":
            case "+1":
                AddGrade(10);
                break;
            case "1":
                AddGrade(0);
                break;
            default:
                throw new Exception("Wrong Grade number");
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

