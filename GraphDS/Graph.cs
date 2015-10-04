using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDS
{
    class Graph
    {
        public bool IsDirectGraph { get; set; }
        private HashSet<Vertex> _vertexes;
        private Dictionary<Vertex, LinkedList<Edge>> _VertexEdgeMapping;

        public Graph(bool isDirect)
        {
            IsDirectGraph = isDirect;
            _vertexes = new HashSet<Vertex>();
            _VertexEdgeMapping = new Dictionary<Vertex, LinkedList<Edge>>();
        }

        public bool AddVertex(Vertex vertex)
        {
            _vertexes.Add(vertex);
            _VertexEdgeMapping.Add(vertex, new LinkedList<Edge>());
            return true;
        }

        public bool AddEdge(Vertex from, Vertex to, int weight)
        {
            Edge newEdge = new Edge(from, to, weight);
            _VertexEdgeMapping[from].AddLast(newEdge);
            if (IsDirectGraph == false)
            {
                Edge backEdge = new Edge(to, from, weight);
                _VertexEdgeMapping[to].AddLast(backEdge);
            }
            return true;
        }

        public bool BreadthFirstSearch(Vertex searchVertex)
        {
            Console.WriteLine("Breadth First Search!");
            
            bool found = false;
            int position = 0;

            Vertex rootVertex = _vertexes.First();

            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(rootVertex);

            while (queue.Count != 0)
            {
                Vertex temp = queue.Dequeue();
                if (temp.VertexLabel == searchVertex.VertexLabel)
                {
                    found = true;
                    Console.WriteLine("Vertex {0} has been found in {1} position!", temp.VertexLabel, position);
                    break;
                }
                else
                {
                    foreach (Edge edge in _VertexEdgeMapping[temp])
                    {
                        queue.Enqueue(edge.VertexTo);
                    }
                }

                position++;
            }

            if (!found)
            {
                Console.WriteLine("Not Found");
            }

            return true;
        }
    }
}