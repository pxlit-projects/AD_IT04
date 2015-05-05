package net.finah.API;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.ObjectReader;
import com.fasterxml.jackson.databind.ObjectWriter;

//import com.sun.net.ssl.HttpsURLConnection;
import sun.net.www.protocol.http.HttpURLConnection;

import java.io.File;
import java.io.IOException;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
//import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;

//import javax.net.ssl.HttpsURLConnection;



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
		Debug.log("receiving 'vragenLijst' data");
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Vraag>>(){});
		ArrayList<Vraag> vragen = reader.readValue(loc);
		//Debug.log(vragen.toString(), "Vraag");
		return vragen;

	}

	public static ArrayList<Rapport> getRapport(int id) throws IOException{
		URL loc = new URL(remote + "/rapport/" + id);
		init();
		Debug.log("receiving 'rapportLijst' data");
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Rapport>>(){});
		ArrayList<Rapport> rapporten = reader.readValue(loc);
		//Debug.log(rapporten.toString(), "Rapport");
		return rapporten;

	}

	public static ArrayList<Antwoord> getAntwoordLijst(int id) throws IOException{
		URL loc = new URL(remote + "/antwoord/" + id);
		init();
		Debug.log("receiving 'antwoordLijst' data");
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Antwoord>>(){});
		ArrayList<Antwoord> antwoord = reader.readValue(loc);
		//Debug.log(antwoord.toString(), "Antwoord");
		return antwoord;

	}

	public static ArrayList<Vragenlijst> getVragenlijst(int id) throws IOException{
		URL loc = new URL(remote + "/vragenlijst/"+ id);
		init();
		Debug.log("receiving 'Vragenlijst' data");

		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Vragenlijst>>(){});
		ArrayList<Vragenlijst> vragenlijst = reader.readValue(loc);

		return vragenlijst;
	}


	public static void writeVragenLijst(ArrayList<Vraag> list, int id) throws IOException{
		URL loc = new URL(remote + "/vraag/");
		init();
		Debug.log("checking if list already added");
		ArrayList<Vragenlijst> vragenlijst = getVragenlijst(id);
		if(vragenlijst.isEmpty()){
			Debug.err("How Jerry! dees is leeg!");
			// TODO: 1 is hier een tijdelijke waarde, moet dokter ID voorstellen
			writeVragenlijst(new Vragenlijst(id, "vragenlijst " + id, 1 ));
		}
		Debug.log("transforming 'VragenLijst' data");

		//mapper.writeValue(new File("log/output.json"), list);
		ObjectWriter ow = new ObjectMapper().writer();
		//ow.writeValue(new File("log/output.json"),list);
		String json = ow.writeValueAsString(list);
		Debug.log("transfering 'VragenLijst' data");
		putData(json, loc);
		Debug.log("sent 'VragenLijst' data");
	}

	public static void writeVragenlijst(Vragenlijst obj) throws IOException{
		URL loc = new URL(remote + "/vragenlijst/");
		init();
		Debug.log("transforming to json");
		ObjectWriter ow = new ObjectMapper().writer();
		String json = ow.writeValueAsString(obj);

		putData(json,loc);

		Debug.log("transfered data");
	}

	private static void putData(String json, URL loc) throws IOException{
		Debug.log("Uploading data to: " + loc.toString());
		// create a connection to the url
		HttpURLConnection httpcon = (HttpURLConnection) loc.openConnection();
		//make it a writable connection
		httpcon.setDoOutput(true);
		//use the POST method
		httpcon.setRequestMethod("POST");
		//declare it's JSON
		httpcon.setRequestProperty("Content-Type", "application/json");

		//create an output stream
		//OutputStreamWriter out = new OutputStreamWriter( httpcon.getOutputStream());
		OutputStream out = httpcon.getOutputStream();
		out.write(json.getBytes());
		out.flush();
		if (httpcon.getResponseCode() != HttpURLConnection.HTTP_CREATED) {
			Debug.err("Wrong response code:" + httpcon.getResponseCode() );
		}

		out.close();
		Debug.log("data transfer completed (false)");
	}


}
