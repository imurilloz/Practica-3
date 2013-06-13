using System;
using System.Collections; 
namespace HashTables
{
	public class claseProgra
	{

		private Hashtable tabla;

	public claseProgra ()
		{
		this.tabla = new Hashtable();
		}
	
		private void capturaDeDatos (Datos datos){
			Console.WriteLine ("Ingresar datos");

		      if(datos.key == "" ){  
				Console.WriteLine ("Ingresar el codigo de registro");
				datos.key = Console.ReadLine ();  }

		     Console.WriteLine ("Nombre");
			datos.nombre = Console.ReadLine (); 
	
			Console.WriteLine ("Direccion");
			datos.direccion = Console.ReadLine (); 
		
			Console.WriteLine ("Correo electronico");
			datos.e_mail = Console.ReadLine (); 
		 
			Console.WriteLine ("Telefono");
			datos.telefono = Console.ReadLine ();        	
		
		}
	
	private void capturarPersona(Datos datos ){
			this.capturaDeDatos (datos); 

			this.agregaPersona(datos);
		}
	
	
	public void captura(){         
			for(int i=0; i<4; i++){
		     Console.Clear();
				this.capturarPersona(new Datos()); 
				}
		        }
	
	
private void agregaPersona(Datos datos){

			if( this.tabla.ContainsKey(datos.key)){
				this.tabla.Remove(datos.key);
				}

			this.tabla.Add(datos.key,datos);

		}
	
	
        private void printPerson(Datos datos){
		
			Console.WriteLine ("Nobre"+datos.nombre);
			Console.WriteLine ("Clave"+datos.key);
			Console.WriteLine ("Direccion"+datos.direccion);
			Console.WriteLine ("Telefono"+datos.telefono);
			Console.WriteLine ("Correo electronico"+datos.e_mail);
			Console.WriteLine ("");
		
	}

	 private void printFail(){
		Console.WriteLine ("Error La clave no existe ");
			Console.WriteLine ("Presione cualquier tecla para continuar ");
			Console.ReadLine (); 
		
		}


		public void edit(){

			for(int i=0; i<2; i++){
				Console.Clear(); 
				string key = "";
				Console.WriteLine("Ingresar codigo");
				key = Console.ReadLine(); 
				if(this.tabla.ContainsKey(key)){

					Datos datos = (Datos)this.tabla[key]; 
					this.printPerson(datos);
					this.capturarPersona(datos);
				}else{this.printFail();    
				
				}

			}

		}
	
	        private void confirmDelete(string key){
		
			Console.WriteLine ("El registro sera eliminado");
			Console.WriteLine ("[0]Cancelar  [1]Aceptar  ");
			string opcion = Console.ReadLine (); 
			if(opcion !="0"){  
				this.tabla.Remove(key);
			}
		}


	public void delete(){
			for(int i=0; i<2; i++){
				Console.Clear(); 
				string key = ""; 
				Console.WriteLine("Ingrese codigo");
				key= Console.ReadLine(); 

				if(this.tabla.ContainsKey(key)){ 
					Datos datos = (Datos)this.tabla[key]; 
					this.printPerson(datos);
					this.confirmDelete(datos.key);
				
				}else{ 
					this.printFail(); 
				
				}
			}

		}
	
	
	
		public void printAll(){

			ICollection registros = this.tabla.Values; 
			foreach(object objeto in registros){

				Datos datos = (Datos) objeto; 
				this.printPerson(datos);

			}


		}
	
	}
}

