// Задача 5: * 
// Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int MaxRow (int[] array) {
    int max = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        }
    } return max;
}

int[] MinColumn (int[] array1, int[] array2) {
    int[] arrayMin = new int[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        arrayMin[i] = array1[i];
        if (array1[i] > array2[i]) {
            arrayMin[i] = array2[i];
        }
    } return arrayMin;
} 

int SumMinColumn(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    } return sum;
}

int[] array1 = new int[] {1, 2, 3};
int[] array2 = new int[] {3, 4, 5};
int sumMaxRow = MaxRow(array1) + MaxRow(array2);
System.Console.WriteLine($"Sum of maximum numbers of row: {sumMaxRow}");

int[] arrayMinCol = MinColumn(array1, array2);
int sumMinColumn = SumMinColumn(arrayMinCol);
System.Console.WriteLine($"Sum of minimum numbers of column: {sumMinColumn}");

System.Console.WriteLine($"The difference is: {sumMaxRow - sumMinColumn}");
