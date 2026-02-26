public class Program
{
     static void Main(string[] args)
    {
        #region Q1:
        //Q1: What will this print and explain what happens ?
        //double d = 9.99;
        //int x = (int)d;
        //Console.WriteLine(x);//9
        // output will be 9 becuse when we cast a double to an int,
        // it truncates the decimal part and only keeps the whole number part.
        // So, 9.99 becomes 9 when cast to an int. 
        #endregion

        #region Q2:

        //Q2: This code doesn’t compile. Fix it with the smallest change?
        //int n = 5;
        //double d2 = n / 2;
        // code need double d2 = n / 2.0;
        //becase we need to make sure that the division is performed as a floating-point
        //Console.WriteLine(d2); 
        #endregion

        #region Q3:
        //Q3: You read a number from user input .. Write the correct line to get age as int.
        //Console.WriteLine("please enter your age");
        //int age = int.Parse(Console.ReadLine());
        //Console.WriteLine($"your age is {age}");
        #endregion

        #region Q4:
        //Q4: What happens here and why?
        //string s = "12a";
        //int x = int.Parse(s);
        //Console.WriteLine(x);
        // This code will throw a FormatException at runtime because the string "12a" cannot be parsed into an int.

        #endregion

        #region Q5:
        //Q5: Complete the code from the previous question so it prints Invalid if conversion into int fails,
        //otherwise prints the number
        //string s = "12a";
        //try { int x = int.Parse(s); }
        //catch (FormatException) { Console.WriteLine("Invalid"); }
        #endregion

        #region Q6:
        //Q6: What will this print and explain why ?
        //object o = 10;
        //int a = (int)o;
        //Console.WriteLine(a + 1);
        // output will be 11 because the object o is boxed with the value 10,
        // and when we unbox it to an int, we get  value 10. Then we add 1.
        #endregion

        #region Q7:
        //Q7: What will this print and explain why and if there is a problem handle it ?
        //object o = 10;
        //try 
        //{
        //    long x = (long)o;
        //} 
        //catch { Console.WriteLine("Invalid cast from object to long"); }

        // This code will throw an InvalidCastException at runtime because the object o is boxed with the value 10 (which is an int),
        #endregion

        #region Q8:
        //Q8: Fix this to avoid exceptions and print -1 if conversion isn’t possible?
        //object o = 10;
        //long x = o;
        //Console.WriteLine(x);
        //answer
        //object o = 10;
        //long x = (o is int i) ? i : (o is long l ? l : -1);

        //Console.WriteLine(x);
        #endregion

        #region Q9:
        //Q9: What will this print and explain why ?
        //string? name = null;
        //Console.WriteLine(name?.Length);
        //This code will print nothing an empty blank output
        // because the null operator (?.) is used to access the Length property of variable.
        #endregion

        #region Q10:
        //Q10: What will this print and explain the process?
        //string? name2 = null;
        //int length = name2?.Length ?? 0;
        // This code will not  print anything becuse there is no console.writeline 
        //but if we add Console.WriteLine(length); it will print 0 because null operator
        //used to provide a default value witch is 0
        #endregion

        #region Q11:
        //Q11: What’s wrong with this “safe” code and how can we solve it ?
        //string? s = null;
        //int x = int.Parse(s ?? "0");
        //Console.WriteLine(x);
        //The code you provided isn't technically "broken" in terms of logic
        //we can solve it by using int.TryParse not int.Parse to avoid exceptions
        //if the string cannot be parsed to integer.
        #endregion

        #region Q12:
        //Q12: What happens here and if there is a problem, handle it
        //string? s = null;
        //Console.WriteLine(s!.Length);
        // This code will throw a NullReferenceException at runtime
        //we can handle it by checking if s is null before accessing its Length property, like this:
        //string? s = null;
        //if (s != null)
        //{
        //    Console.WriteLine(s.Length);
        //}
        //Console.WriteLine(s);
        #endregion
    }
}