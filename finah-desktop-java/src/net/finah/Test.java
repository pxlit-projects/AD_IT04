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
			System.out.println("Done");
		} catch (Exception e) {
			Debug.err(e.getMessage(), "main");
		}
	}

}
