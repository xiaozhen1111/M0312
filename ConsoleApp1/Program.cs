using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("購買金額");
            int money = 1000;

            while (true)
            {
                //判斷
                if (money <= 0)
                {
                    Console.WriteLine("你已經破產...");
                    break;
                }

                //檢查花費
              
               
                string costString = Console.ReadLine();
                int cost = int.Parse(costString);
               

                //扣錢

                money = money - cost;

            }
            Console.ReadLine();
        }
    }
}
