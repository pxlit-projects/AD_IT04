package net.finah.Debug;

import java.io.*;

public class Debug {
	public static void main(String args[]){
		err("Log test", "debug-main");
	}

	public static void log(String message, String location){
		writer(message, location, "log");
	}

	public static void log(String message){
		log(message, "undefined");
	}

	public static void err(String message, String location){
		writer(message, location, "err");

	}

	public static void err(String message){
		err(message, "undefined");
	}

	private static void writer(String message, String location, String ext){
		File logDir = new File("log");
		if(!logDir.exists()){
			logDir.mkdir();
		}else{
			if(!logDir.isDirectory()){
				logDir.renameTo(new File("log~"));
				File actualLogDir = new File("log");
				actualLogDir.mkdir();
			}
		}
		location = "log/" + location;
		//File file =new File(location);
		try{
			PrintWriter out = new PrintWriter(new BufferedWriter(new FileWriter(location + "."  + ext, true)));
			out.println(message);
			out.close();
		}catch (IOException e) {
			err("crashing hard");
		}
	}
}
