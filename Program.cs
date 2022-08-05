using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        string subjectString = @"Hello1

Hello2

/*Hello3 

Hello4*/

         Hello5

/*/if (!IsPostBack)
            //{
            //*/    //binddummyDT();
               
            //};
            ";
        Regex comments2 = new Regex(@"/\*(.|\n)*?\*/");
        string afterRemoval = comments2.Replace(subjectString, "");
        Console.WriteLine(afterRemoval);

    }
}