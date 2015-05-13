package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.Arrays;
import java.util.Vector;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;

import org.apache.pdfbox.exceptions.COSVisitorException;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.edit.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDFont;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

public class JavaJFrameApplication {
     
    static public class MyTabJPanel extends JPanel {
    	private JTabbedPane jTabbedPane = new JTabbedPane();
        private JMenuBar menuBar = new JMenuBar();
        private JMenu fileMenu = new JMenu("Login");
        private JMenuItem inloggen = new JMenuItem("Inloggen");
        private JMenuItem uitloggen = new JMenuItem("Uitloggen");
        private JTable patientTabel = new JTable(250,3);
        private JTable rapportTabel = new JTable(250,5);
        private JScrollPane patientPane=new JScrollPane(patientTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
        private JScrollPane rapportPane =new JScrollPane(rapportTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
        private JButton jButton = new JButton("Voeg patient toe");
        
        public MyTabJPanel(){
            super(new BorderLayout());
            LoginPanel login = new LoginPanel();
            
           
           
            
            JPanel jPaneA = new JPanel();
            patientTabel.getColumnModel().getColumn(0).setHeaderValue("Voornaam");
            patientTabel.getColumnModel().getColumn(1).setHeaderValue("Achternaam");
            patientTabel.getColumnModel().getColumn(2).setHeaderValue("Email");
            jPaneA.add(patientPane);
            jPaneA.add(jButton);
            inloggen.addActionListener(new ActionListener(){
            	 @Override
                 public void actionPerformed(ActionEvent e) {
             		login.setSize(400,200);
             		login.setVisible(true);
                 }
            });
            
             
            JPanel jPaneB = new JPanel();
            jPaneB.add(rapportPane);
            rapportTabel.getColumnModel().getColumn(0).setHeaderValue("Patient");
            rapportTabel.getColumnModel().getColumn(1).setHeaderValue("Mantelzorger");
            rapportTabel.getColumnModel().getColumn(2).setHeaderValue("Vragenlijst");
            rapportTabel.getColumnModel().getColumn(3).setHeaderValue("Datum");
            rapportTabel.getColumnModel().getColumn(4).setHeaderValue("Bekijken");
             
            JPanel jPaneC = new JPanel();
            JButton buttonExit = new JButton("Exit button on Tab C");
            buttonExit.addActionListener(new ActionListener(){
 
                @Override
                public void actionPerformed(ActionEvent e) {
                	PDDocument document = new PDDocument();
                	PDPage page = new PDPage();
                	document.addPage( page );

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
                	contentStream.drawString( "Hello World" );
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
 
            });
            
            menuBar.add(fileMenu);
            fileMenu.add(inloggen);
            fileMenu.add(uitloggen);
            jPaneC.add(buttonExit);
             
            jTabbedPane.addTab("Tab A", jPaneA);
            jTabbedPane.addTab("Tab B", jPaneB);
            jTabbedPane.addTab("Tab C", jPaneC);
             
            add(menuBar,BorderLayout.NORTH);
            add(jTabbedPane,BorderLayout.CENTER);
            
            
        }
         
    }
     
    public static void main(String[] args) {
         
    
          
                JFrame mainJFrame = new JFrame();
                mainJFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                mainJFrame.setTitle("test");
                mainJFrame.setSize(600, 700);
 
                MyTabJPanel myTabJPanel = new MyTabJPanel();
                mainJFrame.add(myTabJPanel);
                mainJFrame.setVisible(true);
            
        
    }
}