Console.WriteLine("Enter a five digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 99999 || n < 10000)
{
    Console.WriteLine("Enter a five digit number: ");
    n = Convert.ToInt32(Console.ReadLine());
}
string n1 = Convert.ToString(n);

if (n1[0] == n1[4] && n1[1] == n1[3])
    Console.WriteLine("It's a palindrome");
else
    Console.WriteLine("It's not a palindrome");