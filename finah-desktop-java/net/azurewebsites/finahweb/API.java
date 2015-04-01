package net.azurewebsites.finahweb;
import java.net.*;
import java.io.*;
import org.json.simple.*;

class API{
	static String url;
	static String location = "API"; // Easier for Debugging

	/**
	 * Set the URL to get the data from
	 *
	 * @param newURL The URL of the remote database
	 */
	public static void setURL(String newURL){
		try{
			URL urlTest = new URL(newURL);
			url = newURL;
		}catch(MalformedURLException e){
			Debug.err("Error:" + e, location);
		}
	}
	/**
	 * Get Data from URL
	 *
	 * Return an object that coresponds to a Class in the given table.
	 *
	 * @param table The Table in The database
	 * @param row the Row in the table
	 * @param c The class of which you like to recieve an object off
	 *
	 * @return An object that should be convertable to the class c
	 * @see org.json.simple
	 */
	private static Object getRow(String table, int row, Class<?> c ) throws NullPointerException, IOException{
		try{
			String temp = url + "/" + table + "/" + row;
			URL Url = new URL(temp);
			HttpURLConnection conn = (HttpURLConnection) Url.openConnection();
			//Debug.log(Url.toString(),location);
			conn.setRequestMethod("GET");
			conn.connect();
			//Debug.log(conn.getResponseCode() + "", location);
			if(conn.getResponseCode() == 200){
				BufferedInputStream reader = new BufferedInputStream(conn.getInputStream());
				StringBuilder stringBuilder = new StringBuilder();
				int chr;
				while ((chr = reader.read()) != -1){
					stringBuilder.append((char)chr);
				}
				String json = stringBuilder.toString();
				//Debug.log(json, "JSONObj" );

				Object obj = JSONValue.parse(json);
				
				// If the object is an array, (check in different way?) convert it to an array and then get the wanted object, and convert it.
				try{
					JSONArray derp = (JSONArray) obj;
					Object honk = c.cast(derp.get(row));
					Debug.log(honk.toString(),"JSONObjString");
					//Debug.log();
					return honk;
				}catch(ClassCastException e){
					Debug.err(e.getMessage(), location + "-ArrayConversion");
				}
				return c.cast(obj);
				//return gson.fromJson(json, c);
			}else{
				if(conn.getResponseCode() != 404){
					//Debug.err("Could not connect:" + conn.getResponseCode() + ":" + conn.getResponseMessage(), location);
				}
				throw new IOException("Response:" + conn.getResponseCode());
			}

		}catch(IOException e){
			//Debug.err( e.toString(), location);
			return null;
		}
	}

	static Vraag getVraag(int vragenlijst, int vraag ) throws NullPointerException, IOException{
		try{
			Vraag[] vraagObj= (Vraag[]) getRow("vraag" , vragenlijst , Vraag.class); 
			return vraagObj[vraag];
		}catch(ClassCastException e){
			Debug.err(e.getMessage(), location + "-vraag");
			return null;
		}
	}

	static Rapport getRapport(int row) throws NullPointerException, IOException{
		try{
			return (Rapport) getRow("rapport", row,Rapport.class);
		}catch(ClassCastException e){
			Debug.err(e.getMessage(), location + "-rapport");
			return null;
		}
	}
	static Antwoord getAntwoord(int row)throws NullPointerException, IOException{
		try{
			return (Antwoord) getRow("antwoord", row,Antwoord.class);
		}catch(ClassCastException e){
			Debug.err(e.getMessage(), location + "-antwoord");
			return null;
		}
	}
}
