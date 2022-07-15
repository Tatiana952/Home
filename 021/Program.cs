int[] a = new int[3];
int[] b = new int[3];
int i = 0;

Console.WriteLine("Enter 3 coordinates of the pont A: ");
for (i=0; i<3; i++)
    a[i]=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 3 coordinates of the pont B: ");
for (i=0; i<3; i++)
    b[i]=Convert.ToInt32(Console.ReadLine());

double d1 = 0;
for (i=0; i<3; i++)
d1 = d1 + Math.Pow((a[i]-b[i]),2);

Console.WriteLine();
Console.WriteLine("Distance between points is: "+ "{0:f2}", Math.Sqrt(d1));