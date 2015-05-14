package net.finah.GUI;

import java.awt.BorderLayout;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;

public class VraagTonenPanel extends JFrame {
	 private JTable vraagToonTabel = new JTable(250,2){
     	public boolean isCellEditable(int row, int column) {                
             return false;               
     }
     };
     private JScrollPane vraagToonPane=new JScrollPane(vraagToonTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
     
	
	public VraagTonenPanel(){
		super("Vragenlijst tonen");
		
		 JPanel vraag = new JPanel();
		 vraagToonTabel.getColumnModel().getColumn(0).setHeaderValue("ID");
		 vraagToonTabel.getColumnModel().getColumn(1).setHeaderValue("Vraag");
		 vraagToonTabel.getColumnModel().getColumn(1).setPreferredWidth(500);
         vraag.add(vraagToonPane);
         add(vraag);
	}
	

	public static void main(String[] args) {
		VraagTonenPanel panel = new VraagTonenPanel();
		panel.setSize(600,500);
 		panel.setVisible(true);

	}

}
