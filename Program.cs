using System;  
public class Exercise
{  
    public static void Main() 
    {
	Console.Write("\n\n");
    Console.WriteLine("Displays -----> \n1.Triangle,\n2.Rectangle");

    System.Console.Write("Please choose one of the number: ");
    int chooseNumber=int.Parse(Console.ReadLine()!);
    switch(chooseNumber)
    {
        case 1 :
            Console.Write("Input number of rows : ");
            int rows;
            rows=int.Parse(Console.ReadLine()!);

            for(int outeriteration=1; outeriteration<=rows; outeriteration++)
            {
            for(int iteration=1; iteration<=outeriteration ; iteration++)
            {
            Console.Write("*");
            }
            System.Console.WriteLine();
            };
            break;

        case 2 :

            for(int outeriteration=1; outeriteration<=5; outeriteration++)
            {
            for(int iteration=1; iteration<=5 ; iteration++)
            {
            Console.Write("*");
            }
            System.Console.WriteLine();
            };
            break;
    }
    }
}



