using System;
using System.Collections.Generic;

class Program1
{
    static List<List<int>> g = new List<List<int>>();
    static bool[] vis;

    static void DFS(int vertex)
    {
        Console.WriteLine(vertex);

        vis[vertex] = true;

        foreach (int child in g[vertex])//2,3
        {
            Console.WriteLine($"parent {vertex}, child {child}");
            if (!vis[child])
            {
                DFS(child);
            }
        }
    }

    static void Main()
    {
        const int N = 100010; // 1e5 + 10
        vis = new bool[N];

        int n, m;
        string[] input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        m = int.Parse(input[1]);

        for (int i = 0; i <= n; i++)
        {
            g.Add(new List<int>());
            vis[i] = false;
        }

        for (int i = 0; i < m; i++)
        {
            input = Console.ReadLine().Split();
            int v1 = int.Parse(input[0]);
            int v2 = int.Parse(input[1]);

            g[v1].Add(v2);
            g[v2].Add(v1);
        }

        DFS(1);
    }
}

