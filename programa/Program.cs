﻿using System;
//Alteração realizada na branch_vaz_1
namespace Jewel_Collector 
{
    //Alteração realizada na branch_vaz_2
    public class JewelCollector {
        public static void Main() {

            bool running = true;

            Map map = new Map();

            do 
            {
                

                //Outro comentário da branch 2 - Conflito resolvido
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