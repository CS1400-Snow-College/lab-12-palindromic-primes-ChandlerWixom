// Chandler Wixom, Lab 12 Palindromic primes, 4/22/2025

//Goal list palindromic (racecar, 1001001, 1234321) prime numbers

//GetNthPalindromicPrime(n), IsPrime(candidate), IsPalindromic(candidate).

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

Debug.Assert(IsPrime(4)  == false);
Debug.Assert(IsPrime(5) == true);
Debug.Assert(IsPrime(17) == true);

Debug.Assert(IsPalindromic("racecar") == true);
Debug.Assert(IsPalindromic("hi there") == false);
Debug.Assert(IsPalindromic("123 321") == true);
Debug.Assert(IsPalindromic("123 3 2 1") == false);

Console.WriteLine("How many Palindromic Prime numbers would you like to see");
    

Int32.TryParse(Console.ReadLine(), out int n);

GetNthPalindromicPrime(n);


   
  










// writes out all palindroic primes up to the n count given
void GetNthPalindromicPrime(int n)
{
    
    int nCount = 1;

    for (int i = 0; nCount <= n; i++)
    {
        if (IsPrime(i) && IsPalindromic(i.ToString()))
        {
            Console.WriteLine($"{nCount}: {i}");
            nCount++;
        }
    }

}


// returns a bool if the string given is palindromatic
bool IsPalindromic(string line)
{
    List <char> chars = new List<char>(line.ToList());
    List<char> reverse = new List<char>(line.ToList());
    reverse.Reverse();

    for (int c = 0; c <= chars.Count/2; c ++)
    {
        if (chars[c] != reverse[c])
        {
            return false;
        }
    }

    return true;

}

// retruns a bool if the int given is prime
bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }
    else 
    {
        int divisors = 0;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                divisors++;
            }
        }

        if (divisors == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }

    }


}

