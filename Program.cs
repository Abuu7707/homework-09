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
Sum(a);
