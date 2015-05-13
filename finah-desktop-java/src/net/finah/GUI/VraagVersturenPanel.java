package net.finah.GUI;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;


public class VraagVersturenPanel extends JFrame {
	private String patienten[] = {"Patient 1","Patient 2","Patient 3"};
	private String mantelzorgers[] = {"Mantelzorger 1","Mantelzorger 2","Mantelzorger 3"};
	private String vragenlijsten[] = {"Vragenlijst 1","Vragenlijst 2","Vragenlijst 3"};
	private JLabel patient = new JLabel("Patiënt: ");
    private JLabel mantelzorger= new JLabel("Mantelzorger: ");
    private JLabel vragenlijst = new JLabel("Vragenlijst: ");
	private JComboBox tekstPatient = new JComboBox(patienten);
	private JComboBox tekstMantelzorger = new JComboBox(mantelzorgers);
	private JComboBox tekstVragenlijst = new JComboBox(vragenlijsten);
	private JButton button = new JButton("Verstuur vragenlijst");
	
	public VraagVersturenPanel (){
		super("Vragenlijst versturen");
		
JPanel newPanel = new JPanel(new GridBagLayout());
        
        GridBagConstraints constraints = new GridBagConstraints();
        constraints.anchor = GridBagConstraints.WEST;
        constraints.insets = new Insets(10, 10, 10, 10);
        
        constraints.gridx = 0;
        constraints.gridy = 0; 
        newPanel.add(patient, constraints);
 
        constraints.gridx = 1;
        newPanel.add(tekstPatient, constraints);
         
        constraints.gridx = 0;
        constraints.gridy = 1;     
        newPanel.add(mantelzorger, constraints);
         
        constraints.gridx = 1;
        newPanel.add(tekstMantelzorger, constraints);
        
        constraints.gridx = 0;
        constraints.gridy = 2;     
        newPanel.add(vragenlijst, constraints);
        
        constraints.gridx = 1;
        newPanel.add(tekstVragenlijst, constraints);
         
        constraints.gridx = 0;
        constraints.gridy = 3;
        constraints.gridwidth = 2;
        constraints.anchor = GridBagConstraints.CENTER;
        newPanel.add(button, constraints);
        
        add(newPanel);
        setLocationRelativeTo(null);
	}

	public static void main(String[] args) {
		VraagVersturenPanel panel = new VraagVersturenPanel();
		panel.setSize(400,300);
 		panel.setVisible(true);
		

	}

}
