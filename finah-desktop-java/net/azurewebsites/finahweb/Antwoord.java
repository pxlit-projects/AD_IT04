package net.azurewebsites.finahweb;

class Antwoord{
	int AntwoordExtra;
	int AntwoordInt;
	int Id;
	boolean verzoger;
	int vraagid;

	public String toString(){
		return Id + ": " + vraagid + "\t|" + AntwoordInt + "|" + AntwoordExtra + "\t(" + verzoger + ")";
	}
}
