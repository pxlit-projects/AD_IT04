package net.finah.Debug;

import java.io.*;

public class Debug {

	/**
	 * Log a thing to a specific file
	 * @param message The message to send
	 * @param location The location of where the log must originate from
	 */
	public static void log(String message, String location){
		writer(message, location, "log");
	}

	/**
	 * Log to the stdinfo log
	 * @param message The message to log
	 */
	public static void log(String message){
		write(message, "stdinfo");
	}

	/**
	 * Log an error from a specific location
	 * @param message The message of the error
	 * @param location The location of the error
	 */
	public static void err(String message, String location){
		writer(message, location, "err");

	}

	/**
	 * Log an error to stderr
	 * @param message The message to log
	 */
	public static void err(String message){
		write(message, "stderr");
	}

	/**
	 * Internal overide to ignore an extension, if needed
	 * @param message
	 * @param location
	 */
	public static void write(String message, String location){
		writer(message, location, "");
	}

	/**
	 * Writer
	 * @param message the message
	 * @param location the filename
	 * @param ext the extension, if an empty string, is ignored.
	 */
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
		if(ext != ""){
			location += "."+ ext;
		}
		//File file =new File(location);
		try{
			PrintWriter out = new PrintWriter(new BufferedWriter(new FileWriter(location , true)));
			out.println(message);
			out.close();
		}catch (IOException e) {
			// this is going to end up badly
			// TODO: fix this possible loophole
			err("crashing hard");
		}
	}
}
