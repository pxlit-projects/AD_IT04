package net.finah.API;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Login {
	@JsonProperty("email")
	private String email;

	@JsonProperty("password")
	private String password;

	@JsonProperty("returnUrl")
	private String returnUrl;

	public Login(String email, String password){
		this.email = email;
		this.password = password;
		this.returnUrl = "abc";
	}

	public String toString(){
		return "login:" + email + ":" + password;
	}
}
