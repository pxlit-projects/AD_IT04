package net.finah.API;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Antwoord {
	@JsonProperty("Id")
	private int id;

	@JsonProperty("Vraag_Id")
	private int vraag_Id;

	@JsonProperty("Rapport_Id")
	private int rapport_Id;

	@JsonProperty("AntwoordInt")
	private int antwoordInt;

	@JsonProperty("AntwoordExtra")
	private int antwoordExtra;

	@JsonProperty("Verzorger")
	private boolean verzorger;

	public void setId(int id) {
		this.id = id;
	}

	public void setVraag_Id(int vraag_Id) {
		this.vraag_Id = vraag_Id;
	}

	public void setRapport_Id(int rapport_Id) {
		this.rapport_Id = rapport_Id;
	}

	public void setAntwoordInt(int antwoordInt) {
		this.antwoordInt = antwoordInt;
	}

	public void setAntwoordExtra(int antwoordExtra) {
		this.antwoordExtra = antwoordExtra;
	}

	public void setVerzorger(boolean verzorger) {
		this.verzorger = verzorger;
	}

	public int getId() {
		return id;
	}

	public int getVraag_Id() {
		return vraag_Id;
	}

	public int getRapport_Id() {
		return rapport_Id;
	}

	public int getAntwoordInt() {
		return antwoordInt;
	}

	public int getAntwoordExtra() {
		return antwoordExtra;
	}

	public boolean getVerzorger() {
		return verzorger;
	}

	public String toString() {
		return id + ":" + vraag_Id + "," + rapport_Id + "," + antwoordInt + "," + antwoordExtra + " verzorger:" + verzorger;
	}
}
