using ПР_3;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

char c = char.Parse(Console.ReadLine());

switch (c)
{
    case '+':
        Console.WriteLine(new Pl().calca(a,  b));
        break;
    case '-':
        Console.WriteLine(new Mi().calca(a, b));
        break;
    case '*':
        Console.WriteLine(new Um().calca(a, b));
        break;
    case '/':
        Console.WriteLine(new De().calca(a, b));
        break;

    default: Console.WriteLine("Errrorrr");
        break;
}