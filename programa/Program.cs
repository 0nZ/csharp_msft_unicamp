using System;
//Alteração realizada na branch_vaz_1
namespace Jewel_Collector 
{
    public class JewelCollector {
        public static void Main() {

            bool running = true;

            Map map = new Map();

            do 
            {
                
                //Outro comentário da branch 1
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Q) {

                    running = false;

                } else {
                    map.PrintMap();
                }
                
            } while (running);
        }
    }
}