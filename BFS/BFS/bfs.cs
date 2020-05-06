
using System; 
using System.Collections.Generic; 




public class Graph<T>
{
   public class Node {
      public T val;
      public int ver;

      public Node(T t, int v){
         this.val=t;
         this.ver=v;
      }
   }


   //////////////////////////var//////////////////////////
   public int [] parent, dist, color;
   private  Queue<int> queue;

   private int v; // number of vertices
   public List<Node >[] gr;
   private   static   int white=0, gray=1, black=2;

///////////constructor////////////////////////////////
public Graph(int ver){
   this.v=ver;
   parent=new int[v];
   dist=new int[v];
   color=new int[v];
   queue=new Queue<int>();
   gr=new List<Node> [v] ;
   for (int i = 0; i < v; i++)
   {
       gr[i]=new List<Node>();

   }


}

public void algoBfs(int s){//Bfs algo
   queue.Enqueue(s);
   color[s]=gray;
   dist[s]=0;
   while(queue.Count>0){
      int pull=queue.Dequeue();

      foreach (var item in gr[pull])
      {
         if(color[item.ver]==white){
            queue.Enqueue(item.ver);
            color[item.ver]=gray;
            dist[item.ver]=dist[pull]+1;
            parent[item.ver]=pull;
         }
        


       }
       color[pull]=black;



      }
   }


}


	

class main{
   public static void Main()
   {

      Graph<string>.Node  n0=new Graph<string>.Node ("hey",0);
      Graph<string>.Node  n1=new Graph<string>.Node("naor",1);
      Graph<string>.Node  n2=new Graph<string>.Node("how",2);
      Graph<string>.Node  n3=new Graph<string>.Node("are",3);

      Graph <string> graph=new Graph<string>(4);
      List<Graph<string>.Node> l1=new List<Graph<string>.Node>();
      l1.Add(n1);
       List<Graph<string>.Node> l2=new List<Graph<string>.Node>();
      l2.Add(n0);
      l2.Add(n2);
      List<Graph<string>.Node> l3=new List<Graph<string>.Node>();
      l2.Add(n1);
      l2.Add(n3);
      List<Graph<string>.Node> l4=new List<Graph<string>.Node>();
      l2.Add(n2);

      graph.gr[0]=l1;
      graph.gr[1]=l2;
      graph.gr[2]=l3;
      graph.gr[3]=l4;



      foreach (var item in graph.gr[1])
      {
          Console.WriteLine(item.ver);
      }

      
 
  


   
     


      
   }
}
