package net.finah.API;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.ObjectReader;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
//import java.util.List;

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

	private static String getJSON(String database, int suffix ) throws IOException {
		if(remote != null){
			URL location = new URL(remote.toString() + "/" + database);

			HttpURLConnection conn = (HttpURLConnection) location.openConnection();
			conn.setRequestMethod("GET");
			conn.connect();

			int response = conn.getResponseCode();

			switch(response){
				case 404:
				case 500:
					Debug.err("Unsuccessful Connection", dloc);
					return null;
				case 200:
					Debug.log("Successful Connection",dloc);
					BufferedInputStream reader = new BufferedInputStream(conn.getInputStream());
					StringBuilder stringBuilder = new StringBuilder();
					int chr;
					while ((chr = reader.read()) != -1){
						stringBuilder.append((char)chr);
					}
					String json = stringBuilder.toString();
					return json;
				default:
					return null;
			}

		}else{
			throw new MalformedURLException();
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
		String json = getJSON("vraag", lijst);
		if(json != null){
			init();
			Debug.log("receiving data", "Vraag");
			ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Vraag>>(){});
			ArrayList<Vraag> hark = reader.readValue(loc);
			Debug.log(hark.toString(), "Vraag");
			return hark;
		}else{

			return null;
		}
	}
}
