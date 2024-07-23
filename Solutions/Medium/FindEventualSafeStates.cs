namespace Solutions;

/// <summary>
/// There is a directed graph of n nodes with each node labeled from 0 to n - 1.
/// The graph is represented by a 0-indexed 2D integer array graph where graph[i] is an integer array of nodes adjacent to node i, meaning there is an edge from node i to each node in graph[i].
/// A node is a terminal node if there are no outgoing edges. A node is a safe node if every possible path starting from that node leads to a terminal node (or another safe node).
/// Return an array containing all the safe nodes of the graph. The answer should be sorted in ascending order.
/// </summary>
public class FindEventualSafeStates
{
    /// <summary>
    /// 1- null
    /// 2- Empty
    /// 3- Only 1
    /// 4- All Terminal
    /// 5- 
    /// </summary>
    /// <param name="graph"></param>
    /// <returns></returns>
    public IList<int> EventualSafeNodes(int[][] graph)
    {

        EventualSafeNodes2(graph);
        var result = new List<int>();
        
        var additionalActions = new List<int>();
        
        // Identify terminal nodes. How? Empty ones.
        var terminalIndexes = graph.Select((p, i) => new { Item = p, Index = i })
            .Where(p => p.Item.Length == 0)
            .Select(p => p.Index).ToList();

        for (int i = 0; i < graph.Length; i++)
        {
            if (graph[i].Any(x => !terminalIndexes.Contains(x)))
            {
                additionalActions.Add(i);
                continue;
            }
            result.Add(i);
        }

        // [[],[0,2,3,4],[3],[4],[]]
        for (int i = 0; i < additionalActions.Count; i++)
        {
            FindAdditionalIndexes(terminalIndexes, new List<int>(), graph[additionalActions[i]], graph);
        }

        return result.Order().ToList();
    }

    // [[1,2],[2,3],[5],[0],[5],[],[]]
    // 0,1,3
    public void FindAdditionalIndexes(List<int> terminalIndexes, List<int> knownPathToTerminalIndex, int[] partialGraph,
        int[][] fullGraph)
    {
        for (int i = 0; i < partialGraph.Length; i++)
        {
            if (partialGraph.Length == 1 && terminalIndexes.Contains(partialGraph[i]))
            {
                // terminalIndexes.Add();
            }
            
            if (terminalIndexes.Contains(partialGraph[i]))
            {
                knownPathToTerminalIndex.Add(partialGraph[i]);
                FindAdditionalIndexes(terminalIndexes, knownPathToTerminalIndex, fullGraph[partialGraph[i]], fullGraph);
            }
            else
            {
                knownPathToTerminalIndex.Clear();
                
            }
        }
    }
    
    public static bool Dfs(int[][] fullGraph, List<int> visit, List<int> path, int sr)
    {
        visit[sr] = 1;
        path[sr] = 1;
        foreach(int i in fullGraph[sr])
        {
            if (visit[i] == 0) {
                if (Dfs(fullGraph, visit, path, i))
                    return true;
            }
            else if (path[i] == 1)
                return true;
        }
        path[sr] = 0;
        return false;
    }
 
    public static List<int> EventualSafeNodes2(int[][] fullGraph)
    {
        var visit = new List<int>(new int[fullGraph.Length]);
        var path = new List<int>(new int[fullGraph.Length]);
        
        for (var i = 0; i < fullGraph.Length; i++) {
            if (visit[i] == 0)
                Dfs(fullGraph, visit, path, i);
        }
        
        var res = new List<int>();
        for (var i = 0; i < fullGraph.Length; i++) {
            if (visit[i] == 1 && path[i] == 0)
                res.Add(i);
        }
        return res;
    }
}