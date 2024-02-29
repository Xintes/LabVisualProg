namespace Lab3VisualProg
{
    public class Matrix : ICloneable, IComparable<Matrix>
    {
        private readonly double[,] elements;
        public uint Rows { get; }
        public uint Columns { get; }
        public Matrix (uint rows, uint columns){
            Rows = rows;
            Columns = columns;
            elements = new double[rows, columns];
            for (uint i = 0; i < rows; i++)
            {
                for (uint j = 0; j < columns; j++)
                {
                    elements[i, j] = 0.0;
                }
            }
        }
        public Matrix(Matrix original){
            Rows = original.Rows;
            Columns = original.Columns;
            elements = original.elements;
        }
        public double this[uint row, uint column]
        {
            get
            {
                if (row < Rows && column < Columns)
                {
                    return elements[row, column];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();//////
                }
            }
            set
            {
                if (row < Rows && column < Columns)
                {
                    elements[row, column] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
                   
        }

        public override string ToString()
        {
            uint count = Rows * Columns;
            return $"Строк:{Rows}, Стобцов:{Columns}, Элементов:{count}" ;
        }

        public string ToString(uint n)
        {
            string result = "";
            uint count = n;

            for (uint row = 0; row < Rows; row++)
            {
                for (uint col = 0; col < Columns; col++)
                {
                    result += elements[row, col] + " ";
                    count--;

                    if (count == 0)
                    {
                        return result;
                    }
                }
            }
            return result;
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns)
            {
                throw new ArgumentException("Матрицы должны быть одинакового размера для операции сложения.");
            }

            Matrix result = new Matrix(left.Rows, left.Columns);

            for (uint row = 0; row < left.Rows; row++)
            {
                for (uint col = 0; col < left.Columns; col++)
                {
                    result[row, col] = left[row, col] + right[row, col];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns)
            {
                throw new ArgumentException("Матрицы должны быть одинакового размера для операции вычитания.");
            }

            Matrix result = new Matrix(left.Rows, left.Columns);

            for (uint row = 0; row < left.Rows; row++)
            {
                for (uint col = 0; col < left.Columns; col++)
                {
                    result[row, col] = left[row, col] - right[row, col];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.Columns != right.Rows)
            {
                throw new ArgumentException("Число столбцов левой матрицы должно быть равно числу строк правой матрицы для операции умножения.");
            }

            Matrix result = new Matrix(left.Rows, right.Columns);

            for (uint row = 0; row < left.Rows; row++)
            {
                for (uint col = 0; col < right.Columns; col++)
                {
                    for (uint k = 0; k < left.Columns; k++)
                    {
                        result[row, col] += left[row, k] * right[k, col];
                    }
                }
            }
            return result;
        }
        public object Clone()
        {
            return new Matrix(this);
        }
        public int CompareTo(Matrix other)
        {
            if (Rows != other.Rows || Columns != other.Columns)
            {
                throw new ArgumentException("Матрицы должны быть одинакового размера для сравнения.");
            }

            for (uint row = 0; row < Rows; row++)
            {
                for (uint col = 0; col < Columns; col++)
                {
                    if (this[row, col] < other[row, col])
                        return -1;
                    if (this[row, col] > other[row, col])
                        return 1;
                }
            }
            return 0;
        }
    }
}
