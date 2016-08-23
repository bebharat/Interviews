using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Graph
    {
        public int NoOfVertices { get; private set; }
        public Dictionary<int,List<int>> Vertices { get; private set; }

        public Graph()
        {
            Vertices = new Dictionary<int, List<int>>();
        }

        public Graph(int v, Dictionary<int, List<int>> vertices)
        {
            NoOfVertices = v;
            Vertices = vertices;
        }

        public void AddVertex(int v)
        {
            NoOfVertices++;
            Vertices.Add(v, null);
        }

        public void AddEdge(int m, int n)
        {
            if (!Vertices.ContainsKey(m))
                AddVertex(m);

            if (!Vertices.ContainsKey(n))
                AddVertex(n);

            var m_neighbors = Vertices.Where(a => a.Key == m).Select(a => a.Value).FirstOrDefault();

            if (m_neighbors == null) m_neighbors = new List<int>();
            m_neighbors.Add(n);
            Vertices[m] = m_neighbors;

            var n_neighbors = Vertices.Where(a => a.Key == n).Select(a => a.Value).FirstOrDefault();

            if (n_neighbors == null) n_neighbors = new List<int>();
            n_neighbors.Add(m);

            Vertices[n] = n_neighbors;
        }

    }
}
