using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Versioning;

public class Pract1 {
    public void run() {
        Console.WriteLine("Hello World Pract1");
        num1();
        num2();
        num3();
        num4();
        num5();
        num6();
        num7();
        num8();
        num9();
        num10();
        num11();
        num12();
        num13();
        num14();
        Console.WriteLine("Конец Hello World Pract1");
    }
    
    private void num1() {
        Console.WriteLine("num1:");
        int[] ints = { -2, 1, 4, 5, -5, 6, -1 };
        Console.WriteLine(ints.First(n => n > 0));
        Console.WriteLine(ints.Last(n => n < 0));
        Console.WriteLine("Конец num1\n");
    }
    
    private void num2() {
        Console.WriteLine("num2:");
        int D = 7;
        int[] A = { -204, 178, 4345, 5435, -565, 676, -189 };
        Console.WriteLine(A.FirstOrDefault(n => n > 0 && n.ToString().EndsWith(D.ToString())));
        Console.WriteLine("Конец num2\n");
    }
    
    private void num3() {
        Console.WriteLine("num3:");
        int L = 4, x = 0;
        string[] A = { "AXS1", "2TER", "B2GF", "LK3IK1" };
        Console.WriteLine(A.LastOrDefault(n => n.Length == L && int.TryParse(n.Substring(0, 1), out x)) ?? "Not Found");
        Console.WriteLine("Конец num3\n");
    }
    
    private void num4() {
        Console.WriteLine("num4:");
        char C = '1';
        string[] A = { "AXS1", "2TER", "B2GF", "LK3IK1" };
        var rez = A.Where(n => n.EndsWith(C)).DefaultIfEmpty("");
        Console.WriteLine(rez.Count() > 1 ? "Error" : rez.ElementAt(0));
        Console.WriteLine("Конец num4\n");
    }
    
    private void num5() {
        Console.WriteLine("num5:");
        char C = '1';
        string[] A = { "AXS1", "2TER", "B2GF", "LK3IK1", "1K3IK1", "1K4IK1" };
        Console.WriteLine(A.Count(n => n.Length > 1 && n.StartsWith(C) && n.EndsWith(C)));
        Console.WriteLine("Конец num5\n");
    }
    
    private void num6() {
        Console.WriteLine("num6:");
        int[] A = { 0, 1, 22, 44, -56, 4 };
        var rez = A.Where(n => n > 9 && n < 100);
        int rezC = rez.Count();
        Console.WriteLine(rezC);
        Console.WriteLine(rezC > 1 ? rez.Average() : 0.0);
        Console.WriteLine("Конец num6\n");
    }
    
    private void num7() {
        Console.WriteLine("num7:");
        int L = 5;
        string[] A = { "AXS", "TER", "BGF", "AAA", "XXX", "LKIK", "AKIK" };
        Console.WriteLine(A.Where(n => n.Length == L).OrderBy(n => n).LastOrDefault() ?? "");
        Console.WriteLine("Конец num7\n");
    }
    
    private void num8() {
        Console.WriteLine("num8:");
        string[] A = { "AXS", "TER", "BGF", "AAA", "XXX", "LKIK", "AKIK" };
        Console.WriteLine(A.Sum(n => n.Length));
        Console.WriteLine("Конец num8\n");
    }
    
    private void num9() {
        Console.WriteLine("num9:");
        int D = 7;
        // bool b = false;
        int[] A = { -204, 3, 8, 7, 178, 4345, 5435, -565, 676, -189 };
        var rez = A.SkipWhile(n => n <= D);
        // var rez = A.Where(n => (n > D || b) && (b = true));
        foreach (var n in rez.Where(n => n > 0 && n % 2 != 0).Reverse())
            Console.WriteLine(n);
        Console.WriteLine("Конец num9\n");
    }
    
    private void num10() {
        Console.WriteLine("num10:");
        int K = 5;
        string[] A = { "aXs", "AXs", "AXS", "TER", "BGF", "AAA", "XXX", "LKIK", "AKIK" };
        foreach (var el in A.Take(K).Where(n => n.Length % 2 != 0 && n[0] >= 'A' && n[0] <= 'Z').Reverse())
            Console.WriteLine(el);
        Console.WriteLine("Конец num10\n");
    }
    
    private void num11() {
        Console.WriteLine("num11:");
        int K = 5, D = 6, L = K - 1;
        int[] A = { -204, 3, 8, 7, 178, 4345, 5435, -565, 676, -189 };
        foreach (var el in A.TakeWhile(n => n < D).Union(A.Where((n, i) => i > L)).OrderByDescending(n => n))
            Console.WriteLine(el);
        Console.WriteLine("Конец num11\n");
    }
    
    private void num12() {
        Console.WriteLine("num12:");
        int K = 5;
        int[] A = { -204, 3, 8, 7, 178, 4345, 5435, -565, 676, -189 };
        foreach (var el in A.Where(n => n % 2 == 0).Except(A.Where((n, i) => i > K)).Distinct().Reverse())
            Console.WriteLine(el);
        Console.WriteLine("Конец num12\n");
    }
    
    private void num13() {
        Console.WriteLine("num13:");
        int K = 5;
        string[] A = { "AXS1", "2TER", "B2GF", "LK3IK1", "1K3IK1", "1K4IK1", "B3GF", "B4GF" };
        var Ai = A.Select((s,i) => new { s, i }).DefaultIfEmpty(new { s = "", i = 0 });
        foreach (var el in A.Take(K).Except(A.Skip(Ai.Last(n => char.IsDigit(n.s[n.s.Length-1])).i + 1))
            .OrderBy(n => n.Length).ThenBy(n => n))
            Console.WriteLine(el);
        Console.WriteLine("Конец num13\n");
    }
    
    private void num14() {
        Console.WriteLine("num14:");
        string[] A = { "aXs", "AXs", "AXS", "", "TER", "BGF", "AAA", "XXX", "", "LKIK", "AKIK" };
        foreach (var el in A.Select((n, i) => n+i).Where((n, i) => !char.IsDigit(n[0])).OrderBy(n => n))
            Console.WriteLine(el);
        Console.WriteLine("Конец num14\n");
    }
}
