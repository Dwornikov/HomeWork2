Console.Clear();
System.Console.WriteLine("Введите трезначное число");
int a = Convert.ToInt32(Console.ReadLine());
a= a/10;
a= a % 10;
System.Console.WriteLine(a);