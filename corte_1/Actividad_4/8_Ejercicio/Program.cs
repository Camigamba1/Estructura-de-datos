using System;

namespace PUNTO_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int crow,level,more,little,height,high = 0;
           
            Console.Write("Ingrese el numero de personas ");
            crow = Convert.ToInt32(Console.ReadLine());

            for(int i = 1;  i <= crow; i++)
                {
                  Console.Write("Ingrese la altura");
                  height = int.Parse(Console.ReadLine());
                  more += height;
                  level = more/crow;
    
                   if (height < level)
                       {
                          little = little + 1;
                       }
                    if ( height > level)
                    {
                          high = high +1;
                    }
                }
            Console.WriteLine("Cantidad de gente con la altura mas baja que el promedio:");
            Console.WriteLine(high);
            Console.WriteLine("Cantidad de gente con la altura mas alta que el promedio:");
            Console.WriteLine(little);
        }
    }
}
