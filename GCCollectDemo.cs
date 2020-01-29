using System;
/// <summary>
/// class to implement garbage collection manually
/// </summary>
class GaCo1
{
    private const int maxGarbage = 1000;
    /// <summary>
    /// method calling garbage collector and showing total memory before and after its call.
    /// </summary>
    static void Main()
    {
       
        GaCo1.MakeSomeGarbage();
        Console.WriteLine("Memory used before collection:       {0:N0}",
                        GC.GetTotalMemory(false));
        GC.Collect();
        Console.WriteLine("Memory used before collection:       {0:N0}",
                        GC.GetTotalMemory(true));
        Console.ReadKey();
    }
    /// <summary>
    /// method creating objects.
    /// </summary>
    static void MakeSomeGarbage()
    {
        for (int i = 0; i < maxGarbage; i++)
        {
            GaCo1 obj = new GaCo1();
        }
    }
}