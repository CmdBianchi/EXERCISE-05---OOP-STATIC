using System;
namespace EXERCISE_05___OOP_STATIC{
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {      
        static void Main(string[] args) {
            Console.Write("Entre com o valor do Raio: "); double radius = double.Parse(Console.ReadLine());
            double circ = Calculator.Cicle(radius);
            double volume = Calculator.Volume(radius);

            Console.Write("Valor da circunferencia: "+circ.ToString("F2"));
            Console.WriteLine();
            Console.Write("Valor do Volume: "+volume.ToString("F2"));
            Console.WriteLine();
            Console.Write("Valor de PI: "+Calculator.Pi.ToString("F2"));

        }
        
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
