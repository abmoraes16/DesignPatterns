using System;
using System.Collections.Generic;

namespace ExampleBuilder2
{
    class Labirinto
    {
        public int Portas { get; set; }
        public int Paredes { get; set; }
        public int Inimigos { get; set; }
            
        public void Show()
        {
            Console.WriteLine("\nO Labirinto possui "
                                +Portas+" portas, "
                                +Paredes+" paredes e "
                                +Inimigos+" inimigos."
            );
        }
    }
}