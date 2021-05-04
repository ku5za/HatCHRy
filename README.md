# HatCHRy Interview Project

## Usage
Link to live Web API's endpoint: https://jkuszewskihatchry.azurewebsites.net/  
Use any of the ["CAN", "USA", "MEX", "BLZ", "GTM", "SLV", "HND", "NIC", "CRI", "PAN"] codes at the end of the link above to get a response with the shortest avaliable path from the USA to the country with the passed code.

## Representation of the map
### Map as a graph
At this stage, I had to decide how I want to represent the map.
A map can be handly represented as an undirected graph, where we treat territories as vertices and a common border as an edge between those vertices.

### Different ways of representation for graphs
We can describe an undirected graph as an adjacency matrix or adjacency list. From those two in this context, an adjacency list suits better. The adjacency matrix occupies space for every potential connection between two vertices. With the map, it would end up with many empty elements for borders that are not connected.

### Different ways to implement adjacency lists
There are different ways to implement an adjacency list, depending on how we name vertices. For that purpose, we can use the Dictionary data structure if we want to use non-numerical values (like codes of countries), but those codes have to be unique. Another approach is to implement it with an array-like structure with vertices named as array indexes and then map those indexes to their code values.

### Unique names for vertices
To ensure our vertices are easy to manage and search for, we have to give them unique names. In the given example countries are described by code name. The example is small, and as we can see in that scale country codes are unique. Furthermore, those codes look like ISO 3166-1 alpha-3 standard, which leads me to an assumption that those codes are unique on a global scale too, but without additional information, I can't tell if that's the truth. If we want to add a new continent, can we be sure that those values are still unique? Implementation with numerical indexes and the dictionary to match their indexes to particular codes will allow us to distinguish vertices without worrying about those codes and will improve scalability.

## Finding path in the graph
### Proper algorithm choose
There are many ways to determine paths in graphs, depending on particular edge data like weight or distance or requirements for the desired path. In our case, there is no such data about edges, so I assume we can treat them as equally good. Provided outputs show that we are looking for the shortest available path solution. For this purpose, we can use a modified version of the breadth-first search(BFS) algorithm with an array of visited vertices' predecessors. That will allow us to recreate the desired path.

## Web API
### Not supported country code
There is no information in project requirements on how the system should handle a situation when someone passes the not supported country code.  In my opinion, it's a good practice to inform our user that something went wrong and I decided to do so by returning a message that the user passed not supported country code.
