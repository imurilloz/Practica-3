using System;

namespace HashTables
{
	public class ClasePrincipal
	{

	public static void Main(string[] args){

			claseProgra llamadaMetodos = new claseProgra ();
			llamadaMetodos.captura();  
			Console.Clear ();
			llamadaMetodos.edit (); 
			Console.Clear (); 
			llamadaMetodos.delete ();
			Console.Clear (); 
			llamadaMetodos.printAll(); 
		
		}
	
	}
}

