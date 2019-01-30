using System;
using System.Collections.Generic;
using System.Text;

namespace BackAlleyDiceShooter
{
    class Commands
    {
        /* 
           1. Big 
           2. Small 
           3. Odd 
           4. Even
           5. All 1s 
           6. All 2s 
           7. All 3s 
           8. All 4s
           9. All 5s 
           10. All 6s 
           11. Double 1s 
           12. Double 2s
           13. Double 3s 
           14. Double 4s 
           15. Double 5s 
           16. Double 6s
           17. Any triples 
           18. 4 or 17 
           19. 5 or 16 
           20. 6 or 15
           21. 7 or 14 
           22. 8 or 13 
           23. 9 or 12 
           24. 10 or 11
         */
        public static void checkCommands(int command)
        {
            // Check command from player intput
            switch (command)
            {
                // Big
                case 1:
                    Player.setMove(1);
                    Console.WriteLine("[{0}] chose Big", Player.getName());
                    break;
                // Small
                case 2:
                    Player.setMove(2);
                    Console.WriteLine("[{0}] chose Small", Player.getName());
                    break;
                // Odd
                case 3:
                    Player.setMove(3);
                    Console.WriteLine("[{0}] chose Odd", Player.getName());
                    break;
                // Even
                case 4:
                    Player.setMove(4);
                    Console.WriteLine("[{0}] chose Even", Player.getName());
                    break;
                // Triples
                case 5:
                    Player.setMove(5);
                    Console.WriteLine("[{0}] chose All 1s", Player.getName());
                    break;
                case 6:
                    Player.setMove(6);
                    Console.WriteLine("[{0}] chose All 2s", Player.getName());
                    break;
                case 7:
                    Player.setMove(7);
                    Console.WriteLine("[{0}] chose All 3s", Player.getName());
                    break;
                case 8:
                    Player.setMove(8);
                    Console.WriteLine("[{0}] chose All 4s", Player.getName());
                    break;
                case 9:
                    Player.setMove(9);
                    Console.WriteLine("[{0}] chose All 5s", Player.getName());
                    break;
                case 10:
                    Player.setMove(10);
                    Console.WriteLine("[{0}] chose All 6s", Player.getName());
                    break;
                case 11:
                    // Doubles
                    Player.setMove(11);
                    Console.WriteLine("[{0}] chose Double 1s", Player.getName());
                    break;
                case 12:
                    Player.setMove(12);
                    Console.WriteLine("[{0}] chose Double 2s", Player.getName());
                    break;
                case 13:
                    Player.setMove(13);
                    Console.WriteLine("[{0}] chose Double 3s", Player.getName());
                    break;
                case 14:
                    Player.setMove(14);
                    Console.WriteLine("[{0}] chose Double 4s", Player.getName());
                    break;
                case 15:
                    Player.setMove(15);
                    Console.WriteLine("[{0}] chose Double 5s", Player.getName());
                    break;
                case 16:
                    Player.setMove(16);
                    Console.WriteLine("[{0}] chose Double 6s", Player.getName());
                    break;
                // Any Triple
                case 17:
                    Player.setMove(17);
                    Console.WriteLine("[{0}] chose Any triples", Player.getName());
                    break;
                // Sums
                case 18:
                    Player.setMove(18);
                    Console.WriteLine("[{0}] chose 4 or 17", Player.getName());
                    break;
                case 19:
                    Player.setMove(19);
                    Console.WriteLine("[{0}] chose 5 or 16", Player.getName());
                    break;
                case 20:
                    Player.setMove(20);
                    Console.WriteLine("[{0}] chose 6 or 15", Player.getName());
                    break;
                case 21:
                    Player.setMove(21);
                    Console.WriteLine("[{0}] chose 7 or 14", Player.getName());
                    break;
                case 22:
                    Player.setMove(22);
                    Console.WriteLine("[{0}] chose 8 or 13", Player.getName());
                    break;
                case 23:
                    Player.setMove(23);
                    Console.WriteLine("[{0}] chose 9 or 12", Player.getName());
                    break;
                case 24:
                    Player.setMove(24);
                    Console.WriteLine("[{0}] chose 10 or 11", Player.getName());
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }
}
