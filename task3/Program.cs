Console.Clear();
System.Console.WriteLine("Введите день недели в виде числа от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
switch (a){
    case 1:
    System.Console.WriteLine("Не выходной");
    break;
    case 2:
    System.Console.WriteLine("Не выходной");
    break;
    case 3:
    System.Console.WriteLine("Не выходной");
    break;
    case 4:
    System.Console.WriteLine("Не выходной");
    break;
    case 5:
    System.Console.WriteLine("Не выходной");
    break;
    case 6:
    System.Console.WriteLine("Выходной");
    break;
    case 7:
    System.Console.WriteLine("Выходной");
    break;
    default:
    System.Console.WriteLine("Не является днем недели");
    break;
}