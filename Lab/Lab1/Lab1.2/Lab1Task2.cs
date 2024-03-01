namespace Lab1Task2program
{
    public class Lab1Task2
    {
        public static int Positive(int[,] mass)
        {
            int positive = 0;
            for (int i = 0; i < mass.GetLength(0); i++) { 
                for (int j = 0; j < mass.GetLength(1); j++){
                    if (mass[i, j] > 0 ){
                        positive++;
                    }
                }
            }
            return positive;
        }

        public static int Negative(int[,] mass)
        {
            int negative = 0;
            for (int i = 0; i < mass.GetLength(0); i++){
                for (int j = 0; j < mass.GetLength(1); j++) {
                    if (mass[i, j] < 0){
                        negative++;
                    }
                }
            }
            return negative;
        }

        public static string Coordinate(int[,] mass)
        {
            string coord = "";
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i, j] == 0)
                    {
                        coord = coord.Insert(coord.Length, "["+i+"]"+"["+j+"];");
                    }
                }
            }
            return coord;
        }


    }
}
