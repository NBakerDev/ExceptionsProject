using System;
using System.Collections.Generic;
using System.Text;
namespace ExceptionLibrary {
   public class Math {

        public static int Add(int i1, int i2) {
            return i1 + i2;
        }

        public static int Sub(int i1, int i2) {
            return i1 - i2;
        }


        public static int Mult(int i1, int i2) {
            if (i1*i2 >= 100) {
                var lx = new Greaterthan100Exception("Number is Greater than 100");
                lx.i1 = i1;
                lx.i2 = i2;
                throw lx;
            }
            return i1 * i2;
            

        }


        public static int Div(int i1, int i2) {
            if (i1 == 17183) {
                var ex = new Ex17183Exception("Test Exception");
                ex.AdditionalData = "In the Div Method";
                throw ex;
            }
                return i1 / i2;
            
        }
   }
}
