using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_05___OOP_STATIC{
    //----------------------START | OBJ RETANGULO------------------------//
    class Calculator {
        public static double Pi = 3.14;
        public static double Cicle(double r) {
            return 2 * Pi * r;
        }
        public static double Volume(double r) { 
            return ( 4/3)*Pi*r*r*r;
        }
    }
    //--------------------------- END --------------------------------//  
}
