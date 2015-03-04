using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineReservationAssignment
{
    class Program
    {
       
        static void Main(string[] args)
        {
            menu();
        
        
        }
    
   private static void menu()
        {
           bool[] planeSeats = new bool[9];
           bool bChecker = false;
           int menuChoice = 0;
           int secondChoice;
           int index=0;

            while (menuChoice != 3)
            {
                Console.WriteLine("+++++++++ Customer Menu ++++++++++++");
                Console.WriteLine("Please Enter A Number of your Choice:");
                Console.WriteLine("Press 1 for First Class 2 for Economy Class or 3 to Exit");


                try
                {
                    menuChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error) 
                {
                    menuChoice = 0;
                }

                
                switch (menuChoice) 
                {
                    
                    case 1:
                        {
                            if (index < 5)
                            {
                                planeSeats[index] = true;
                                menuChoice = 0;
                                index += 1;
                            }
                            else if (index >= 5) 
                            {

                                Console.WriteLine("Would you like to be situated in the Econonmy Class? ");
                                Console.WriteLine("Press 1 for Yes or 2 for No ");
                                secondChoice = Convert.ToInt32(Console.ReadLine());
                                switch (secondChoice) 
                                {
                                    case 1:
                                        {
                                            menuChoice =2;
                                            break;
                                        }
                                    case 2:
                                        {
                                            menuChoice = 3;
                                            break;
                                        }
                                } 
                                
                            }
                            
                            
                            break;
                        }
                    case 2:
                        {
                            index += 5;
                            if (index < 10)
                            {
                                planeSeats[index] = true;
                                menuChoice = 0;
                            }
                            else if (index >= 10)
                            {
                                Console.WriteLine("Sorry the plan is full "); 
                            }
                            index -= 4;
                            break;
                        }
                        

                }

            }
}
    }
}
