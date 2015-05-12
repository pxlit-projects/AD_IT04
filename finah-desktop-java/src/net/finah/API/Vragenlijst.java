package net.finah.API;

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
}
