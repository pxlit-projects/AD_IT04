package net.finah;


import java.util.ArrayList;
import java.io.IOException;

import net.finah.API.*;
import net.finah.Debug.Debug;

public class Test {

	public static void main(String[] args) {
		try {
			System.out.println("Setting up");
			API.setURL("http://finahweb.azurewebsites.net/api/");
			System.out.println("Vragenlijst 1 laden");
			ArrayList<Vraag> lijst1 = API.getVragenLijst(1);
			System.out.println("Writing");

			lijst1.get(0).setBeschrijving("TEST-VRAAG 1");
			lijst1.get(1).setBeschrijving("TEST-VRAAG 2");
			for(Vraag vraag: lijst1){
				vraag.setVragenLijst_Id(2);
			}
			API.writeVragenLijst(lijst1,2);
			System.out.println("Done");
		} catch (IOException e) {
			Debug.err(e.getMessage());
		}
	}

}
