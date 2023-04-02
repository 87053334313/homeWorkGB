/* //задача 19
Console.WriteLine("Введите пятизначное число:");
int value = int.Parse(Console.ReadLine());
int[] array = new int[5];
array[0] = value/10000;

array[1] = (value/1000)%10;

array[2] = (value/100)%10;

array[3] = (value/10)%10;

array[4] = value%10;

Console.WriteLine(Polindrope(array));


string Polindrope(int[] x)
{
    if(x[0] ==x[4] && x[1] ==x[3])
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}
*/

/*
// Задача 21

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());


double rez;
rez = Formula(x1,y1,z1,x2,y2,z2);
Console.WriteLine(rez);


double Formula (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double rez1 =Math.Pow(x2-x1,2);
    double rez2 =Math.Pow(y2-y1,2);
    double rez3 =Math.Pow(z2-z1,2);
    double rez = Math.Sqrt(rez1+rez2+rez3);
    return rez;
}
*/
//задача 23
Console.WriteLine("введите число N:");
int n = int.Parse(Console.ReadLine());
int[] arr;
arr = Formula(n);

for(int i =0;i<n;i++)
{
    Console.Write(arr[i] + " ");
}

int[] Formula(int n)
{
    int[] array = new  int[n];
    int j =1;
    for(int i= 0;i<n;i++)
    {
        array[i] = (int)Math.Pow(j,3);
        j++;
    }
    return array;
}