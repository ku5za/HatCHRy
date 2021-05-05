using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCases
{
    public class BfsShortestPathFinderAlgorithm : PathFinderAlgorithm
    {
        public BfsShortestPathFinderAlgorithm(List<int>[] adjacencyList) : base(adjacencyList)
        {
        }

        public override List<int> GetShortestPathList(int source, int destination)
        {
            List<int> predecessorsList = BFS(source, destination);
            Stack<int> pathStack = GetPredecessorsStack(predecessorsList, destination);
            return pathStack.ToList();
        }

        private Stack<int> GetPredecessorsStack(List<int> predecessorsList, int destination)
        {
            Stack<int> pathStack = new Stack<int>();
            pathStack.Push(destination);
            int current = destination;
            while (predecessorsList[current] != -1)
            {
                pathStack.Push(predecessorsList[current]);
                current = predecessorsList[current];
            }
            return pathStack;
        }

        private List<int> BFS(int source, int destination)
        {
            int numberOfVerticesInGraph = adjacencyList.Length;
            bool[] visited = Enumerable.Repeat(false, numberOfVerticesInGraph).ToArray();
            List<int> predecessors = Enumerable.Repeat(-1, numberOfVerticesInGraph).ToList();
            Queue<int> visitedVerticesQueue = new Queue<int>();

            visited[source] = true;
            visitedVerticesQueue.Enqueue(source);

            while(visitedVerticesQueue.Any())
            {
                int currentVertex = visitedVerticesQueue.Dequeue();

                foreach(int vertexNeighbour in adjacencyList[currentVertex])
                {
                    if(visited[vertexNeighbour] == false)
                    {
                        visited[vertexNeighbour] = true;
                        predecessors[vertexNeighbour] = currentVertex;
                        visitedVerticesQueue.Enqueue(vertexNeighbour);

                        if (vertexNeighbour == destination)
                            return predecessors;
                    }
                }
            }

            return predecessors;
        }
    }
}
