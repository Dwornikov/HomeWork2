Console.Clear();
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
while(number>999){
    number=number/10;
}
if(number<100){
    System.Console.WriteLine("У числа нет третей цифры");
}
else{
    number=number%10;
    System.Console.WriteLine($"Третья цифра {number}");
}
