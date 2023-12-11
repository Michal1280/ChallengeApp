// Prepare program which check number of digits in the number. 

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
for (int i = 0; i <= 9; i++)
{
    string digit = Convert.ToString(i);
    int numberdigits = 0;
    foreach (char letter in letters)
    {
        string letterInString = letter.ToString(); 
        if (letterInString == digit)
        {
            numberdigits++;
        }
    }
    if (numberdigits > 0)
    {
        Console.WriteLine("In number "+number+" we have " + numberdigits + " digits "+ digit);
    }
}