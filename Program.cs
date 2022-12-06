// See https://aka.ms/new-console-template for more information
int a = 22;
int b = 3;
int c = 9;
int max = a;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if(b > c)
{
    max = b;
}
else
{
    max = c;
}
Console.WriteLine(max);
