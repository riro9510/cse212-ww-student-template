using System;
using System.Collections.Generic;
using System.Linq;public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
    List<int> results = new();
    int index1 = 0;
    int index2 = 0;

    foreach (int s in select)
    {
        if (s == 1)
        {
            results.Add(list1[index1++]);
        }
        else if (s == 2)
        {
            results.Add(list2[index2++]);
        }
    }

    return results.ToArray();
    }
}