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
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.table.TableCellRenderer;

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
        private JTable patientTabel = new JTable(250,3){
        	public boolean isCellEditable(int row, int column) {                
                return false;               
        }
        };
        /*
        private JTable rapportTabel = new JTable(250,5){
        	public boolean isCellEditable(int row, int column) {                
                return false;               
        }
        };
        */
        private JTable rapportTabel = new JTable(250,5);
        private JScrollPane patientPane=new JScrollPane(patientTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
        private JScrollPane rapportPane =new JScrollPane(rapportTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
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
             		login.setSize(400,200);
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
         		PDF.test(id);
         		//JOptionPane.showMessageDialog(null,rapportTabel.getModel().getValueAt(rij,4));
             }
        });
            
             
            JPanel jPaneC = new JPanel();
            JButton buttonExit = new JButton("Exit button on Tab C");
            buttonExit.addActionListener(new ActionListener(){

				@Override
				public void actionPerformed(ActionEvent e) {
					// TODO Auto-generated method stub
					
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