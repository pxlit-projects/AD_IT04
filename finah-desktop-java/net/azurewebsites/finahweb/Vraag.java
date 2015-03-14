package net.azurewebsites.finahweb;
class Vraag{

	public int Id;
	public String Beschrijving;
	public static  int Aantal = 0;

	public Vraag(int id,String vraag){
		this.Id = id;
		this.Beschrijving = vraag;
		Aantal += 1;
	}

	public String toString(){
		return Id + ": " + Beschrijving;
	}
}
