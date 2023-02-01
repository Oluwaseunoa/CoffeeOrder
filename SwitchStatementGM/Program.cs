using System;

namespace ConditionalStateMent
{
    class Program
    {
        static void Main()
        {   

            //Gave the below variable a universal scope
            int totalCost = 0;

            Console.WriteLine("Welcome to McSeun Coffee");

            start:
            Console.WriteLine("Make your order: \n Enter 1 for size 1  at N10 \n Enter 2 for size 2 at N20 \n Enter 3 for size 3 at N30");

            string customerPick = Console.ReadLine();

            //Serves as an adder 
            int orderCost;
             
            string userResponse;

            if(customerPick == "1")
            {
                orderCost =  10;
                totalCost = totalCost + orderCost;
            }
            else if (customerPick == "2")
            {
                orderCost = 20;
                totalCost = totalCost + orderCost;
            }
            else if (customerPick == "3")
            {
                orderCost = 30;
                totalCost = totalCost + orderCost;
            }
            else
            {
                Console.WriteLine("Please select a valid size between 1 and 3");
                Console.WriteLine("Do you want to try again? \n YES or NO");
                userResponse = Console.ReadLine();

                if(userResponse.ToUpper() == "YES")
                {
                    goto start;
                }
                else if(userResponse.ToUpper() == "NO")
                {
                    goto end; 
                }


            }

            Console.WriteLine("Do you want another coffee? \n YES or NO?");

            userResponse = Console.ReadLine();

            if(userResponse.ToUpper() == "YES")
            {
                goto start;
            }
            else if (userResponse.ToUpper() == "NO")
            {
                goto end1;
            }


        end1:
            Console.WriteLine("Your bill is {0}", totalCost);

            end:
            Console.WriteLine("Thank you for your patronage.");
        }
    }

}
