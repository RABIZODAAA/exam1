int a = Convert.ToInt32(Console.ReadLine());

void jamawon(int number)
{
    for(int i = 0; i < number; i++)
    {
        jamawon(number + 1);
    }
   Console.WriteLine(a);
} 
Console.WriteLine(0);