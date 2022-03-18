using System;
using System.Collections.Generic;

namespace Task3Sharp
{
    public class Graph
    {
        private int _v;
        private List<List<int>> _nodes;

        public Graph(int v)
        {
            _v = v;
            _nodes = new List<List<int>>();

            for (int i = 0; i < v; ++i)
                _nodes.Add(new List<int>());
        }

        public void AddEdge(int v, int w)
        {
            _nodes[v].Add(w);
            _nodes[w].Add(v);
        }

        private void DFSUtil(int node, List<bool> visited, List<int> orderList)
        {
            visited[node] = true;
            orderList.Add(node);

            List<int> nodeList = _nodes[node];
            foreach (var v in nodeList)
            {
                if (!visited[v])
                    DFSUtil(v, visited, orderList);
            }
        }

        public List<int> DFS(int v)
        {
            var visited = new List<bool>();
            for (int i = 0; i < _v; i++)
            {
                visited.Add(false);
            }

            var orderList = new List<int>();
            DFSUtil(v, visited, orderList);
            return orderList;
        }

        public List<int> BFS(int v)
        {
            var visited = new List<bool>();
            for (int i = 0; i < _v; i++)
            {
                visited.Add(false);
            }
            var orderList = new List<int>();
            var queue = new Queue<int>();

            orderList.Add(v);
            queue.Enqueue(v);
            visited[v] = true;
            
            while (queue.Count != 0)
            {
                int node = queue.Dequeue();
                foreach (int n in _nodes[node])
                {
                    if (!visited[n])
                    {
                        orderList.Add(n);
                        queue.Enqueue(n);
                        visited[n] = true;
                    }
                }
            }
            return orderList;
        }
    }
}
