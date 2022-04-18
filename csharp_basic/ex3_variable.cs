using System;

namespace csharp_basic
{
    public class ex3_variable
    {
        public static void ex3(){
            int a = 1;
            int b = 2;

            Console.WriteLine("a = "+ a );
            Console.WriteLine("a = {0}", a );
            Console.WriteLine("a = {0}, b = {1} ", a, b );







        float speed = 8.3f;
        float time = 10.258987894445f;
        float distance = speed * time;
        
        Console.WriteLine("Mateo runs at speed {0} m/s in {1} seconds", speed, time);
        Console.WriteLine("Total run distance {0} meters", distance);
        
        Console.WriteLine("------------------");
        
        float lightSpeed = 5.8786E12f; // 5.8786 x 10^12 
        Console.WriteLine("Light can travel {0} miles in 1 year", lightSpeed);
        
        Console.WriteLine("------------------");
        
        double day = 365.2578954658789567;
        double neutronMass = 1.674927471E-27;
        double pi = 22 / 7.0f;
        Console.WriteLine("Earth take about {0} day to orbit the sun", day);
        Console.WriteLine("PI value = {0}", pi);
        Console.WriteLine("Neutron Mass = {0} kg", neutronMass);
        
        Console.WriteLine("------------------");
        
        // Difference between decimal, float and double
        // Float - 7 digits (32 bit)
        // Double-15-16 digits (64 bit)
        // Decimal -28-29 significant digits (128 bit)
        
        float flt = 1f/3;
        double dbl = 1d/3;
        decimal dcm = 1m/3;
        Console.WriteLine("float: {0} \ndouble: {1} \ndecimal: {2}", flt, dbl, dcm);


        Console.WriteLine(false ? "A":20);

        string[] animals = {"dog","cat","meow"};

        foreach (string dog in animals)
        {
            Console.WriteLine(dog);
        }


        for (int i = 1; i < 10; i++){
            Console.WriteLine(i);
           // continue;
            Console.WriteLine(i);
        }
        
        int[] num = {1,2,3,4,5};
        Console.WriteLine(num[1]);
        Console.WriteLine(string.Join("baaa","a"));


        
        }
 
    }
}