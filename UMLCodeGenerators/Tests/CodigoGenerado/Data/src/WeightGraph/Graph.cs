using System;
using System.Collections.Generic;
// This is the content of the class named "Graph", which is 
// in the package: "WeightGraph", from the "Data" model. 
namespace Data{	
	 	public partial class Graph{

		// Properties from the current class 
 
		
		// Utility methods from the current class 
		
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current class		
	        	
		private void WeightGraph_initGraph () {}
		public virtual void WeightGraph_addEdge (	 Node n, Node m, float w 
		) {}
			
	

	
	
	}
} 
  



