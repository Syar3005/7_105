Random rnd = new Random();

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

int[] c = new int[n];

for (int i = 0; i < n; i++)
{
    c[i] = rnd.Next(50);

	if (c[i] < 20)
	{
		count++;
	}
}
Console.WriteLine($"{count} элементов массива, меньших 20");
if(count == 5)
{
	Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}