using System;

namespace ExceptionLibrary {
        public class Greaterthan100Exception : Exception {

        public int i1 { get; set; }
        public int i2 { get; set; }

        public string AdditionalData { get; set; }

            public Greaterthan100Exception() : base() {

            }
            public Greaterthan100Exception(string message) : base(message) {
            Console.WriteLine("Number is greater than 100");
            }
            public Greaterthan100Exception(string message, Exception innerException) : base(message, innerException) {

            }
        }
    }

