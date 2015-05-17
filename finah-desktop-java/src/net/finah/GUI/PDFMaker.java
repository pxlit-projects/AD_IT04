package net.finah.GUI;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

import net.finah.API.API;
import net.finah.API.Antwoord;

import org.apache.pdfbox.exceptions.COSVisitorException;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.edit.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

public class PDFMaker {
	public static void drawTable(PDPage page,
			PDPageContentStream contentStream, float y, float margin,
			String[][] content, int ID) throws IOException {
		final int rows = content.length;
		final int cols = content[0].length;
		final float rowHeight = 20f;
		final float tableWidth = page.findMediaBox().getWidth() - (2 * margin);
		final float tableHeight = rowHeight * rows;
		final float colWidth = tableWidth / (float) cols;
		final float cellMargin = 5f;

		// rijen
		float nexty = y;
		for (int i = 0; i <= rows; i++) {
			contentStream.drawLine(margin, nexty, margin + tableWidth, nexty);
			nexty -= rowHeight;
		}

		// kolommen
		float nextx = margin;
		for (int i = 0; i <= cols; i++) {
			contentStream.drawLine(nextx, y, nextx, y - tableHeight);
			nextx += colWidth;
		}

		// tekst toe te voegen
		String rapport = "Rapport " + ID;
		contentStream.setFont(PDType1Font.HELVETICA_BOLD, 25);
		contentStream.beginText();
		contentStream.moveTextPositionByAmount(250, 700);
		contentStream.drawString(rapport);
		contentStream.endText();
		float textx = margin + cellMargin;
		float texty = y - 15;
		for (int i = 0; i < content.length; i++) {
			for (int j = 0; j < content[i].length; j++) {
				String text = content[i][j];
				contentStream.setFont(PDType1Font.HELVETICA_BOLD, 12);
				contentStream.beginText();
				contentStream.moveTextPositionByAmount(textx, texty);
				contentStream.drawString(text);
				contentStream.endText();
				textx += colWidth;
			}
			texty -= rowHeight;
			textx = margin + cellMargin;
		}
	}

	public static void bekijkRapport(int ID) throws IOException,
			COSVisitorException {
		PDDocument doc = new PDDocument();
		PDPage page = new PDPage();
		doc.addPage(page);
		PDPageContentStream contentStream = new PDPageContentStream(doc, page);
		ArrayList<Antwoord> antwoorden = new ArrayList<Antwoord>();
		try {
			antwoorden = API.getAntwoordLijst(ID);
		} catch (FileNotFoundException e) {
			JFrame frame = new JFrame();

			JOptionPane.showMessageDialog(frame,
					"Dit is een leeg rapport",
					"Leeg rapport", JOptionPane.WARNING_MESSAGE);
		}

		int i = 1;
		int size = antwoorden.size();
		String[][] content = new String[size + 1][4];
		content[0][0] = " ID ";
		content[0][1] = " Vraag ID ";
		content[0][2] = " Antwoord ";
		content[0][3] = " Extra Vraag ";

		if (antwoorden.size() != 0) {
			for (Antwoord antwoord : antwoorden) {
				content[i][0] = antwoord.getId() + " ";
				content[i][1] = antwoord.getVraag_Id() + " ";
				content[i][2] = antwoord.getAntwoordInt() + " ";
				content[i][3] = antwoord.getAntwoordExtra() + " ";
				i++;

			}
		}
		drawTable(page, contentStream, 675, 100, content, ID);
		contentStream.close();
		doc.save("Rapport_" + ID + ".pdf");
	}
}