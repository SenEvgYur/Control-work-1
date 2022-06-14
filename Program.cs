Console.Clear();
Console.WriteLine("Введите массив, используя в качестве разделителя пробел или запятую: ");
string [] massive = Console.ReadLine().Split(' ', ',');
Console.Write("[ ");
for (int i = 0; i < massive.Length; i++)
{
    if(massive[i].Length >=3)
    {
       Console.Write(massive[i] + " ");
    }
}
Console.Write("]");