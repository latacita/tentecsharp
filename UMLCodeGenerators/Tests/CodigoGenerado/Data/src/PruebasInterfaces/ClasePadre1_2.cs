using System;
using System.Collections.Generic; 
 
// This is the content of the class named "ClasePadre1_2", which is 
// in the package: "PruebasInterfaces", from the "Data" model. 
namespace Data{	
	partial class ClasePadre1_2:  Interface_ClasePadre1_2{
		// Utility methods from the current class  
		public virtual override bool Equals (Object o);
		public virtual override int CompareTo (Object o);
		public virtual override int GetHashCode ();
		public virtual override Type GetType ();
		public virtual override string ToString();

		// Constructor and methods from the from the current interface		
		private void PruebasInterfaces_initClasePadre1_2 () {}
		public  virtual void PruebasInterfaces_operacionPadre2 (	 int pa 
		) {}
			
	}
} 