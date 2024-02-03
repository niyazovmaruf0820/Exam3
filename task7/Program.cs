List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
// 1)
System.Console.WriteLine(list.Max());
// 2)
List<int> ints = list.Distinct().ToList();
foreach (var item in ints)
{
    System.Console.Write(item + " ");
}
System.Console.WriteLine();
// 3)
list.Sort();
foreach (var item in list)
{
    System.Console.Write(item + " ");
}
System.Console.WriteLine();
// 4)
for (int i = 0; i < list.Count; i++)
{
    if (list[i] < 0) list[i] = 0;
}
//
foreach (var item in list)
{
    System.Console.Write(item + " ");
}