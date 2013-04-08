using System;
using System.Collections.Generic;
// This is the content of the class named "DoctorPerson", which is 
// in the package: "PruebasHerencia", from the "Data" model. 
namespace Data{	
	 	partial class DoctorPerson : Persona{
 
		// Properties from the current class 		 
		
		private String specialty;
		public String Specialty {
			get { return this.specialty; }
			set { this.specialty= value; }
		}
		 
		 
		
		// Utility methods from the current class 
		
		public  virtual  override bool Equals (Object o);
		public  virtual  override int CompareTo (Object o);
		public  virtual  override int GetHashCode ( );
		public  virtual  override Type GetType ( );
		public  virtual  override string ToString( );

		
		// Constructor and methods from the from the current class		
		private void PruebasHerencia_initDoctorPerson ( ) {}
			
	
	
	}
} 
  




