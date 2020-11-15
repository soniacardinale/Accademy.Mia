using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tris
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_Tris();
        }
        private static void Test_Tris()
        {
            int[,] Tris = new int[3, 3];
            initTris(Tris);

            bool ThereIsaWinner = false;
            bool NoMoreMoves = false;
            bool A_isWinner = false;
            bool B_isWinner = false;

            while (!ThereIsaWinner && !NoMoreMoves)
            {
                Move(1, Tris); //A è il mio 1, B è il mio 2
                A_isWinner = IsWinner(1, Tris);
                if (A_isWinner)
                {
                    ThereIsaWinner = true;
                }
                else
                {
                    if (!ThereAreMoves(Tris))
                    {
                        NoMoreMoves = true;
                    }
                    else
                    {
                        Move(2, Tris);
                        B_isWinner = IsWinner(2, Tris);
                        if (B_isWinner)
                        {
                            ThereIsaWinner = true;
                        }
                        else
                        {
                            if (!ThereAreMoves(Tris))
                                NoMoreMoves = true;
                        }
                    }
                }
            }

            /*Per muovere: pesco e poi calcolo i numeri modulo 9, ciclando se la casella pescata è vuota,
            Altrimenti pesco ogni volta tra un numero minore di elementi e occupo la k-esima casella vuota.
             */
            /*ThereAreMoves basta inizializzare a 0 tutto e controllare se ci sono degli zeri...*/
            /* IsWinner facciamo 3 funzioni che controllino righe, colonne e diagonali, e ogni volta che dobbiamo controllare
             * se x ha vinto, vedere dove stanno i suoi simboli e controllare solo per quelli... faremo al più 27 controlli quindi okay... */
            PrintTris(Tris);
            System.Console.WriteLine("'A is Winner' is {0}; 'B is Winner' is {1}", A_isWinner.ToString(), B_isWinner.ToString());
            Console.ReadLine();
        }
    

        private static bool IsWinner(int v, int[,] matrix)
        {
            bool result = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == v)
                    {
                        result = RowControl(v, i, matrix);
                        if (result == true) break;
                        result = ColumnControl(v, j, matrix);
                        if (result == true) break;
                        if ((i + j) % 2 == 0) result = DiagonalControl(v, i, j, matrix);
                        if (result == true) break;
                    }
                }
                if (result == true) break;
            }

            return result;
        }

        private static bool DiagonalControl(int v, int i, int j, int[,] matrix)
        {
            bool diagonal = false;
            bool antidiagonal = false;
            if (i == j)
            {
                diagonal = true;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, k] == v) diagonal = diagonal && true;
                    else diagonal = diagonal && false;
                }
            }
            if (i + j == 2)
            {
                antidiagonal = true;
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    if (matrix[k, matrix.GetLength(0) - 1 - k] == v) antidiagonal = antidiagonal && true;
                    else antidiagonal = antidiagonal && false;
                }
            }

            return (diagonal || antidiagonal);
        }

        private static bool ColumnControl(int v, int j, int[,] matrix)
        {
            bool isEqual = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] == v) isEqual = isEqual && true;
                else isEqual = isEqual && false;
            }
            return isEqual;
        }

        private static bool RowControl(int v, int i, int[,] matrix)
        { //restituisce true se v è vincitore lungo la riga i

            bool isEqual = true;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == v) isEqual = isEqual && true;
                else isEqual = isEqual && false;
            }
            return isEqual;
        }

        private static bool ThereAreMoves(int[,] matrix)
        {
            bool result = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        result = true;
                        break;
                    }
                }
                if (result == true) break;
            }
            return result;
        }

        private static void Move(int v, int[,] matrix)
        {
            int position = Academy.Helper.RandomHelper.GetRandomInt(0, 9);
            while (!isAvailable(position, matrix))
            {
                position = (position + 1) % 9;
            }
            matrix[position / 3, position % 3] = v;
        }

        private static bool isAvailable(int position, int[,] matrix)
        {
            bool result = false;
            if (matrix[position / 3, position % 3] == 0) result = true;
            return result;
        }

        private static void PrintTris(int[,] matrix)
        {
            char[,] temp = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0) temp[i, j] = ' ';
                    if (matrix[i, j] == 1) temp[i, j] = 'X';
                    if (matrix[i, j] == 2) temp[i, j] = 'O';
                }
            }
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[0, 0], temp[0, 1], temp[0, 2]);
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[1, 0], temp[1, 1], temp[1, 2]);
            System.Console.WriteLine("{0}\t{1}\t{2}", temp[2, 0], temp[2, 1], temp[2, 2]);

        }

        private static void initTris(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

    }
}
