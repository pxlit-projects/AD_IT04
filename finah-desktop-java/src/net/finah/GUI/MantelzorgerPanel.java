package net.finah.GUI;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;


public class MantelzorgerPanel extends JFrame {
	private JLabel voornaam = new JLabel("Voornaam: ");
    private JLabel achternaam = new JLabel("Achternaam: ");
    private JLabel email = new JLabel("Email: ");
    private JTextField tekstVoornaam = new JTextField(20);
    private JTextField tekstAchternaam = new JTextField(20);
    private JTextField tekstEmail = new JTextField(20);
    private JButton button = new JButton("Voeg mantelzorger toe");
    
    public MantelzorgerPanel(){
		super("Toevoegen Mantelzorger");
		
		JPanel newPanel = new JPanel(new GridBagLayout());
        
        GridBagConstraints constraints = new GridBagConstraints();
        constraints.anchor = GridBagConstraints.WEST;
        constraints.insets = new Insets(10, 10, 10, 10);
        
        constraints.gridx = 0;
        constraints.gridy = 0; 
        newPanel.add(voornaam, constraints);
 
        constraints.gridx = 1;
        newPanel.add(tekstVoornaam, constraints);
         
        constraints.gridx = 0;
        constraints.gridy = 1;     
        newPanel.add(achternaam, constraints);
         
        constraints.gridx = 1;
        newPanel.add(tekstAchternaam, constraints);
        
        constraints.gridx = 0;
        constraints.gridy = 2;     
        newPanel.add(email, constraints);
        
        constraints.gridx = 1;
        newPanel.add(tekstEmail, constraints);
         
        constraints.gridx = 0;
        constraints.gridy = 3;
        constraints.gridwidth = 2;
        constraints.anchor = GridBagConstraints.CENTER;
        newPanel.add(button, constraints);
        
        add(newPanel);
        setLocationRelativeTo(null);
    }


	public static void main(String[] args) {
		MantelzorgerPanel panel = new MantelzorgerPanel();
		panel.setSize(400,300);
 		panel.setVisible(true);
		

	}

}
