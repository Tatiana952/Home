Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] a = new double[n];

for (int i = 0; i < n; i++)
{
    a[i] = Math.Pow((i+1),3);
    Console.Write(a[i] + " ");
}