
namespace ChallengeApp
    //What...?
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname{ get; }

        void AddGrade(int grade);
        void AddGrade(string grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(char grade);
        Statistics GetStatistics();
    }
}
