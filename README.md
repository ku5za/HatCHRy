# HatCHRy - Interviev project

## Representation of the map
At this stage, I had to decide how I want to represent the map.
A map can be handly represented as an undirected graph, where territories are represented as vertices, and an edge between two territories determines if they have a common border.

An undirected graph can be described as an adjacency matrix or adjacency list.

From those two in this context, an adjacency list would suit better. The adjacency matrix occupies space for every potential connection between two vertices and with the map. It would end up with many empty elements for territories that are not connected to each other.
