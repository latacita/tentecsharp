using System;
using System.Collections.Generic;
// This is the content of the class named "WindowSensor", which is 
// in the package: "WindowMng", from the "Data" model. 
namespace Data{	
	 	public partial class WindowSensor : Sensor{
 
		// Properties from the current class 		 
		
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void WindowMng_initWindowSensor ( ) {}
		private  virtual  Int  WindowMng_getAperture ( ) {}
			
	
	
	}
} 
  



