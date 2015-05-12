package net.finah.API;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Vraag {
	@JsonProperty("Id")
	private int id;

	@JsonProperty("Beschrijving")
	private String beschrijving;

	@JsonProperty("Vragenlijst_Id")
	private int vragenlijst_Id;

	public String toString(){
		return id + ": " + beschrijving + ":" + vragenlijst_Id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public void setBeschrijving(String beschrijving) {
		this.beschrijving = beschrijving;
	}

	public void setVragenLijst_Id(int vragenlijst_Id) {
		this.vragenlijst_Id = vragenlijst_Id;
	}
	
}
