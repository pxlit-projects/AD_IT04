package net.azurewebsites.finahweb;

class Antwoord{
	int AntwoordExtra;
	int AntwoordInt;
	int Id;
	boolean Verzorger;
	int Vraag_Id;
	int Rapport_Id;

	public String toString(){
		return Id + ": " + Vraag_Id + "\t|" + AntwoordInt + "|" + AntwoordExtra + "\t(" + Verzorger + ")";
	}
}
