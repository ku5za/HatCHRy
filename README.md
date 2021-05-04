# HatCHRy Interview Project
## Representation of the map
### Map as a graph
At this stage, I had to decide how I want to represent the map.
A map can be handly represented as an undirected graph, where we treat territories as vertices and a common border as an edge between those vertices.

### Different ways of representation for graphs
We can describe an undirected graph as an adjacency matrix or adjacency list. From those two in this context, an adjacency list would suit better. The adjacency matrix occupies space for every potential connection between two vertices. With the map, it would end up with many empty elements for borders that are not connected.

### Different ways to implement adjacency lists
There are different ways to implement an adjacency list, depending on how we name vertices. For that purpose, we can use the Dictionary data structure if we want to use non-numerical values (like codes of countries), but those codes have to be unique. Another approach is to implement it with an array-like structure with vertices named as array indexes and then map those indexes to their code values.

### Unique names for vertices
To ensure our vertices are easy to manage and search for, we have to give them unique names. In the given example countries are described by code name. The example is small, and as we can see in that scale country codes are unique. Furthermore, those codes look like ISO 3166-1 alpha-3 standard, which leads me to an assumption that those codes are unique on a global scale too, but without additional information, I can't tell if that's the truth. If we want to add a new continent, can we be sure that those values are still unique? Implementation with numerical indexes and the dictionary to match their indexes to particular codes will allow us to distinguish vertices without worrying about those codes and will improve scalability.

## Finding path in the graph
### Proper algorithm choose
There are many ways to determine paths in graphs, depending on data about particular edges like weight or distance between vertices or requirements about the found path. In our case, there is no such data about edges, so I assume we can treat them as equally good. Provided outputs show that we are looking for the shortest available path solution. For this purpose, we can use a modified version of the breadth-first search(BFS) algorithm with an array of visited vertices' predecessors. That will allow us to recreate the desired path.