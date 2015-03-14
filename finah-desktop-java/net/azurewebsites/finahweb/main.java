package net.azurewebsites.finahweb;
import java.io.*;
class main{
	public static void main(String args[]){
		API.setURL("http://finahweb.azurewebsites.net/api");
		System.out.println("Connected");
		Object response;
		for(int i = 0; i < 80; i++){
			try{
				response = API.getVraag(i);
				if(!response.equals(null)){
					System.out.println(response.toString());
				}
			}catch(NullPointerException e){
				System.out.println("Geen vraag");
			}catch(IOException e){
			}
			try{
				response = API.getRapport(i);
				if(!response.equals(null)){
					System.out.println(response);
				}
			}catch(NullPointerException e){
				System.out.println("Geen rapport");
			}catch(IOException e){

			}
			try{
				response = API.getAntwoord(i);
				if( !response.equals(null)){
					System.out.println(response);
				}
			}catch(NullPointerException e){
				System.out.println("Geen Antwoord");
			}catch(IOException e){
			}
		}
	}
}
