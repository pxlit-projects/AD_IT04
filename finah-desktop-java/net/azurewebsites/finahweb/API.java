package net.azurewebsites.finahweb;
import java.net.*;
import java.io.*;
import com.google.gson.*;

class API{
	static String url;


	public static void setURL(String newURL){
		try{
			URL urlTest = new URL(newURL);
			url = newURL;
		}catch(MalformedURLException e){
			Debug.err("Error:" + e);
		}
	}

	private static Object getRow(String table, int row, Class<?> c ) throws NullPointerException, IOException{
		try{
			String temp = url + "/" + table + "/" + row;
			URL Url = new URL(temp);
			HttpURLConnection conn = (HttpURLConnection) Url.openConnection();
			Debug.log(Url.toString());
			conn.setRequestMethod("GET");
			conn.connect();
			Debug.log(conn.getResponseCode() + "");
			if(conn.getResponseCode() == 200){
				BufferedInputStream reader = new BufferedInputStream(conn.getInputStream());
				StringBuilder stringBuilder = new StringBuilder();
				int chr;
				while ((chr = reader.read()) != -1){
					stringBuilder.append((char)chr);
				}
				String json = stringBuilder.toString();
				Debug.log(json);
				Gson gson = new Gson();
				return gson.fromJson(json, c);
			}else{
				Debug.err("Could not connect:" + conn.getResponseCode() + ":" + conn.getResponseMessage());
				throw new IOException("Response:" + conn.getResponseCode());
			}

		}catch(JsonSyntaxException e){
			Debug.err( e.toString() );
			return null;
		}
	}

	static Vraag getVraag(int row) throws NullPointerException, IOException{
		return (Vraag)getRow("vraag", row, Vraag.class);
	}

	static Rapport getRapport(int row) throws NullPointerException, IOException{
		return (Rapport)getRow("rapport", row,Rapport.class);
	}
	static Antwoord getAntwoord(int row)throws NullPointerException, IOException{
		return (Antwoord)getRow("antwoord", row,Antwoord.class);
	}
}
