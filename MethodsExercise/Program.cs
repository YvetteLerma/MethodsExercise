Console.WriteLine($"What is your name?");
var name = Console.ReadLine();

Console.WriteLine($"What's your favorite color?");
var color = Console.ReadLine();

Console.WriteLine($"What's your favorite animal?");
var animal = Console.ReadLine();

Console.WriteLine($"What is your favorite band?");
var favoriteBand = Console.ReadLine();

{
    Console.WriteLine($"My name is {name}. My favorite color is {color}. I have a favorite animal, yup you guessed it, it is an {animal}. Does {favoriteBand} count as a favorite band?");
}

static int Add(int x, int y)
{
    int sum = x + y;
    return sum;
}
int y = Add(8, 7);
Console.WriteLine($"{y}");

static int Subtract(int b, int a)

{
    int diff = b - a;
    return diff;
}
int a = Subtract(22, 8);
Console.WriteLine($"{a}");

static int Multiply(int x, int y)
{
    int mult = x * y;
return mult;
}
int c = Multiply(11, 2);
Console.WriteLine($"{c}");

static int Divide(int x, int y)
{
    int div = x * y;
    return div;
}
int d = Divide(11, 2);
Console.WriteLine($"{d}");

static int Modulus(int x, int y)
{
    int modul = x * y;
    return modul;
}
int e = Modulus(11, 2);
Console.WriteLine($"{e}");

static int AddParams(params int[] nums)
{
    int sum = 0;
    for (var i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }
    return sum;
}