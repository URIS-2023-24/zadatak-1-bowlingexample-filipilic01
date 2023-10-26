using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Task_IT7g2020.ConsoleApplication
{
    public class Program
    {
        
         static void Main(string[] args)
        {
            Random Random = new Random();
            List<int> throws = new List<int>();
            bool[] strikes = new bool[10];
            bool[] spares = new bool[10];
       
           // Result Result = new Result();
            Console.WriteLine("*****************Dobrodosli u Bowling Bar!*****************************");
            Console.WriteLine("Klikom na bilo koji taster na tastaturi mozete zapoceti partiju!");
            string str = Console.ReadLine();
            for(int i = 1; i <= 10; i++)
            {
               
                Console.WriteLine("FRAME broj " + i);
                Console.WriteLine("I bacanje");
                Frame frame = new Frame();
               
                string s = Console.ReadLine();
                frame.Throw1 = Random.Next(0, 11);
                Console.WriteLine("Broj pogodjenih cunjeva u I bacanju: " + frame.Throw1);
                
                //Console.WriteLine("Ukupan broj pogodjenih cunjeva u partiji: " + ResultSummary(throws));
               
                if (frame.Throw1 == 10)
                {
                    Console.WriteLine("STRIKE! STRIKE! STRIKE!");
                    strikes[i-1]=true;
                    spares[i - 1] = false;
                   
                }
                else
                {
                    Console.WriteLine("II bacanje");
                    string st = Console.ReadLine();
                    strikes[i-1]=false;
                    frame.Throw2 = Random.Next(0, 11-frame.Throw1);
                    Console.WriteLine("Broj pogodjenih cunjeva u II bacanju: " + frame.Throw2);
                    
                    if (frame.Throw2 == 10 - frame.Throw1)
                    {
                        Console.WriteLine("SPARE! SPARE! SPARE!");
                        spares[i - 1] = true;
                        
                       
                    }
                    else
                    {
                        spares[i-1]= false;
                    }
                  

                }
                if(i==1)
                {
                    Console.WriteLine("Broj pogodjenih cunjeva u frejmu " + i + " je: " + frame.FrameSummary(frame.Throw1, frame.Throw2));
                    throws.Add(frame.Throw1);
                    throws.Add(frame.Throw2);
                }
                else if (strikes[i-2] && !spares[i-2])
                {
                    Console.WriteLine("Broj pogodjenih cunjeva u frejmu " + i + " je: " + frame.FrameSummary(frame.Throw1*2, frame.Throw2*2));
                    throws.Add(frame.Throw1*2);
                    throws.Add(frame.Throw2*2);
                }
                else if (!strikes[i - 2] && spares[i - 2])
                {
                    Console.WriteLine("Broj pogodjenih cunjeva u frejmu " + i + " je: " + frame.FrameSummary(frame.Throw1 * 2, frame.Throw2));
                    throws.Add(frame.Throw1 * 2);
                    throws.Add(frame.Throw2);
                }
                else
                {
                    Console.WriteLine("Broj pogodjenih cunjeva u frejmu " + i + " je: " + frame.FrameSummary(frame.Throw1, frame.Throw2));
                    throws.Add(frame.Throw1);
                    throws.Add(frame.Throw2);
                }
                Console.WriteLine("Ukupan broj pogodjenih cunjeva u partiji: " + ResultSummary(throws));
                if (i == 10 && (frame.Throw1+frame.Throw2)==10)
                {
                    Console.WriteLine("Ostvarili ste pravo na dodatno bacanje!");
                    string strin = Console.ReadLine();
                    ExtraThrow(throws);


                }

            }


        
            
        }

        public static int ResultSummary(List<int> throws)
        {
            int sum = 0;
            foreach (var item in throws)
            {
                sum = sum + item;
            }
            return sum;
        }

        public static void ExtraThrow(List<int> throws)
        {
            Random Random = new Random();
            Console.WriteLine("DODATNO BACANJE!");
                
            Frame frame = new Frame();

            string s = Console.ReadLine();
            frame.Throw1 = Random.Next(0, 11);
            Console.WriteLine("Broj pogodjenih cunjeva u dodatnom bacanju: " + frame.Throw1);

            throws.Add(frame.Throw1 * 2);

            Console.WriteLine("Ukupan broj pogodjenih cunjeva u partiji: " + ResultSummary(throws));


        }
    }
}
