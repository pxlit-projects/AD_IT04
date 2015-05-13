package net.finah.API;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonProperty;

public class Vragenlijst {

	@JsonProperty("Id")
	private int id;

	@JsonProperty("Beschrijving")
	private String beschrijving;


	@JsonProperty("Dokter_Id")
	private int dokter_Id;

	public String toString(){
		return id + ":" + beschrijving + ":" + dokter_Id ;
	}

	public Vragenlijst(String beschrijving, int dokter_Id) {
		this.beschrijving = beschrijving;
		this.dokter_Id = dokter_Id;
	}

	@JsonCreator
	public Vragenlijst(@JsonProperty("Id") int id,	@JsonProperty("Beschrijving") String beschrijving, @JsonProperty("Dokter_Id") int dokter_Id) {
		this.id = id;
		this.beschrijving = beschrijving;
		this.dokter_Id = dokter_Id;
	}

	public int getId(){
		return id;
	}
}
