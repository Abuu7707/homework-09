/*Task 1
int Sum(int number)
{
    if (number > 1)
    {
        Sum(number - 1);
    }
    System.Console.Write(number + " ");
    return 0;
}
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(Sum(a));*/

/*Task 2
int Sum(int number)
{
    System.Console.Write(number + " ");
    if (number > 1)
    {
        Sum(number - 1);
    }
    return 0;
}
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(Sum(a));*/

/*Task 4
int Sum(int number)
{
    if (number <= 1)
    {
        return 1;
    }
    else
    {
        return number + Sum(number - 1);
    }
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(a));*/
