Console.Clear();
System.Console.WriteLine("Введите трезначное число");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 1000 && a > 99){
a= a/10;
a= a % 10;
System.Console.WriteLine(a);
}
else{
    System.Console.WriteLine("Не является трехзначным числом");
}