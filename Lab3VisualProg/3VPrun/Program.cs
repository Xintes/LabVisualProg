using Lab3VisualProg;


////////// 1
Matrix matrix1 = new Matrix(2, 2);
//matrix1[0, 0] = 1.0;
//matrix1[0, 1] = 2.0;
//matrix1[1, 0] = 3.0;
//matrix1[1, 1] = 4.0;
Matrix matrix2 = new Matrix(2, 2);
matrix2[0, 0] = 1.0;
matrix2[0, 1] = 2.0;
matrix2[1, 0] = 3.0;
matrix2[1, 1] = 4.0;
//---------------------------------

////////// 3
Matrix matCopy = new Matrix(matrix1);
//---------------------------------

////////// 4 
Console.WriteLine($"Задание 4: \n {matrix2[1,1]}");
matrix2[1, 1] = 4.6;
Console.WriteLine($"{matrix2[1, 1]}\n----------------\n");
//---------------------------------

////////// 5
Console.WriteLine($"Задание 5:\n {matrix1.ToString()}\n----------------\n");
//---------------------------------

////////// 6
Console.WriteLine($"Задание 6:\n {matrix2.ToString(3)}\n----------------\n");
//---------------------------------

////////// 7
Console.WriteLine("Задание 7:");
Matrix sum = matrix1 + matrix2;
Console.WriteLine("Результат сложения матриц:");
Console.WriteLine(sum.ToString(4));
Matrix minus = matrix1 - matrix2;
Console.WriteLine("Результат вычитания матриц:");
Console.WriteLine(minus.ToString(4));
Matrix umn = matrix1 * matrix2;
Console.WriteLine("Результат умножения матриц:");
Console.WriteLine(umn.ToString(4) + "\n--------------------\n");
//---------------------------------

////////// 8
Console.WriteLine("Задание 8:");
Matrix matrCopy = (Matrix)matrix1.Clone();
Console.WriteLine(matrCopy.ToString(4) + "\n--------------------");
//---------------------------------

////////// 9
Console.WriteLine("Задание 9:");
Console.WriteLine(matrix1.CompareTo(matrix2));
//---------------------------------

