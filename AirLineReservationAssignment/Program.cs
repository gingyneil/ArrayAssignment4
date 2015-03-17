using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// NEIL READING
//STUDENT NUMBER: 300793474
//ASSIGNMENT 4 
// MARCH/15/2015
//COMP123 

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
           bool[] planeSeats = new bool[10];
           int menuChoice = 0;
           int secondChoice;
           int index=0;
           int index2 = 5;
           int thirdChoice;
           int exitNow =2;

            while (menuChoice != 3 && exitNow < 3)
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
                            else if (index <= 10) 
                            {

                                Console.WriteLine("Sorry First Class Seating is Full. Would you like to be situated in the Econonmy Class? ");
                                Console.WriteLine("Press 1 for Yes or 2 for No ");
                                secondChoice = Convert.ToInt32(Console.ReadLine());
                                switch (secondChoice) 
                                {
                                    case 1:
                                        {
                                            if (index2 < 10)
                                            {

                                                Console.WriteLine(index2);
                                                planeSeats[index2] = true;

                                                Console.WriteLine(planeSeats[0]);
                                                Console.WriteLine(planeSeats[1]);
                                                Console.WriteLine(planeSeats[2]);
                                                Console.WriteLine(planeSeats[3]);
                                                Console.WriteLine(planeSeats[4]);
                                                Console.WriteLine(planeSeats[5]);
                                                Console.WriteLine(planeSeats[6]);
                                                Console.WriteLine(planeSeats[7]);
                                                Console.WriteLine(planeSeats[8]);
                                                Console.WriteLine(planeSeats[9]);
                                                Console.WriteLine();
                                                index2 += 1;
                                                menuChoice = 2;
                                                
                                            }
                                            else if (index2 >= 10)
                                            {
                                                
                                                FullPlane();
                                                exitNow += 1;
                                                

                                                menuChoice = 3;
                                                break;
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            NextFlight();
                                            exitNow += 1;

                                            menuChoice = 3;
                                            break;
                                        }
                                } 
                                
                            }

                            Console.WriteLine(planeSeats[0]);
                            Console.WriteLine(planeSeats[1]);
                            Console.WriteLine(planeSeats[2]);
                            Console.WriteLine(planeSeats[3]);
                            Console.WriteLine(planeSeats[4]);
                            Console.WriteLine(planeSeats[5]);
                            Console.WriteLine(planeSeats[6]);
                            Console.WriteLine(planeSeats[7]);
                            Console.WriteLine(planeSeats[8]);
                            Console.WriteLine(planeSeats[9]);
                            Console.WriteLine();
                            break;
              
                        }
                    case 2:
                        {
                            
                            if (index2 < 10)
                            {
                                Console.WriteLine(index2);
                                planeSeats[index2] = true;
                                menuChoice = 0;
                                index2 +=1;
                                Console.WriteLine(planeSeats[0]);
                                Console.WriteLine(planeSeats[1]);
                                Console.WriteLine(planeSeats[2]);
                                Console.WriteLine(planeSeats[3]);
                                Console.WriteLine(planeSeats[4]);
                                Console.WriteLine(planeSeats[5]);
                                Console.WriteLine(planeSeats[6]);
                                Console.WriteLine(planeSeats[7]);
                                Console.WriteLine(planeSeats[8]);
                                Console.WriteLine(planeSeats[9]);
                                Console.WriteLine();
                            }
                            else if (index2 >= 10)
                            {
                                Console.WriteLine("++++Sorry Econonmy Seating is full.++++ ");
                                Console.WriteLine();
                                Console.WriteLine("Would you like First Class Seating? ");
                                Console.WriteLine();
                                Console.WriteLine("Press 1 for yes or 2 for no or 3 to exit the system ");

                              thirdChoice = Convert.ToInt32(Console.ReadLine());
                              switch (thirdChoice) 
                              {
                                  case 1: 
                                      {
                                          if(index >= 5)
                                          {
                                              Console.WriteLine(planeSeats[0]);
                                              Console.WriteLine(planeSeats[1]);
                                              Console.WriteLine(planeSeats[2]);
                                              Console.WriteLine(planeSeats[3]);
                                              Console.WriteLine(planeSeats[4]);
                                              Console.WriteLine(planeSeats[5]);
                                              Console.WriteLine(planeSeats[6]);
                                              Console.WriteLine(planeSeats[7]);
                                              Console.WriteLine(planeSeats[8]);
                                              Console.WriteLine(planeSeats[9]);
                                              Console.WriteLine();

                                              FullPlane();
                                              exitNow += 1;
                                          }
                                          else if(index <= 5)
                                          {
                                              planeSeats[index] = true;
                                              index += 1;
                                                Console.WriteLine(planeSeats[0]);
                                                Console.WriteLine(planeSeats[1]);
                                                Console.WriteLine(planeSeats[2]);
                                                Console.WriteLine(planeSeats[3]);
                                                Console.WriteLine(planeSeats[4]);
                                                Console.WriteLine(planeSeats[5]);
                                                Console.WriteLine(planeSeats[6]);
                                                Console.WriteLine(planeSeats[7]);
                                                Console.WriteLine(planeSeats[8]);
                                                Console.WriteLine(planeSeats[9]);
                                                Console.WriteLine();
                                          }
                                          break;
                                      }
                                  case 2: 
                                      {
                                          NextFlight();
                                          exitNow += 1;

                                          menuChoice = 3;
                                          break;
                                      }
                              }
                              
                            }
                            
                            break;
                        }
                    case 3: 
                        {
                            ExitingSystem();
                            exitNow += 1;
                            
                            break;
                        }

                    
                }

            }
}

  
        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++
   private static void ExitingSystem()// METHOD to display the Exiting system message
   {
       Console.WriteLine("Exiting the system ");
       Console.WriteLine("Press any key to continue ");
       Console.ReadKey();

   
   }
   private static void FirstClassFUll() // Method to display that first class seating is full.
   {
       Console.WriteLine("Sorry First Class seating is full ");
       
   }
   private static void EconomyClassFull() // Method to display that the economy class seating is full
   {
       Console.WriteLine(" Sorry the Economy Class is full ");
       
   }
   private static void NextFlight() // Next flight message method
   {
       Console.WriteLine("+++++++++++++++++++Next Flight Leaves in 3 Hours.++++++++++++ ");
       ExitingSystem();

       
   }
   private static void FullPlane()// FUll plane method message
   {
       Console.WriteLine("Sorry the plane is FULL ");
       ExitingSystem();
   }
    }
}

