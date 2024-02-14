Console.WriteLine("Enter a number: ");
var r = long.TryParse(Console.ReadLine(), out var t) && t.ToString().Length == 11;
var i = new int[t.ToString().Length];
var a = 0;
var b = 0;
for (var j = i.Length - 1; j >= 0; j--)
{
    i.SetValue((int)(t % 10), j);
    a += j % 2 == 0 && j < 10 ? (int)(t % 10) : 0;
    b += (j + 1) % 2 == 0 && j < 8 ? (int)(t % 10) : 0;
    t /= 10;
}

Console.WriteLine(r);
Console.ReadLine();
