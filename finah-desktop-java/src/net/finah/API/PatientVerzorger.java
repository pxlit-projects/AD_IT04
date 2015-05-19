package net.finah.API;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonProperty;

public class PatientVerzorger {
	@JsonProperty("Id")
	private int id;

	@JsonProperty("Vnaam")
	private String vNaam;

	@JsonProperty("Anaam")
	private String aNaam;

	@JsonProperty("Email")
	private String email;

	@JsonProperty("Verzorger")
	private boolean verzorger;

	@JsonProperty("Dokter_Id")
	private int dokterId;
	
	public void setvNaam(String vNaam) {
		this.vNaam = vNaam;
	}

	public void setaNaam(String aNaam) {
		this.aNaam = aNaam;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public void setVerzorger(boolean verzorger) {
		this.verzorger = verzorger;
	}

	@JsonIgnore
	public String toString(){
		return id + ":" + vNaam + "-" + aNaam + ":" + email + ":" + verzorger + ":" + dokterId;
	}

	@JsonIgnore
	public boolean isPatient() {
		return !verzorger;
	}

	@JsonIgnore
	public String getANaam() {
		return aNaam;
	}

	@JsonIgnore
	public String getVNaam() {
		return vNaam;
	}

	@JsonIgnore
	public String getemail() {
		return email;
	}
	
	@JsonIgnore
	public Object getFullNaam() {
		return getANaam() + "-" + getVNaam() ;
	}

	public void setDokterId(int i) {
		dokterId = i;	
	}
}
