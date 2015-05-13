package net.finah.GUI;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;

import org.apache.pdfbox.exceptions.COSVisitorException;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.edit.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDFont;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

public class PDF {
	public static void test(int ID) throws IOException {
	PDDocument document = new PDDocument();
	PDPage page = new PDPage();
	document.addPage( page );
	//document.load(new URL("http://finahweb.azurewebsites.net/api/antwoord/1"));

	

	// Create a new font object selecting one of the PDF base fonts
	PDFont font = PDType1Font.HELVETICA_BOLD;

	// Start a new content stream which will "hold" the to be created content
	PDPageContentStream contentStream;
	try {
		contentStream = new PDPageContentStream(document, page);
		
	
	

	// Define a text content stream using the selected font, moving the cursor and drawing the text "Hello World"
	contentStream.beginText();
	 contentStream.setFont( font, 40 );
	contentStream.moveTextPositionByAmount( 100, 700 );
	contentStream.drawString("");
	contentStream.endText();

	// Make sure that the content stream is closed:
	contentStream.close();

	// Save the results and ensure that the document is properly closed:
	document.save( "Hello World.pdf");
	document.close();
	} catch (IOException e1) {
		// TODO Auto-generated catch block
		e1.printStackTrace();
	} catch (COSVisitorException e1) {
		// TODO Auto-generated catch block
		e1.printStackTrace();
	}
}

}
