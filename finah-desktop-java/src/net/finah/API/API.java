package net.finah.API;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.ObjectReader;

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

	public static ArrayList<Vraag> getVragenLijst(int lijst) throws IOException{
		URL loc = new URL(remote + "/vraag/" + lijst);
		init();
		Debug.log("receiving data", "Vraag");
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Vraag>>(){});
		ArrayList<Vraag> hark = reader.readValue(loc);
		Debug.log(hark.toString(), "Vraag");
		return hark;

	}
}
