package net.azurewebsites.finahweb;
class Vraag{

	public int Id;
	public String Beschrijving;
	public int Vragenlijst_Id;

	public String toString(){
		return Id + ": " + Beschrijving;
	}
}
