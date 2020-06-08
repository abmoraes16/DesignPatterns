using System;
using System.Collections.Generic;

namespace LabirintoBuilder
{
    class Labirinto
    {
        public double Area { get; set; }
        public int Portas { get; set; }
        public int Paredes { get; set; }
        public int Inimigos { get; set; }
            
        public void Show()
        {
            Console.WriteLine("\nO Labirinto possui "
                                +Area+"m² de área, "
                                +Portas+" portas, "
                                +Paredes+" paredes e "
                                +Inimigos+" inimigos."
            );
        }
    }
}