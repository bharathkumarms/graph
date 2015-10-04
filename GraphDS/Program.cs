using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph UG = new Graph(true);
            Vertex a = new Vertex("a");
            Vertex b = new Vertex("b");
            Vertex c = new Vertex("c");
            Vertex d = new Vertex("d");
            Vertex e = new Vertex("e");

            Vertex f = new Vertex("f");

            // Add vertexes
            UG.AddVertex(a);
            UG.AddVertex(b);
            UG.AddVertex(c);
            UG.AddVertex(d);
            UG.AddVertex(e);
            
            UG.AddEdge(a, b, 3);
            UG.AddEdge(a, c, 3);
            UG.AddEdge(b, d, 3);
            UG.AddEdge(d, e, 3);
            
            UG.BreadthFirstSearch(d);

            Console.ReadLine();
        }
    }
}
