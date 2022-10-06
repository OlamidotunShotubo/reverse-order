Console.WriteLine("Enter the string : ");
string input = "";
string reverse = "";
input = Console.ReadLine();
for (int i = input.Length - 1; i >= 0; i--)
{
    reverse += input[i];
}
Console.WriteLine($"The reverse string is {reverse}");
Console.ReadLine();
Console.Read();
