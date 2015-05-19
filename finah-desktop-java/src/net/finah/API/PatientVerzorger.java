package net.finah.API;

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

	public String toString(){
		return id + ":" + vNaam + "-" + aNaam + ":" + email + ":" + verzorger + ":" + dokterId;
	}

	public boolean isPatient() {
		return !verzorger;
	}

	public String getANaam() {
		return aNaam;
	}

	public String getVNaam() {
		return vNaam;
	}

	public String getemail() {
		return email;
	}
	
	public Object getFullNaam() {
		return getANaam() + "-" + getVNaam() ;
	}
}
