//int number = Convert.ToInt32 (Console.ReadLine());
//int reminder = 0;


//while (number >0)
//{
//    reminder += number % 10;

//    number= number / 10;

//}
//if (reminder%2== 0)
//{
//    Console.WriteLine("cutdur");
//}
//else
//{
//    Console.WriteLine("tekdir");
//}









//int number = 100;
//int sum = 0;
//int i = 0;

//for (i = 0; i <= number; i++)
//{
//    if (i % 13 == 0)
//    {
//        Console.WriteLine(i);
//        sum += i;

//    }
//}

//Console.WriteLine(sum);













int number = Convert.ToInt32(Console.ReadLine());
int min = 9;
int k = 0;


while(number > 0)
{
    k = number % 10;
    if(k<min)
    {
        min=k;
    }
    number /= 10;   
}

Console.WriteLine(min);


