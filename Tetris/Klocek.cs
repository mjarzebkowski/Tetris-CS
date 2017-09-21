using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris
{
    class Klocek
    {
        public int[][] KlocekMiejsce;
        public int Ksztalt { get; set; }
        public int Pozycja { get; set; }
        public Point CurrPoint;

        public Klocek()
        {
            this.CurrPoint.X = 3;
            this.CurrPoint.Y = 0;
            Ksztalt = (new Random(Seed: 3636).Next() % 7) + 1;
            Pozycja = (new Random(Seed: 568).Next() % 4) + 1;

            switch (Ksztalt)
            {
                case 1:
                    L_N(Pozycja);
                    break;
                case 2:
                    L2_N(Pozycja);
                    break;
                case 3:
                    T_N(Pozycja);
                    break;
                case 4:
                    I_N(Pozycja);
                    break;
                case 5:
                    S_N(Pozycja);
                    break;
                case 6:
                    S2_N(Pozycja);
                    break;
                case 7:
                    K_4();
                    break;


            }

        }

        public static void Obrot_L(byte ksztalt, byte pozycja)
        {
            if (pozycja >= 3)
            {
                pozycja = 0;
            }
                else
            {
                pozycja++;
            }
            
        }

        public static void Obrot_P(byte ksztalt, byte pozycja)
        {
            if (pozycja <= 0)
            {
                pozycja = 3;
            }
            else
            {
                pozycja--;
            }
        }

        void zeruj()
        {
            for (int i = 0; i == 4; i++)
            {
                for (int j = 0; j == 4; j++)
                {
                    this.KlocekMiejsce[i][j] = 0;
                }
            }
            
        }

        // L
        void L_N(int N)
        {
            switch (N)
            {
                case 0:
                    L_1();
                    break;
                case 1:
                    L_2();
                    break;
                case 2:
                    L_3();
                    break;
                case 3:
                    L_4();
                    break;
                default:
                    L_1();
                    break;

            }
        }
        //[ ][ ][x][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][ ][x][ ]          [ ][ ][ ][ ]          [ ][x][x][ ]          [ ][x][ ][ ]
        //[ ][x][x][ ]          [x][x][x][ ]          [ ][x][ ][ ]          [ ][x][x][x]
        //[ ][ ][ ][ ]          [ ][ ][x][ ]          [ ][x][ ][ ]          [ ][ ][ ][ ]

        void L_1()
        {
            this.Pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }

        void L_2()
        {
            this.Pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }

        void L_3()
        {
            this.Pozycja = 3;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }

        void L_4()
        {
            this.Pozycja = 4;
            this.zeruj();
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
            this.KlocekMiejsce[0][0] = 1;
        }



        //odwrócone L

        void L2_N(int N)
        {
            switch (N)
            {
                case 0:
                    L2_1();
                    break;
                case 1:
                    L2_2();
                    break;
                case 2:
                    L2_3();
                    break;
                case 3:
                    L2_4();
                    break;
                default:
                    L2_1();
                    break;

            }
        }

        //[ ][x][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][ ][ ]          [ ][ ][ ][x]          [ ][x][x][ ]          [ ][x][x][x]
        //[ ][x][x][ ]          [ ][x][x][x]          [ ][ ][x][ ]          [ ][x][ ][ ]
        //[ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][x][ ]          [ ][ ][ ][ ]

        void L2_1()
        {
            this.Pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[0][1] = 2;
            this.KlocekMiejsce[1][1] = 2;
            this.KlocekMiejsce[2][1] = 2;
            this.KlocekMiejsce[2][2] = 2;
        }

        void L2_2()
        {
            this.Pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][3] = 2;
            this.KlocekMiejsce[2][1] = 2;
            this.KlocekMiejsce[2][2] = 2;
            this.KlocekMiejsce[2][3] = 2;
        }

        void L2_3()
        {
            this.Pozycja = 3;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 2;
            this.KlocekMiejsce[1][2] = 2;
            this.KlocekMiejsce[2][2] = 2;
            this.KlocekMiejsce[3][2] = 2;
        }

        void L2_4()
        {
            this.Pozycja = 4;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 2;
            this.KlocekMiejsce[1][2] = 2;
            this.KlocekMiejsce[1][3] = 2;
            this.KlocekMiejsce[2][1] = 2;
        }

        // T

        void T_N(int N)
        {
            switch (N)
            {
                case 0:
                    T_1();
                    break;
                case 1:
                    T_2();
                    break;
                case 2:
                    T_3();
                    break;
                case 3:
                    T_4();
                    break;
                default:
                    T_1();
                    break;

            }
        }

        //[ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][x][x]          [ ][x][ ][ ]          [ ][ ][x][ ]          [ ][ ][x][ ]
        //[ ][ ][x][ ]          [ ][x][x][ ]          [ ][x][x][x]          [ ][x][x][ ]
        //[ ][ ][ ][ ]          [ ][x][ ][ ]          [ ][ ][ ][ ]          [ ][ ][x][ ]

        void T_1()
        {
            this.Pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 3;
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[1][3] = 3;
        }

        void T_2()
        {
            this.Pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 3;
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[1][3] = 3;
        }

        void T_3()
        {
            this.Pozycja = 3;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][1] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[2][3] = 3;
        }

        void T_4()
        {
            this.Pozycja = 4;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 3;
            this.KlocekMiejsce[2][1] = 3;
            this.KlocekMiejsce[2][2] = 3;
            this.KlocekMiejsce[3][2] = 3;
        }

        // ----

        void I_N(int N)
        {
            switch (N)
            {
                case 0:
                    I_1();
                    break;
                case 1:
                    I_2();
                    break;
                case 2:
                    I_1();
                    break;
                case 3:
                    I_2();
                    break;
                default:
                    I_1();
                    break;

            }
        }

        //[ ][x][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][ ][ ]          [x][x][x][x]
        //[ ][x][ ][ ]          [ ][ ][ ][ ]

        void I_1()
        {
            this.Pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][0] = 4;
            this.KlocekMiejsce[1][1] = 4;
            this.KlocekMiejsce[1][2] = 4;
            this.KlocekMiejsce[1][3] = 4;
        }

        void I_2()
        {
            this.Pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[3][0] = 4;
            this.KlocekMiejsce[3][1] = 4;
            this.KlocekMiejsce[3][2] = 4;
            this.KlocekMiejsce[3][3] = 4;
        }


        // S

        void S_N(int N)
        {
            switch (N)
            {
                case 0:
                    S_1();
                    break;
                case 1:
                    S_2();
                    break;
                case 2:
                    S_1();
                    break;
                case 3:
                    S_1();
                    break;
                default:
                    S_1();
                    break;

            }
        }

        //[ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][ ][x][x]          [ ][x][ ][ ]
        //[ ][x][x][ ]          [ ][x][x][ ]
        //[ ][ ][ ][ ]          [ ][ ][x][ ]

        void S_1()
        {
            this.Pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 5;
            this.KlocekMiejsce[1][3] = 5;
            this.KlocekMiejsce[2][1] = 5;
            this.KlocekMiejsce[2][2] = 5;
        }

        void S_2()
        {
            this.Pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 5;
            this.KlocekMiejsce[2][1] = 5;
            this.KlocekMiejsce[2][2] = 5;
            this.KlocekMiejsce[3][2] = 5;
        }

        // odwrócone S

        void S2_N(int N)
        {
            switch (N)
            {
                case 0:
                    S2_1();
                    break;
                case 1:
                    S2_2();
                    break;
                case 2:
                    S2_1();
                    break;
                case 3:
                    S2_1();
                    break;
                default:
                    S2_1();
                    break;

            }
        }

        //[ ][ ][ ][ ]          [ ][ ][ ][ ]
        //[ ][x][x][ ]          [ ][ ][x][ ]
        //[ ][ ][x][x]          [ ][x][x][ ]
        //[ ][ ][ ][ ]          [ ][x][ ][ ]

        void S2_1()
        {
            this.Pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 6;
            this.KlocekMiejsce[1][2] = 6;
            this.KlocekMiejsce[2][2] = 6;
            this.KlocekMiejsce[2][3] = 6;
        }

        void S2_2()
        {
            this.Pozycja = 2;
            this.zeruj();
            this.KlocekMiejsce[1][2] = 6;
            this.KlocekMiejsce[2][1] = 6;
            this.KlocekMiejsce[2][2] = 6;
            this.KlocekMiejsce[3][1] = 6;
        }

        // Kwadrat

        //[ ][ ][ ][ ]
        //[ ][x][x][ ]
        //[ ][x][x][ ]
        //[ ][ ][ ][ ]

        void K_4()
        {
            this.Pozycja = 1;
            this.zeruj();
            this.KlocekMiejsce[1][1] = 7;
            this.KlocekMiejsce[1][2] = 7;
            this.KlocekMiejsce[2][1] = 7;
            this.KlocekMiejsce[2][2] = 7;
        }

    }
}
