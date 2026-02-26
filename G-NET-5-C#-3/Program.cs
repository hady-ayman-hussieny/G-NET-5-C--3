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
    }
}