using System;

namespace Accumulator2 {
    class Program {
        static void Main1() {

            var total = 0;
            for(var idx = 0; idx <= 50; idx++) {
                if(idx % 5 == 0 || idx % 7 == 0)
                    total += idx;
            }
            Console.WriteLine($"Total is {total}");
        }

        static void Main() {
            int[] ints = {
                754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
                187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
                460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
                690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
                435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };
            var highest = 0;
            var lowest = 1000;
            foreach(var i in ints) {
                if(i < lowest) {
                    lowest = i;
                }
                if(i > highest) {
                    highest = i;
                }
            }
            Console.WriteLine($"Highest is {highest}; lowest is {lowest}");
        }
    }
}


