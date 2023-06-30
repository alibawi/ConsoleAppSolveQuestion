using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    const int Q2Const = 51;
    private static void Main(string[] args)
    {

        Console.Clear();
        // Test Question 1 
        Console.WriteLine("Test Question 1");
        Console.WriteLine($"{Q1(1, 2)}");
        Console.WriteLine($"{Q1(3, 2)}");
        Console.WriteLine($"{Q1(2, 2)}");
        Console.WriteLine();

        // Test Question 2
        Console.WriteLine("Test Question 2");
        Console.WriteLine($"{Q2(53)}");
        Console.WriteLine($"{Q2(30)}");
        Console.WriteLine($"{Q2(51)}");
        Console.WriteLine();


        // Test Question 3
        Console.WriteLine("Test Question 3");
        Console.WriteLine($"{Q3(30, 0)}");
        Console.WriteLine($"{Q3(25, 5)}");
        Console.WriteLine($"{Q3(20, 30)}");
        Console.WriteLine($"{Q3(20, 25)}");
        Console.WriteLine();

        // Test Question 4
        Console.WriteLine("Test Question 4");
        Console.WriteLine($"{Q4(103)}");
        Console.WriteLine($"{Q4(90)}");
        Console.WriteLine($"{Q4(89)}");

        // Test Question 5
        Console.WriteLine("Test Question 5");
        Console.WriteLine($"{Q5("if else")}");
        Console.WriteLine($"{Q5("else")}");
        Console.WriteLine();

        // Test Question 6
        Console.WriteLine("Test Question 6");
        Console.WriteLine($"{Q6("Python", 1)}");
        Console.WriteLine($"{Q6("Python", 0)}");
        Console.WriteLine($"{Q6("Python", 4)}");
        Console.WriteLine();

        // Test Question 7
        Console.WriteLine("Test Question 7");
        Console.WriteLine($"{Q7("abcd")}");
        Console.WriteLine($"{Q7("a")}");
        Console.WriteLine($"{Q7("xy")}");
        Console.WriteLine();

        // Test Question 8
        Console.WriteLine("Test Question 8");
        Console.WriteLine(Q8("C Sharp"));
        Console.WriteLine(Q8("JS"));
        Console.WriteLine(Q8("a"));
        Console.WriteLine();

        // Test Question 9
        Console.WriteLine("Test Question 9");
        Console.WriteLine(Q9("Red"));
        Console.WriteLine(Q9("Green"));
        Console.WriteLine(Q9("1"));

        Console.WriteLine();

        // Test Question 10
        Console.WriteLine("Test Question 10");
        Console.WriteLine(Q10(3));
        Console.WriteLine(Q10(14));
        Console.WriteLine(Q10(12));
        Console.WriteLine(Q10(37));
        Console.WriteLine();

        // Test Question 11
        Console.WriteLine("Test Question 11");
        Console.WriteLine(Q11("Python"));
        Console.WriteLine(Q11("JS"));
        Console.WriteLine(Q11("Code"));
        Console.WriteLine();

        // Test Question 12
        Console.WriteLine("Test Question 12");
        Console.WriteLine(Q12("C# Sharp"));
        Console.WriteLine(Q12("C#"));
        Console.WriteLine(Q12("C++"));

        Console.WriteLine();

        // Test Question 13
        Console.WriteLine("Test Question 13");
        Console.WriteLine(Q13(120, -1));
        Console.WriteLine(Q13(-1, 120));
        Console.WriteLine(Q13(20, 120));

        Console.WriteLine();

        // Test Question 14
        Console.WriteLine("Test Question 14");
        Console.WriteLine();

        // Test Question 15
        Console.WriteLine("Test Question 15");
        Console.WriteLine();

        // Test Question 16
        Console.WriteLine("Test Question 16");
        Console.WriteLine();

        // Test Question 17
        Console.WriteLine("Test Question 17");
        Console.WriteLine();

        // Test Question 18
        Console.WriteLine("Test Question 18");
        Console.WriteLine();

        // Test Question 19
        Console.WriteLine("Test Question 19");
        Console.WriteLine();

        // Test Question 20
        Console.WriteLine("Test Question 20");
        Console.WriteLine();

        // Test Question 21
        Console.WriteLine("Test Question 21");
        Console.WriteLine();

        // Test Question 22
        Console.WriteLine("Test Question 22");
        Console.WriteLine();

        // Test Question 23
        Console.WriteLine("Test Question 23");
        Console.WriteLine();

        // Test Question 24
        Console.WriteLine("Test Question 24");
        Console.WriteLine(Q24("Python"));
        Console.WriteLine(Q24("Javascript"));
        Console.WriteLine(Q24("js"));
        Console.WriteLine(Q24("PHP"));
        Console.WriteLine();

        // Test Question 25
        Console.WriteLine("Test Question 25");
        Console.WriteLine(Q25("JS",2));
        Console.WriteLine(Q25("JS",3));
        Console.WriteLine(Q25("JS",1));
        Console.WriteLine();
        

    }

    /// <summary>
    /// 1. Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
    /// Sample Input:
    ///         1, 2
    ///         3, 2
    ///         2, 2
    /// Expected Output:
    ///         3
    ///         5
    ///         12   
    /// </summary>
    /// <param name="num1">first number</param>
    /// <param name="num2">second number</param>
    /// <returns>
    ///  if num1 equalt to num2 return triple of thier sum
    ///  else return thier sum
    /// </returns>
    public static int Q1(int num1, int num2) 
    { 
        int result = num1 + num2; 
        if (num1 == num2) 
            return result * 3; 
        return result;
    }

    /// <summary>
    /// Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.
    /// Sample Input:
    ///     53
    ///     30
    ///     51
    /// Expected Output:
    ///     6
    ///     21
    ///     0
    /// </summary>
    /// <param name="n">input n number</param>
    /// <returns>
    /// If n is broader than 51 return triple the absolute difference
    /// else return the absolute difference
    /// </returns>
    public static int Q2(int n) 
    { 
        int result = Math.Abs(n - Q2Const); 
        if (n > Q2Const) 
            return result * 3; 
        return result;
    }

    /// <summary>
    /// Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
    /// Sample Input:
    /// 30, 0
    /// 25, 5
    /// 20, 30
    /// 20, 25
    /// Expected Output:
    /// True
    /// True
    /// True
    /// Fals
    /// </summary>
    /// <param name="num1">first int parameter</param>
    /// <param name="num2">second int parameter</param>
    /// <returns>
    /// ture if one of parameter is 30 or thier sum is 30.
    /// else return false
    /// </returns>
    public static bool Q3(int num1, int num2)
    {
        int result = num1 + num2;
        if (result == 30 || num1 == 30 || num2 == 30)
            return true;
        return false;
    }

    /// <summary>
    /// Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
    /// Sample Input:
    /// 103
    /// 90
    /// 89
    /// Expected Output:
    /// True
    /// True
    /// False
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public static bool Q4(int num)
    {
        if(Math.Abs(num - 100) <= 10 || Math.Abs(num - 200) <= 10)
            return true;

        return false;
    }

    /// <summary>
    /// Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.
    /// Sample Input:
    /// "if else"
    /// "else"
    /// Expected Output:
    /// if else
    /// if else
    /// </summary>
    /// <returns></returns>
    public static string Q5(string str)
    {
        if(str.StartsWith("if "))
            return str;
        return $"if {str}";
    }

    /// <summary>
    /// 6. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
    ///     Sample Input:
    /// "Python", 1
    /// "Python", o
    /// "Python", 4
    /// Expected Output:
    /// Pthon
    /// ython
    /// Pythn
    /// </summary>
    /// <param name="str">input string</param>
    /// <param name="pos">position</param>
    /// <returns>remove the character at a given position in the string</returns>
    public static string Q6(string str, int pos)
    {
        if(pos > str.Length -1) return str;

        return str.Remove(pos, 1);
    }

    /// <summary>
    /// 7. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
    /// Sample Input:
    ///  "abcd"
    ///  "a"
    ///  "xy"
    /// Expected Output:
    ///  dbca
    ///  a
    ///  yx
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q7(string str)
    {
        if (str.Length <= 1) return str;
        char f = str[0];
        char l = str[str.Length-1];
        
        string result = $"{l}{str.Substring(1, str.Length-2)}{f}";
        return result ;
    }

    /// <summary>
    /// Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string.
    /// Sample Input:
    ///     "C Sharp"
    ///     "JS"
    ///     "a"
    /// Expected Output:
    ///     C C C C
    ///     JSJSJSJS
    ///     a
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q8(string str)
    {
        if(str.Length < 2) return str;
        return str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
    }

    /// <summary>
    /// Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.
    /// Sample Input:
    ///     "Red"
    ///     "Green"
    ///     "1"
    /// Expected Output:
    ///     dRedd
    ///     nGreenn
    ///     111
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q9(string str)
    {
        return str.Substring(str.Length-1) + str + str.Substring(str.Length-1);
    }

    /// <summary>
    /// 10. Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.
    /// Sample Input:
    /// 3
    /// 14
    /// 12
    /// 37
    /// Expected Output:
    /// True
    /// True
    /// True
    /// False
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool Q10(int num)
    {
        if(num % 3 == 0 || num % 7 == 0) return true ;
        return false ;
    }

    /// <summary>
    /// 11. Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.
    /// Sample Input:
    /// "Python"
    /// "JS"
    /// "Code"
    /// Expected Output:
    /// PytPythonPyt
    /// JSJSJS
    /// CodCodeCod
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q11(string str)
    {
        return str.Length < 3 ? str + str + str : str.Substring(0, 3) + str + str.Substring(0, 3);
    }

    /// <summary>
    /// 12. Write a C# Sharp program to check if a given string starts with 'C#' or not.
    ///     Sample Input:
    /// "C# Sharp"
    /// "C#"
    /// "C++"
    /// Expected Output:
    /// True
    /// True
    /// False
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool Q12(string str)
    {
        return str.StartsWith("C#");
    }

    /// <summary>
    /// 13. Write a C# Sharp program that checks whether one temperature is less than 0 and another is greater than 100.
    /// Sample Input:
    /// 120, -1
    /// -1, 120
    /// 2, 120
    /// Expected Output:
    /// True
    /// True
    /// False
    /// </summary>
    /// <param name="temp1"></param>
    /// <param name="temp2"></param>
    /// <returns></returns>
    public static bool Q13(int temp1, int temp2)
    {
        return (temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 <0) ? true : false ;
    }

    /// <summary>
    /// 14. Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
    ///  Sample Input:
    ///  100, 199
    ///  250, 300
    ///  105, 190
    ///  Expected Output:
    ///  True
    ///  False
    ///  True
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static bool Q14(int num1, int num2)
    {
        return (num1 >= 100 && num1 <= 200) || (num2 >= 100 || num2 <= 200);
    }

    /// <summary>
    /// 15. Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. Return true if 1 or more of them are in the said range otherwise false.
    /// Sample Input:
    /// 11, 20, 12
    /// 30, 30, 17
    /// 25, 35, 50
    /// 15, 12, 8
    /// Expected Output:
    /// True
    /// True
    /// True
    /// False
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <param name="num3"></param>
    /// <returns></returns>
    public static bool Q15(int num1, int num2, int num3)
    {
        return (num1 >= 10 && num1 <= 50) || (num2 >= 10 && num2 <= 50) || (num3 >= 10 && num3 <= 50);
    }

    /// <summary>
    /// 16. Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. Return true if 1 or other is in the range, otherwise false.
    /// Sample Input:
    /// 20, 84
    /// 14, 50
    /// 11, 45
    /// 25, 40
    /// Expected Output:
    /// True
    /// True
    /// True
    /// False
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static bool Q16(int num1, int num2)
    {
        return((num1 >= 20 && num1 <= 50) && (num2 < 20 || num2 > 50)) || ((num2 >= 20 && num2 <= 50) && (num1 < 20 || num1 > 50)) ? true : false ;
    }

    /// <summary>
    /// 17. Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. If it appears return a string without 'yt' otherwise return the original string.
    /// Sample Input:
    /// "Python"
    /// "ytade"
    /// "jsues"
    /// Expected Output:
    /// Phon
    /// ytade
    /// jsues
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q17(string str)
    {
        return str.Substring(1,2) == "yt" ? str.Substring(0,1) + str.Substring(3) : str;
    }

    /// <summary>
    /// 18. Write a C# Sharp program to check the largest number among three given integers.
    /// Sample Input:
    /// 1,2,3
    /// 1,3,2
    /// 1,1,1
    /// 1,2,2
    /// Expected Output:
    /// 3
    /// 3
    /// 1
    /// 2
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <param name="num3"></param>
    /// <returns></returns>
    public static int Q18(int num1, int num2, int num3)
    {
        int largest = num1;
        if(largest < num2) largest = num2;
        if(largest < num3) largest = num3;

        return largest;
    }

    /// <summary>
    /// 19. Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.
    /// Sample Input:
    /// 78, 95
    /// 95, 95
    /// 99, 70
    /// Expected Output:
    /// 95
    /// 0
    /// 99
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static int Q19(int num1, int num2)
    {
        if (num1 == num2) return 0;
        if (Math.Abs(100 - num1) < Math.Abs(100 - num2))
            return num1;
        else 
            return num2;
    }

    /// <summary>
    /// 20. Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.
    /// Sample Input:
    /// 78, 95
    /// 25, 35
    /// 40, 50
    /// 55, 60
    /// Expected Output:
    /// False
    /// False
    /// True
    /// True
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static bool Q20(int num1, int num2)
    {
        return ((num1 >= 40 && num1 <= 50) && (num2 >= 40 && num2 <= 50)) || ((num1 >= 50 && num1 <= 60) && (num2 >= 50 && num2 <= 60)) ? true : false;
    }

    /// <summary>
    /// 21. Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.
    /// Sample Input:
    /// 78, 95
    /// 20, 30
    /// 21, 25
    /// 28, 28
    /// Expected Output:
    /// 0
    /// 30
    /// 25
    /// 28
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static int Q21(int num1, int num2)
    {
        if ((num1 >= 20 && num1 <= 30) && (num2 >= 20 && num2 <= 30))
            return num1 > num2 ? num1 : num2;
        else
            return 0;
    }

    /// <summary>
    /// 22. Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.
    /// Sample Input:
    /// "frizz"
    /// "zane"
    /// "Zazz"
    /// "false"
    /// "zzzz"
    /// "ZZZZ"
    /// Expected Output:
    /// True
    /// False
    /// True
    /// False
    /// True
    /// False
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool Q22(string str)
    {
        int count = 0;
        for(int i=0; i<str.Length; i++)
        {
            if (str[i] == 'z') count++;
        }

        return (count > 1 && count <= 4);
    }

    /// <summary>
    /// 23. Write a C# Sharp program to check if two given non-negative integers have the same last digit.
    /// Sample Input:
    /// 123, 456
    /// 12, 512
    /// 7, 87
    /// 12, 45
    /// Expected Output:
    /// False
    /// True
    /// True
    /// False
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static bool Q23(int num1, int num2)
    {
        string n1 = num1.ToString();
        string n2 = num2.ToString();
        return n1[n1.Length-1] == n2[n2.Length-1];
    }

    /// <summary>
    /// 24. Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.
    /// Sample Input:
    /// "Python"
    /// "Javascript"
    /// "js"
    /// "PHP"
    /// Expected Output:
    /// PytHON
    /// JavascrIPT
    /// JS
    /// PHP
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q24(string str)
    {
        return str.Length < 3 ?  str.ToUpper() : str.Substring(0, str.Length - 3) + str.Substring(str.Length-3).ToUpper() ;
        
    }

    /// <summary>
    /// 25. Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.
    /// Sample Input:
    /// "JS", 2
    /// "JS", 3
    /// "JS", 1
    /// Expected Output:
    /// JSJS
    /// JSJSJS
    /// JS
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string Q25(string str, int copy)
    {
        string result = "";
        for (int i = 0; i < copy; i++)
        {
            result += str;
        }
        return result;
    }

}