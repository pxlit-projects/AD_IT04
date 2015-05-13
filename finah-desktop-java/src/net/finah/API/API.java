package net.finah.API;

import com.fasterxml.jackson.core.JsonFactory;
import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.core.JsonParseException;
import com.fasterxml.jackson.core.JsonParser;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.ObjectReader;
import com.fasterxml.jackson.databind.ObjectWriter;

import sun.net.www.protocol.http.HttpURLConnection;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;

import net.finah.Debug.Debug;

/**
 * The API related to our project
 *
 * @author Project members
 */
//TODO: Makes sure all the URL's make sense
public class API {

	private static ObjectMapper mapper;
	private static ObjectWriter writer;
	private static URL remote;
	private static int ID;
	private static int lastID;


	/**
	 * Initialise the module.
	 * Not required, automatically called.
	 *
	 */
	public static void init(){
		if(mapper == null || writer == null ){
			mapper = new ObjectMapper();
			writer = mapper.writer();
			syncLastID();
		}
	}

	/**
	 * Set the url for the API
	 *
	 * @param newURL The base url for the API.
	 *
	 * @throws MalformedURLException
	 */
	 // TODO: Add a default URL
	public static void setURL(String newURL) throws MalformedURLException{
		remote = new URL(newURL);
	}

	/**
	 * Get a 'Vraag' from a specific 'Vragenlijst'
	 *
	 * @param lijst The Id of the list
	 * @param vraag The Id of the 'Vraag'
	 * @return The requested 'Vraag'
	 *
	 * @throws IOException
	 */
	public static Vraag getVraag(int lijst, int vraag) throws IOException{
		return getVragenLijst(lijst).get(vraag);
	}

	/**
	 * Get an 'Antwoord' from a specific 'Antwoordlijst'
	 *
	 * @param lijst The id of the list
	 * @param id the id of the 'Antwoord'
	 * @return
	 *
	 * @throws IOException
	 */
	public static Antwoord getAntwoord(int lijst, int id) throws IOException{
		return getAntwoordLijst(lijst).get(id);
	}


	/**
	 * Get a List of 'Vraag' objects with ID
	 *
	 * @param lijst The Id
	 * @return a list of 'Vraag' objects
	 *
	 * @throws IOException
	 */
	public static ArrayList<Vraag> getVragenLijst(int lijst) throws IOException{
		URL loc = new URL(remote + "vraag/" + lijst);
		init();
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Vraag>>(){});
		ArrayList<Vraag> vragen = reader.readValue(loc);
		return vragen;

	}

	/**
	 * Get a list of 'Rapport' objects
	 *
	 * @param id The rapport ID
	 * @return A list of 'Rapport' objects
	 *
	 * @throws IOException
	 */
	public static ArrayList<Rapport> getRapport(int id) throws IOException{
		URL loc = new URL(remote + "rapport/" + id);
		init();
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Rapport>>(){});
		ArrayList<Rapport> rapporten = reader.readValue(loc);
		return rapporten;

	}

	/**
	 * Get a list of 'Antwoord' objects
	 *
	 * @param id The id of the list
	 * @return
	 *
	 * @throws IOException
	 */
	public static ArrayList<Antwoord> getAntwoordLijst(int id) throws IOException{
		URL loc = new URL(remote + "antwoord/" + id);
		init();
		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Antwoord>>(){});
		ArrayList<Antwoord> antwoord = reader.readValue(loc);
		return antwoord;

	}

	/**
	 * Get a list of type 'Vragenlijst'
	 *
	 * @param id the id from which to get a vragenlijst
	 * @return
	 *
	 * @throws IOException
	 */
	//TODO: id verwijderen en wrapper functie maken
	public static ArrayList<Vragenlijst> getVragenlijst(int id) throws IOException{
		Debug.log("receiving 'Vragenlijst' data");
		URL loc = new URL(remote + "vragenlijst/");
		init();

		ObjectReader reader = mapper.reader(new TypeReference<ArrayList<Vragenlijst>>(){});
		ArrayList<Vragenlijst> vragenlijst = reader.readValue(loc);
		Debug.log("received 'Vragenlijst' data");
		return vragenlijst;
	}


	/**
	 * Transmit a list of 'Vraag' objects
	 *
	 * @param list
	 * @param id
	 *
	 * @throws IOException
	 */
	//TODO: Needs to be corrected
	public static void writeVragenLijst(ArrayList<Vraag> list, int id) throws IOException{
		Debug.log("Writing 'vragenlijst'");
		URL loc = new URL(remote + "vraag/");
		init();
		writeVragenlijst(new Vragenlijst("vragenlijst " + id, 1 ));
		syncLastID();
		Debug.log("Writing each 'Vraag'");
		for(Vraag vraag : list){
			vraag.setVragenLijst_Id(lastID);
			Debug.log("Writing " + vraag.toString() );
			writeVraag(vraag);
		}

		String json = writer.writeValueAsString(list);
		putData(json, loc);
		Debug.log("wrote 'VragenLijst' data");
	}

	/**
	 * Transmit a list of 'Vraag' Objects.
	 * Temporarily Disabled
	 *
	 * @param obj
	 *
	 * @throws IOException
	 */
	public static int writeVragenlijst(Vragenlijst obj) throws IOException{
		Debug.log("preparing to transfer to server");
		URL loc = new URL(remote + "vragenlijst/");
		init();
		Debug.log("transforming to json");
		String json = writer.writeValueAsString(obj);
		Debug.log("data written");
		String response = putData(json,loc);
		ObjectReader reader = mapper.reader(new TypeReference<Vragenlijst>(){});
		Vragenlijst vragenlijst = reader.readValue(response);
		return vragenlijst.getId();
	}

	/**
	 * Transmit a 'Vraag' object.
	 * Temporarily Disabled
	 *
	 * @param obj The 'vraag' to transmit
	 *
	 * @throws IOException
	 */
	public static void writeVraag(Vraag obj) throws IOException{
		URL loc = new URL(remote + "vraag/"); 
		init();
		String json = writer.writeValueAsString(obj);
		Debug.log("transfering  Vraag: " + obj.toString());
		putData(json, loc);
		Debug.log("transferd  Vraag: " + obj.toString());
	}

	private static String putData(String json, URL loc) throws IOException{
		HttpURLConnection httpcon = (HttpURLConnection) loc.openConnection();
		httpcon.setDoOutput(true);
		httpcon.setRequestMethod("POST");
		httpcon.setRequestProperty("Content-Type", "application/json");
		OutputStream out = httpcon.getOutputStream();
		out.write(json.getBytes());
		out.flush();
		if (httpcon.getResponseCode() != HttpURLConnection.HTTP_CREATED) {
			Debug.err("Wrong response code:" + httpcon.getResponseCode() + " from: "+ loc.toString() );
			throw new IOException("Connection Failed");
		}
		out.close();
		Debug.log("data transfer completed");

		Debug.log("Receiving response");
		BufferedReader br = new BufferedReader( new InputStreamReader( httpcon.getInputStream()));

		String line = null;
		StringBuilder sb = new StringBuilder();

		while ((line = br.readLine()) != null) {
			sb.append(line + "\n");
		}

		br.close();
		httpcon.disconnect();

		Debug.log("response: " + sb.toString());
		return sb.toString();
	}

	private static void syncLastID(){
		Boolean cont = true;
		int id = 0;
		//TODO: fix 1 (dokter ID)
		try{
			ArrayList<Vragenlijst> obj = getVragenlijst(2);
			for(Vragenlijst vragenlijst: obj){
				int derp = vragenlijst.getId();
				if(derp > id) id = derp;
				Debug.log(vragenlijst.toString());
			}
			if(id > 0) lastID = id;
			Debug.log(lastID + "");
		}catch(IOException e){
		}
	}
}
