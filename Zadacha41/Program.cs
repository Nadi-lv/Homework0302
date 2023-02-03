/* void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}
 */

int [] FillArray(int m){
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int Kolichestvo (int[] array){

    int result = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0)  result++;

}
return result;
}

System.Console.WriteLine("Введите количество чисел:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите числа");
int[] array = FillArray(m);
int q = Kolichestvo(array);
Console.WriteLine($"Количество чисел больше нуля : {q}");



