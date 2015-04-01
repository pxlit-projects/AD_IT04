package net.azurewebsites.finahweb;
import java.io.*;
class main{
	public static void main(String args[]){
		API.setURL("http://finahweb.azurewebsites.net/api");
		String location = "main";
		System.out.println("Connected");
		Object response;
		for(int i = 0; i < 20; i++){
			try{
				response = API.getVraag(1,i);
				if(!response.equals(null)){
					Debug.log(response.toString(),location);
				}
			}catch(NullPointerException e){
				//System.out.println(e.getMessage());
			}catch(IOException e){
			}
			try{
				response = API.getRapport(i);
				if(!response.equals(null)){
					Debug.log(response.toString(),location);
				}
			}catch(NullPointerException e){
				//System.out.println(e.getMessage());
			}catch(IOException e){

			}
			try{
				response = API.getAntwoord(i);
				if( !response.equals(null)){
					Debug.log(response.toString(),location);
				}
			}catch(NullPointerException e){
				//System.out.println(e.getMessage());
			}catch(IOException e){
			}
		}
	}
}
