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
			Vraag vraag1 = (Vraag)lijst1.get(0);
			//System.out.println(vraag1);

			System.out.println("rapport 1 laden");
			ArrayList<Rapport> rapportLijst = API.getRapport(1);
			Rapport rapport1 = rapportLijst.get(0);
			//System.out.println(rapport1);

			System.out.println("antwoordlijst 1 laden");
			ArrayList<Antwoord> antwoordLijst = API.getAntwoordLijst(1);
			Antwoord antwoord1 = antwoordLijst.get(0);
			//System.out.println(antwoord1);

			Vraag vraag2 = API.getVraag(1,2);
			//System.out.println(vraag2);

			Antwoord antwoord2 = API.getAntwoord(1,2);
			//System.out.println(antwoord2);
			System.out.println("Writing");

			// test data
			//vraag1.setBeschrijving("test");
			//vraag1.setId(0);
			//vraag1.setVragenLijst_I(0);
			//lijst1.set(1,vraag1);
			//write data
			lijst1.get(0).setBeschrijving(" TEST-VRAAG 1");
			lijst1.get(2).setBeschrijving(" TEST-VRAAG 2");
			for(Vraag vraag: lijst1){
				vraag.setVragenLijst_Id(2);
			}
			Debug.log(lijst1.toString());
			API.writeVragenLijst(lijst1,2);
			System.out.println("Done");
		} catch (IOException e) {
			Debug.err(e.getMessage()  , "main");
		}
	}

}
