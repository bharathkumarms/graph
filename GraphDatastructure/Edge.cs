using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDS
{
    class Edge
    {
        public Edge(Vertex from, Vertex to, int weight)
        {
            VertexFrom = from;
            VertexTo = to;
            Weight = weight;
        }

        public Vertex VertexFrom { get; set; }
        public Vertex VertexTo { get; set; }
        public int Weight { get; set; }

    }
}
