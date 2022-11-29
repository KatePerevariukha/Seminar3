Console.Write("Введите 5-и значное число:");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000; //первая цифра
int n2 = (n / 1000 - n1 * 10); // вторая цифра
int n3 = (n / 100 - n1*100 - n2 * 10); //третья цифра
int n4 = (n / 10 - n1 * 1000 - n2 * 100 - n3*10); // четвертая цифра
int n5 = n % 10; // пятая цифра

if (n < 10000 || n > 99999)
    Console.WriteLine("Пожалуйста, введите 5-и значное число:");

else if (n1 == n5 && n2 == n4)
    Console.WriteLine("да");

else 
    Console.WriteLine("нет");