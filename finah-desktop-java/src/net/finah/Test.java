package net.finah;


import java.util.ArrayList;

import net.finah.API.*;
import net.finah.Debug.Debug;

public class Test {

	public static void main(String[] args) {
		try {
			System.out.println("Loading");
			API.setURL("http://finahweb.azurewebsites.net/api");
			ArrayList<Vraag> lijst1 = API.getVragenLijst(1);
			Vraag vraag1 = (Vraag)lijst1.get(0);
			System.out.println(vraag1);

			ArrayList<Rapport> rapportLijst = API.getRapport(1);
			Rapport rapport1 = rapportLijst.get(0);
			System.out.println(rapport1);

			ArrayList<Antwoord> antwoordLijst = API.getAntwoordLijst(1);
			Antwoord antwoord1 = antwoordLijst.get(0);
			System.out.println(antwoord1);

			Vraag vraag2 = API.getVraag(1,2);
			System.out.println(vraag2);

			Antwoord antwoord2 = API.getAntwoord(1,2);
			System.out.println(antwoord2);

			System.out.println("Done");
		} catch (Exception e) {
			Debug.err(e.getMessage(), "main");
		}
	}

}
