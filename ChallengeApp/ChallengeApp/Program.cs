using ChallengeApp;
using System.Runtime.InteropServices;
Employee user1 = new Employee("Michal", "Zebrowski", 23);
Employee user2 = new Employee("Marta", "Gosk", 34);
Employee user3 = new Employee("Adam", "Padok", 18);

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);
user1.AddScore(10);
user1.AddScore(8);
var result1 = user1.ResultAverage;

user2.AddScore(8);
user2.AddScore(8);
user2.AddScore(9);
user2.AddScore(10);
user2.AddScore(6);
var result2 = user2.ResultAverage;

user3.AddScore(3);
user3.AddScore(1);
user3.AddScore(1);
user3.AddScore(4);
user3.AddScore(8);
var result3 = user3.ResultAverage;
/*Console.WriteLine("Average score for user1 is : " + result1);
Console.WriteLine("Average score for user2 is : " + result2);
Console.WriteLine("Average score for user3 is : " + result3);
*/
float max=0;
if(result1>max)
{
    max = result1;
}
if (result2>max)
{
    max = result2;
}
if (result3 > max)
{
    max = result3;
}
if(result1==max)
{
    Console.WriteLine("The max average score has " + user1.Name+" "+user1.Surname+" in age: "+user1.Age+" with score: "+result1);
}
if (result2 == max)
{
    Console.WriteLine("The max average score has " + user2.Name + " " + user2.Surname + " in age: " + user2.Age + " with score: " + result2);
}
if (result3 == max)
{
    Console.WriteLine("The max average score has " + user3.Name + " " + user3.Surname + " in age: " + user3.Age + " with score: " + result3);
}