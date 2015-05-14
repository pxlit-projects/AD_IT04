package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.Arrays;
import java.util.Vector;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;
import javax.swing.table.TableCellRenderer;

import org.apache.pdfbox.exceptions.COSVisitorException;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.edit.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDFont;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

import net.finah.API.API;
import net.finah.API.Login;
import net.finah.Debug.*;

public class JavaJFrameApplication {
     
    static public class MyTabJPanel extends JPanel {
    	private JTabbedPane jTabbedPane = new JTabbedPane();
        private JMenuBar menuBar = new JMenuBar();
        private JMenu fileMenu = new JMenu("Login");
        private JMenuItem inloggen = new JMenuItem("Inloggen");
        private JMenuItem uitloggen = new JMenuItem("Uitloggen");
        private JTable patientTabel = new JTable(250,3){
        	public boolean isCellEditable(int row, int column) {                
                return false;               
        }
        };
        private JTable rapportTabel = new JTable(250,5){
        	public boolean isCellEditable(int row, int column) {                
                return false;               
        }
        };
        
        private JTable vraagTabel = new JTable(250,2){
        	public boolean isCellEditable(int row, int column) {                
                return false;               
        }
        };
        
        private JScrollPane patientPane=new JScrollPane(patientTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
        private JScrollPane rapportPane =new JScrollPane(rapportTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
        private JScrollPane vraagPane=new JScrollPane(vraagTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
        private JButton jButton = new JButton("Voeg patient toe");
        private JButton button = new JButton("Test");
        
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
             		login.setSize(400,300);
             		login.setVisible(true);
                 }
            });
            
             
            JPanel jPaneB = new JPanel();
            rapportTabel.getColumnModel().getColumn(0).setHeaderValue("Patient");
            rapportTabel.getColumnModel().getColumn(1).setHeaderValue("Mantelzorger");
            rapportTabel.getColumnModel().getColumn(2).setHeaderValue("Vragenlijst");
            rapportTabel.getColumnModel().getColumn(3).setHeaderValue("Datum");
            rapportTabel.getColumnModel().getColumn(4).setHeaderValue("ID");
            jPaneB.add(rapportPane);
            jPaneB.add(button);
            button.addActionListener(new ActionListener(){
           	 @Override
             public void actionPerformed(ActionEvent e) {
         		int rij = rapportTabel.getSelectedRow();
         		int id= Integer.parseInt( rapportTabel.getValueAt(rij, 4).toString());
				try {
					PDF.test(id);
				} catch (IOException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}
				
         		//JOptionPane.showMessageDialog(null,rapportTabel.getModel().getValueAt(rij,4));
             }
        });
            
             
            JPanel jPaneC = new JPanel();
            vraagTabel.getColumnModel().getColumn(0).setHeaderValue("Vragenlijst");
            vraagTabel.getColumnModel().getColumn(1).setHeaderValue("ID");
            jPaneC.add(vraagPane);
            
            menuBar.add(fileMenu);
            fileMenu.add(inloggen);
            fileMenu.add(uitloggen);
           
             
            jTabbedPane.addTab("Patiënt", jPaneA);
            jTabbedPane.addTab("Rapport", jPaneB);
            jTabbedPane.addTab("Vragenlijst", jPaneC);
             
            add(menuBar,BorderLayout.NORTH);
            add(jTabbedPane,BorderLayout.CENTER);
     
            
        }
         
    }
     
    public static void main(String[] args) {
         
    
		try {
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		} 
		catch (UnsupportedLookAndFeelException | ClassNotFoundException | InstantiationException | IllegalAccessException e) {
			Debug.log("Unable to change the UI to the system UI");
		}
          
                JFrame mainJFrame = new JFrame();
                mainJFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
                mainJFrame.setTitle("test");
                mainJFrame.setSize(800, 600);
 
                MyTabJPanel myTabJPanel = new MyTabJPanel();
                mainJFrame.add(myTabJPanel);
                mainJFrame.setVisible(true);
		try {
			API.setURL("http://finahweb.azurewebsites.net/api/");
		} catch (Exception e) {
			Debug.err(e.getStackTrace().toString());
		}

		try{
			Login test = new Login("jan.schoefs@gmail.com","P@ssw0rd"); 
			API.setLogin(test);
			API.login(new URL("http://finahweb.azurewebsites.net/account/login"));
		}catch(Exception e){
			Debug.err("Could not insert 'cached' values: " +e.toString());
			e.printStackTrace();
		}

    }
}
