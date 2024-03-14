using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Tracker
{
    public class TemperatureTracker
    {
        public int[] dailytemp;

        public void temperatureTracker(int days)
        {
            dailytemp = new int[days];
        }

        public void settemp(int days,double temp)
        {
            for (days = 1; days <= dailytemp.Length; days++)
            {

                dailytemp[days] = (int)temp;
            }
        }

        public void Displaytemperature()
        {
            Console.WriteLine("Weakly tempersture:");

            for(int i = 0; i < dailytemp.Length; i++)
            {
                Console.WriteLine($"Temperature of day {i+1} is { dailytemp[i]}");
            }
        }



            
            
    }

    class program
    {
        static void Main(string[] args)
        {
            int days = 7;
            TemperatureTracker temp = new TemperatureTracker(days);
            


        }
    }
}
