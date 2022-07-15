Console.WriteLine("Enter size of array: ");
int[] a = new int[Convert.ToInt32(Console.ReadLine())];

int i = 0;

 Console.WriteLine("Enter the contents of the array: ");
for (i = 0; i < a.Length; i++)
    a[i] = Convert.ToInt32(Console.ReadLine());

int max1 = a[0];
int max2 = a[0];
for (i = 0; i < a.Length; i++)
{
    if (a[i] > max1)
    {
    max2 = max1;
    max1 = a[i];
    }
    else if (a[i]>max2)
    max2 = a[i];
    if (a[i] == 0)
    break;
}

Console.WriteLine();
Console.WriteLine("Second max = " + max2);