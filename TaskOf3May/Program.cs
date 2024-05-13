using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskOf3May
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Enter First number");
            //string num1=  Console.ReadLine();

            //  Console.WriteLine("Enter First number");
            // string num2= Console.ReadLine();

            // //InfinteMulti(num1, num2);


            // List<string> fruits= new List<string>();
            //  fruits.Add("apple");
            //  fruits.Add("pine");
            //  fruits.Insert(1, "orange");
            //  Console.WriteLine(fruits[0]);
            //  Console.WriteLine(fruits[1]);
            //  reversenum();
            SimpleInterest();
            Console.ReadLine();




        }
        //public static void InfinteMulti(string num1, string num2)
        //{
        //    var num1r = 0;
        //    var num11 = int.TryParse(num1, out num1r);
        //    var num2r = 0;
        //    var num22 = int.TryParse(num2, out num2r);
        //    var ans = 0;
        //    int ans1 = 0;
        //    int ans2 = 0;
        //    for(int j=num1r; j<=num2r; j++) {
        //  for (int i = num1r; i < num2r; i++)
        //    {
        //        Console.WriteLine("{0}",i);
               
        //    }
        //        Console.ReadLine();
        //    }
        //}
        //public static void letters()
        //{
        //    for (int i = 1; i <27; i++)
        //    {
        //        for(char letter='A';letter<'Z';letter++)
        //        {


        //            Console.WriteLine(letter);
        //        }
            
        //    }
        //}

        //public static void reversenum()
        //{
        //    int total = 5;
        //    int[] number = new int[total];
        //    for (int i = 0; i < total; i++)
        //    {
        //        number[i] = Convert.ToInt32(Console.ReadLine());


        //    }
        //    Array.Reverse(number);

        //    for (int i = 0; i < total; i++)
        //    {
        //        Console.WriteLine(number[i]);
        //    }
        //}


        //public static void SearchArray()
        //{
        //    int total = 5;
        //    int[] interger = {1, 2, 3, 4, 5, 6};
            
          

        //}
        public static void SimpleInterest()
        {
            int finalAmount;
            int principleBalance=0;
            //intial

            int interestRate=0;
            //annual

            int time=0;
            int vSimpleInterest = 0;

            string input;
            bool inputParse;
            int inputParseAns;

            Console.WriteLine("Good day Sir/Ma");
            Console.WriteLine("Enter One to calcualte simple interest ");
            Console.WriteLine("Enter Two to calculate intial principle balance");
            Console.WriteLine("Enter Three to calculate annual interest rate");
            Console.WriteLine("ENter Four to calculate time");
            line();
            input= Console.ReadLine();
            inputParse=int.TryParse(input, out inputParseAns);


            if (inputParse==true)
            {
                if (inputParseAns == 1)
                {
                    Console.WriteLine("Input intinitial principal balance");
                    principleBalance=(Convert.ToInt32( Console.ReadLine()));

                    Console.WriteLine("Input annual interest rate ");
                   interestRate = (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Input time (in years)");
                    time = (Convert.ToInt32(Console.ReadLine()));
                    finalAmount = (principleBalance * interestRate * time)/100;
                    Console.WriteLine( "Simple interest ="+finalAmount);
                }
                else if(inputParseAns == 2) {
                    Console.WriteLine("Input annual interest rate");
                   interestRate = (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("SImple interest");
                    vSimpleInterest = (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Input time (in years)");
                    time = (Convert.ToInt32(Console.ReadLine()));
                    finalAmount = (100* vSimpleInterest)/(time *interestRate) ;

                    Console.WriteLine("initial principal balance: " + finalAmount);

                }
                else if (inputParseAns == 3) {
                    Console.WriteLine("Input initial principal balanc rate");
                   principleBalance= (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("SImple interest");
                    vSimpleInterest = (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Input time (in years)");
                    time = (Convert.ToInt32(Console.ReadLine()));
                    finalAmount = (100 * vSimpleInterest) / (principleBalance * interestRate);

                    Console.WriteLine("annual interest rate: " + finalAmount);

                }
                else if (inputParseAns == 4){


                    Console.WriteLine("Input annual interest rate");
                    interestRate = (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Simple interest");
                    vSimpleInterest = (Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Input initial principal balance");
                    principleBalance= (Convert.ToInt32(Console.ReadLine()));


                    finalAmount = (100 * vSimpleInterest) / (principleBalance* interestRate);
                    Console.WriteLine("time (in years): " + finalAmount);
                }
                else
                {
                    Console.WriteLine("Input a valid option");
                  
                }

            }
            else
            {
                Console.WriteLine("Input a valid value");
            }

        
        }
        public static void line()
        {
            Console.WriteLine();
       
            for(int i = 1; i< 5; i++){

                Console.WriteLine("*");
                for(int j = 1; j < 5; j++)
                {
                    Console.Write("*");
                 
                }
             
                }
           
             
            }

    }
}

  
   






