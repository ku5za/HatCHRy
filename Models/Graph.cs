using System;
using System.Collections.Generic;

namespace Models
{
    public class Graph<T>
    {
        protected LinkedList<T> adjacencyList;
        public Graph()
        {
            adjacencyList = new LinkedList<T>();
        }
    }
}
