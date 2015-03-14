package net.azurewebsites.finahweb;
class Rapport{
	int Id;
	String Date;
	String NaamPatient;
	String NaamVerzoger;

	public String  toString(){
		return Id+ ": " + Date + "\t (" + NaamPatient +  "," + NaamVerzoger + ")";
	}
}
