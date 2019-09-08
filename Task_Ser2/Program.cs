using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Task_Ser2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Добро пожаловать в рулетку. Хорошей игры!\n");
            
            List<string> a = new List<string>();
            
            string finish = string.Empty;
            int sum = 500;
            

            do 
            {

                string rate = string.Empty;

                Console.WriteLine(" Ваше количество фишек равно " + sum);
                Console.WriteLine("\n Прошлые игры: ");
                a.Add(finish);
                

               

                for(int i = 1; i < a.Count; i++)
                {
                   if (a.Count == 1)
                    {
                        break;
                    }
                   
                   Console.WriteLine(i + ")" + a[i]);
              
                }

                Console.WriteLine(" \n Какую вы хотите сделать ставку: \n 1) На число \n 2) На четное или не четное \n 3) На красное или черное \n");


                rate = CheckOneTwoThree(rate);

                
               Message(rate, ref sum, ref finish);

  
            } while (true);

        }

        static string CheckOneTwoThree(string rate)
        {
            int check;
            do
            {

                rate = Console.ReadLine();
                check = Convert.ToInt32(rate);

                if (check >= 1 && check <= 3)
                {
                    break;
                }

                Console.WriteLine("\n Вы ввели неправильный номер ставки, введите пожалуйста 1 до 3 \n");


            }
            while (check > 3 || check < 1);

            return rate;


        }

        static void Message(string ConditionNumber, ref int sum, ref string finish)
        {

            switch (ConditionNumber)
            {
                case "1":
                    Console.WriteLine("\n Вы можете сделать ставку от 1 до 50 фишек на число");
                    Console.WriteLine("\n Введите сумму ставки");
                    string fichk1 = Console.ReadLine();
                    fichk1 = CheckPush(fichk1, ConditionNumber, sum);
                    Console.WriteLine("\n На какое число вы делаете ставку? \n");
                    string number1 = Console.ReadLine();
                    number1 = NumberPush(number1);
                    Console.WriteLine("\n Ставка принята \n");

                    Result(number1, fichk1, ConditionNumber, ref sum, ref finish);

                    break;

                case "2":
                    Console.WriteLine("\n Выберите четное или нечетное \n 1) Четное \n 2) Нечетное");
                    string OneTwo = Console.ReadLine();
                    OneTwo = CheckOneTwo(OneTwo);
                    Console.WriteLine("\n Вы можете сделать ставку от 1 до 250 фишек на четное или не четное \n");
                    Console.WriteLine("\n Введите сумму ставки \n");
                    string fichk2 = Console.ReadLine();
                    fichk2 = CheckPush(fichk2, ConditionNumber, sum);
                    Console.WriteLine("\n Ставка принята");

                    Result(fichk2, OneTwo, ref sum, ref finish);

                    break;


                case "3":
                    Console.WriteLine("\n Выберите красное или черное \n 1) Красное \n 2) Черное");
                    string BlackRed = Console.ReadLine();
                    BlackRed = CheckOneTwo(BlackRed);
                    Console.WriteLine("\n Вы можете сделать ставку от 1 до 250 фишек на красное или черное \n");
                    Console.WriteLine("\n Введите сумму ставки \n");
                    string fichk3 = Console.ReadLine();
                    fichk3 = CheckPush(fichk3, ConditionNumber, sum);

                    Console.WriteLine("\n Ставка принята \n");

                    Result(fichk3, BlackRed, ref sum, ref finish);

                    break;


            }

        }
        static string CheckOneTwo(string OneTwo)
        {
            int check;
            do
            {


                check = Convert.ToInt32(OneTwo);

                if (check >= 1 && check <= 2)
                {
                    break;
                }

                Console.WriteLine("\n Вы ввели неправильный номер ставки, введите пожалуйста 1 до 2 \n");

                OneTwo = Console.ReadLine();

                
            }
            while (check > 2 || check < 1);
            return OneTwo;
        }


        static string CheckPush(string fichk, string nomerCase, int sum)
        {



            switch (nomerCase)
            {
                case "1":
                    int check1;
                    do
                    {
                        check1 = Convert.ToInt32(fichk);

                        if (check1 >= 1 && check1 <= 50 && check1 < sum)
                        {


                            break;
                        }                     
                        else
                        {
                            Console.WriteLine("\n Вы ввели либо неправильное количество фишек, либо на счету у вас меньше чем вы поставили, введите снова от 1 до 50 \n");
                            fichk = Console.ReadLine();

                        }
                       


                    }
                    while (check1 > 50 || check1 < 0);
                    break;
                    
                    

                case "2":
                    int check2;

                    do
                    {
                        check2 = Convert.ToInt32(fichk);

                        if (check2 >= 1 && check2 <= 250 && check2 < sum)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n Вы ввели либо неправильное количество фишек, либо на счету у вас меньше чем вы поставили, введите снова от 1 до 250 \n");
                            fichk = Console.ReadLine();

                        }
                        
                    }
                    while (check2 > 250 || check2 < 0);
                    break;

                case "3":
                    int check3;

                    do
                    {
                        check3 = Convert.ToInt32(fichk);

                        if (check3 >= 1 && check3 <= 250 && check3 < sum)
                        {

                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n Вы ввели либо неправильное количество фишек, либо на счету у вас меньше чем вы поставили, введите снова от 1 до 250 \n");
                            fichk = Console.ReadLine();

                        }
                        
                    }
                    while (check3 > 250 || check3 < 0);
                    break;


            }
            return fichk;

        }
        static string NumberPush(string number1)
        {
            int check;
            do {


               
                check = Convert.ToInt32(number1);

                if (check >= 0 && check <= 36)
                {

                    break;
                }
                
                    Console.WriteLine("\n Вы ввели неправильное номер числа, введите снова от 0 до 36 \n");

                number1 = Console.ReadLine();


            }
            while (check > 37 || check < 0);

            return number1;
        }
        static void Result(string number, string fichk, string ConditionNumber, ref int sum, ref string finish)
        {

            Random rand = new Random();
            int resultrand;
            resultrand = rand.Next(37);
            int ConvertNumber;
            int ConvertFichk;
            ConvertNumber = Convert.ToInt32(number);
            ConvertFichk = Convert.ToInt32(fichk);

            Console.WriteLine("\n Вы поставили " + fichk + " фишек на номер " + number);


            if (resultrand % 2 == 0)
            {
                finish = Convert.ToString("Выпало число " + resultrand + " красное \n");
                 Console.WriteLine("\n Выпало число " + resultrand + " красное \n");
                
            }
            else
            {
                finish = Convert.ToString("Выпало число " + resultrand + " красное \n");
                Console.WriteLine("\n Выпало число " + resultrand + " черное \n");
            }
           


            if (resultrand == ConvertNumber)
            {
                ConvertFichk = (ConvertFichk) * 35;
                Console.WriteLine("\n Вы выиграли " + ConvertFichk + " фишек " + "\n Теперь на вашем счету " + sum+ConvertFichk + " фишек \n");
            }
            else
            {
                sum = sum - ConvertFichk;

                Console.WriteLine("\n Вы проиграли " + ConvertFichk + " фишек " + "\n Теперь на вашем счету " + sum + " фишек \n");

            }
           





        }
        static int Result(string fichk, string OneTwo, ref int sum, ref string finish)
        {
            Random rand = new Random();
            int resultrand;
            resultrand = rand.Next(37);
            
            int ConvertFichk;

            ConvertFichk = Convert.ToInt32(fichk);

            switch (OneTwo)
            {

                case "1":

                    Console.WriteLine("\n Вы поставили " + fichk + " фишек \n");


                    if (resultrand % 2 == 0)
                    {
                        finish = Convert.ToString("Выпало число " + resultrand + " красное \n");
                        Console.WriteLine("\n Выпало число " + resultrand + " красное \n");
                    }
                    else
                    {
                        finish = Convert.ToString("Выпало число " + resultrand + " красное \n");
                        Console.WriteLine("\n Выпало число " + resultrand + " черное \n");
                    }

                    if (resultrand % 2 == 0)
                    {
                        
                        ConvertFichk = ConvertFichk * 2;
                        sum = sum + (ConvertFichk/2);
                        Console.WriteLine("\n Вы выиграли " + ConvertFichk/2 + " фишек " + "\n Теперь на вашем счету " + sum + " фишек \n");
                    }            
                    else
                    {
                        sum = sum - ConvertFichk;

                        Console.WriteLine("\n Вы проиграли " + ConvertFichk + " фишек " + "\n Теперь на вашем счету " + sum + " фишек \n");

                    }

                    break;

                case "2":


                    Console.WriteLine("\n Вы поставили " + fichk + " фишек \n");


                    if (resultrand % 2 == 0)
                    {
                        finish = Convert.ToString("Выпало число " + resultrand + " красное \n");
                        Console.WriteLine("\n Выпало число " + resultrand + " красное \n");
                    }
                    else
                    {
                        finish = Convert.ToString("Выпало число " + resultrand + " красное \n");
                        Console.WriteLine("\n Выпало число " + resultrand + " черное \n");
                    }

                    if (resultrand % 2 != 0)
                    {
                        ConvertFichk = ConvertFichk * 2;
                        sum = sum + (ConvertFichk / 2);
                        Console.WriteLine("\n Вы выиграли " + ConvertFichk/2 + " фишек " + "\n Теперь на вашем счету " + sum + " фишек \n");
                        
                    }
                    else
                    {
                        sum = sum - ConvertFichk;

                        Console.WriteLine("\n Вы проиграли " + ConvertFichk + " фишек " + "\n Теперь на вашем счету " + sum + " фишек \n");
                        
                    }

                    

                    break;

            }

            return sum;


        }
}   }
