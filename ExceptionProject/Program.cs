using System;
using My = ExceptionLibrary;
namespace ExceptionProject {
    class Program {

            void Run() {
            try {
                var ans = My.Math.Add(1, 2);
                ans = My.Math.Sub(ans, 2);
                ans = My.Math.Mult(100, ans);
                ans = My.Math.Div(17183, 5);
                Console.WriteLine($"Answer is {ans}");
            } catch(My.Greaterthan100Exception fred) {
                Console.WriteLine(fred.Message);
            }
            catch(System.IO.IOException fred) {

            } catch(Exception fred) {

            }
            finally {
                Console.WriteLine("Yeet");
            }

        }
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
            


        }
    }
}
