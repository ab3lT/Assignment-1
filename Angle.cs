using System;

namespace assignment_one{
    class Angle{
        public static void hourmun(){

            try{
                Console.Write("Enter the hours : ");
                
            int hours = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());
            
            double hourInDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegrees = minutes * 6;
            double diff = Math.Abs(hourInDegrees - minuteInDegrees);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"\n>>> Angle between {hours} hour and {minutes} minute is {diff} degrees <<<");
            
            }
            catch{Console.WriteLine("invalid input please try again\n -----------------");
            hourmun();
            }
    }
}
}