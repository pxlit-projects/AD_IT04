package net.finah;

import java.util.ArrayList;
import java.io.IOException;
import java.net.URL;

import net.finah.API.*;
import net.finah.Debug.Debug;

public class Test {

	public static void main(String[] args) {
		try {
			System.out.println("Setting up");
			API.setURL("http://finahweb.azurewebsites.net/api/");
			// System.out.println("Vragenlijst 1 laden");
			// ArrayList<Vraag> lijst1 = API.getVragenLijst(1);
			// System.out.println("Writing");

			// lijst1.get(0).setBeschrijving("TEST-VRAAG 1");
			// lijst1.get(1).setBeschrijving("TEST-VRAAG 2");
			// for(Vraag vraag: lijst1){
			// vraag.setVragenLijst_Id(2);
			// }
			// disabled om te vermijden dat de API vol zou geraken
			// API.writeVragenLijst(lijst1,2);
			// API.setLogin(new Login("jan.schoefs@gmail.com","P@ssw0rd"));
			// try{
			// API.login(new
			// URL("http://finahweb.azurewebsites.net/account/login"));
			// }catch(Exception e){
			// Debug.log("Login Failed: " + e.getMessage() +".");
			// }
			ArrayList<PatientVerzorger> list = API.getPatientVerzoger();
			for (PatientVerzorger test : list) {
				Debug.log(test.toString());
			}
			System.out.println("Done");
		} catch (IOException e) {
			Debug.err(e.getMessage());
		}
	}

}
