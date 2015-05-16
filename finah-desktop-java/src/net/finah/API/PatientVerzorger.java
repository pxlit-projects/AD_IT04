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
	private boolean dokterId;

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
