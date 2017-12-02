heap
---
```
using C5;
var heap = new IntervalHeap<int>();
```

hash code
---

```
class Foo
{
    public int X;
    public int Y;
    public int Z;

    public override int GetHashCode()
    {
        return Tuple.Create(X, Y, Z).GetHashCode();
    }
};
```

permutations
---
```
var p = Utility.GetPermutations(new int[] { 1, 2, 3 }).ToArray();
```

dijkstra
---

https://stackoverflow.com/questions/703871/quickgraph-dijkstra-example

```
using QuickGraph;
using QuickGraph.Algorithms;

var graph = new AdjacencyGraph<int, Edge<int>>();
graph.AddVertex(1);
graph.AddVertex(2);
graph.AddVertex(3);
graph.AddVertex(4);
graph.AddEdge(new Edge<int>(1, 2));
graph.AddEdge(new Edge<int>(2, 3));
graph.AddEdge(new Edge<int>(3, 4));

Func<Edge<int>, double> edgeCost = e => 1; // constant cost

int root = 1;

// compute shortest paths
var tryGetPaths = graph.ShortestPathsDijkstra(edgeCost, root);

// query path for given vertices
int target = 4;
IEnumerable<Edge<int>> path;
if (tryGetPaths(target, out path))
    foreach (var edge in path)
        Console.WriteLine(edge);
```
