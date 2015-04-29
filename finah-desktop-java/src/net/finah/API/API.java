package net.finah.API;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.ObjectReader;
import com.fasterxml.jackson.databind.ObjectWriter;

import java.io.File;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;


import net.finah.Debug.Debug;

public class API {

	private static ObjectMapper mapper;
	private static URL remote;
	private static String dloc = "API";


	public static void init(){
		if(mapper == null){
			mapper = new ObjectMapper();
		}
	}

	public static void setURL(String newURL) throws MalformedURLException{
		remote = new URL(newURL);
	}

	public static Vraag getVraag(int lijst, int vraag) throws IOException{
		return getVragenLijst(lijst).get(vraag);
	}

	public static Antwoord getAntwoord(int lijst, int id) throws IOException{
		return getAntwoordLijst(lijst).get(id);
	}


	public static ArrayList<Vraag> getVragenLijst(int lijst) throws IOException{
		URL loc = new URL(remote + "/vraag/" + lijst);
		init();
		Debug.log("receiving data", "getVragenlijst");
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Vraag>>(){});
		ArrayList<Vraag> vragen = reader.readValue(loc);
		Debug.log(vragen.toString(), "Vraag");
		return vragen;

	}

	public static ArrayList<Rapport> getRapport(int id) throws IOException{
		URL loc = new URL(remote + "/rapport/" + id);
		init();
		Debug.log("receiving data", "getRapportlijst");
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Rapport>>(){});
		ArrayList<Rapport> rapporten = reader.readValue(loc);
		Debug.log(rapporten.toString(), "Rapport");
		return rapporten;

	}

	public static ArrayList<Antwoord> getAntwoordLijst(int id) throws IOException{
		URL loc = new URL(remote + "/antwoord/" + id);
		init();
		Debug.log("receiving data", "getAntwoordlijst");
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Antwoord>>(){});
		ArrayList<Antwoord> antwoord = reader.readValue(loc);
		Debug.log(antwoord.toString(), "Antwoord");
		return antwoord;

	}


	public static String writeVragenLijst(ArrayList<Vraag> list, int id) throws IOException{
		URL loc = new URL(remote + "/antwoord/" + id);
		init();
		Debug.log("Transforming data", "writeVraagenlijst");
		//mapper.writeValue(new File("log/output.json"), list);
		ObjectWriter ow = new ObjectMapper().writer().withDefaultPrettyPrinter();
		String json = ow.writeValueAsString(list);
		return json;
	}
}
