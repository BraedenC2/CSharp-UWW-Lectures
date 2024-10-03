using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures {

    public static class Recursion {

        private static void Main() {

            for ( int i = 0; i < 2000; i++ ) Console.WriteLine(Fibonacci(i));
            
        }

        private static int Factorial( int n ) {

            if ( n == 0 ) return 1;
            return n * Factorial( n - 1 );

        }

        private static int Fibonacci( int n ) {
            
            if ( n <= 1 ) return n;

            return Fibonacci( n - 1 ) + Fibonacci( n - 2 );

        }
    }
}
