using System;
using System.Collections.Generic;
using System.Linq;

namespace bfs
{
    class Program
    {
       

//////Generic graph class that represents tree of nodes of any object
public class Graph<T>
    {
////Node claas htat have the type and its value and the ver that represents the num of vertice.

        public class Node
        {
            public T val;
            public int ver;

            public Node(T t, int v)
            {
                this.val = t;
                this.ver = v;
            }
        }


   //////////////////////////vars of graph//////////////////////////
        private int[] parent, dist, color;
        private Queue<int> queue;//for bfs algo
        private int v; // number of vertices
        public List<Node>[] gr;
        private static int white = 0, gray = 1, black = 2;

        ///////////constructor////////////////////////////////
        public Graph(int ver)
        {
            this.v = ver;
            parent = new int[v];
            dist = new int[v];
            color = new int[v];
            queue = new Queue<int>();
            gr = new List<Node>[v];
            for (int i = 0; i < v; i++)
            {
                gr[i] = new List<Node>();

            }
            


        }



        ///////get parent/////

        public int [] getParrent(){
           return parent;




        }

         ///////get distance/////

        public int [] getDistance(){
           return dist;



           
        }
/////////////Bfs algo///////////////////////

        public void algoBfs(int s)
        {
            queue.Enqueue(s);
            color[s] = gray;
            dist[s] = 0;
            while (queue.Count > 0)
            {
                int pull = queue.Dequeue();

                foreach (var item in gr[pull])
                {
                    if (color[item.ver] == white)
                    {
                        queue.Enqueue(item.ver);
                        color[item.ver] = gray;
                        dist[item.ver] = dist[pull] + 1;
                        parent[item.ver] = pull;
                    }



                }
                color[pull] = black;
                Console.Write(pull+"->");
				



            }
                            Console.Write("End");

                
            }

            
    }




    class main
    {
        public static void Main()
        {
//////making nodes of string///////////
            Graph<string>.Node n0 = new Graph<string>.Node("hey", 0);
            Graph<string>.Node n1 = new Graph<string>.Node("naor", 1);
            Graph<string>.Node n2 = new Graph<string>.Node("how", 2);
            Graph<string>.Node n3 = new Graph<string>.Node("are", 3);
            Graph<string>.Node n4 = new Graph<string>.Node("are", 4);
            Graph<string>.Node n5 = new Graph<string>.Node("are", 5);
            

////making instance of graph
            Graph<string> graph = new Graph<string>(6);
			
            List<Graph<string>.Node> l1 = new List<Graph<string>.Node>();
            l1.Add(n1);
            l1.Add(n2);
            List<Graph<string>.Node> l2 = new List<Graph<string>.Node>();
            l2.Add(n0);
            l2.Add(n4);
            l2.Add(n3);
            List<Graph<string>.Node> l3 = new List<Graph<string>.Node>();
            l3.Add(n5);
            l3.Add(n3);
            l3.Add(n0);
            List<Graph<string>.Node> l4 = new List<Graph<string>.Node>();
            l4.Add(n2);
            l4.Add(n1);
            List<Graph<string>.Node> l5 = new List<Graph<string>.Node>();
            l5.Add(n1);
            List<Graph<string>.Node> l6 = new List<Graph<string>.Node>();
            l6.Add(n2);

            graph.gr[0] = l1;
            graph.gr[1] = l2;
            graph.gr[2] = l3;
            graph.gr[3] = l4;
            graph.gr[4] = l5;
            graph.gr[5] = l6;


            graph.algoBfs(3);











        }
    }

}
}
