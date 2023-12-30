List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, 100, 24, 45, 6, -1};
System.Console.WriteLine(list.Max());
for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (list[i] == list[j])
        {
            list.Remove(list[i]);
        }
    }
}
foreach (var item in list)
{
    System.Console.Write(item + " ");
}
System.Console.WriteLine();
list.Sort();
for (int i = 0; i < list.Count; i++)
{
    if (list[i] < 0)
    {
       list[i] = 0;
    }
}
foreach (var item in list)
{
    System.Console.Write(item + " ");
}