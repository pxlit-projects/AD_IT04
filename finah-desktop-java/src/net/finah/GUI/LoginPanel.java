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


public class LoginPanel extends JFrame {
	private JLabel gebruikersnaam = new JLabel("Gebruikersnaam: ");
    private JLabel wachtwoord = new JLabel("Wachtwoord: ");
    private JTextField tekstGebruiker = new JTextField(20);
    private JPasswordField tekstWachtwoord = new JPasswordField(20);
    private JButton loginButton = new JButton("Inloggen");

	public LoginPanel(){
		super("Inloggen");
		
		JPanel newPanel = new JPanel(new GridBagLayout());
        
        GridBagConstraints constraints = new GridBagConstraints();
        constraints.anchor = GridBagConstraints.WEST;
        constraints.insets = new Insets(10, 10, 10, 10);
         
        constraints.gridx = 0;
        constraints.gridy = 0;     
        newPanel.add(gebruikersnaam, constraints);
 
        constraints.gridx = 1;
        newPanel.add(tekstGebruiker, constraints);
         
        constraints.gridx = 0;
        constraints.gridy = 1;     
        newPanel.add(wachtwoord, constraints);
         
        constraints.gridx = 1;
        newPanel.add(tekstWachtwoord, constraints);
         
        constraints.gridx = 0;
        constraints.gridy = 2;
        constraints.gridwidth = 2;
        constraints.anchor = GridBagConstraints.CENTER;
        newPanel.add(loginButton, constraints);
         
        add(newPanel);
        setLocationRelativeTo(null);
		

	}

}
