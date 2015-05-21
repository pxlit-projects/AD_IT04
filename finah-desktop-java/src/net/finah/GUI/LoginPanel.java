package net.finah.GUI;

import java.awt.Graphics;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.net.URL;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

import net.finah.API.API;
import net.finah.API.Login;
import net.finah.Debug.Debug;

public class LoginPanel extends JFrame {
	private JLabel gebruikersnaam = new JLabel("Gebruikersnaam: ");
	private JLabel wachtwoord = new JLabel("Wachtwoord: ");
	private JTextField tekstGebruiker = new JTextField(20);
	private JPasswordField tekstWachtwoord = new JPasswordField(20);
	private JButton loginButton = new JButton("Inloggen");
	private ImageIcon icon;

	public LoginPanel() {
		super("Inloggen");

		icon = new ImageIcon("src/background.jpg");
		JPanel newPanel = new JPanel(new GridBagLayout()) {

			protected void paintComponent(Graphics g) {
				g.drawImage(icon.getImage(), 0, 0, null);
				super.paintComponent(g);
			}
		};
		newPanel.setOpaque(false);

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

		try {
			tekstGebruiker.setText(API.getLogin().getEmail());
			tekstWachtwoord.setText(API.getLogin().getPassword());

		} catch (NullPointerException e) {
			Debug.log("geen login gegevens gevonden");
		}
		loginButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				API.init();
				API.setLogin(new Login(tekstGebruiker.getText(),
						tekstWachtwoord.getText()));
				Debug.log(API.getLogin().toString());

				try {
					API.login(new URL(
							"http://finahweb.azurewebsites.net/account/login"));
					if (API.getDokterID() != 0) {
						HoofdPanel.refreshHoofdPanel();
						dispose();
					} else {
						JFrame frame = new JFrame();

						JOptionPane
								.showMessageDialog(
										frame,
										"Gelieve een geldige gebruikersnaam & wachtwoord in te vullen",
										"Ongeldige login",
										JOptionPane.ERROR_MESSAGE);
					}
				} catch (Exception ex) {
					Debug.err("login request failed:" + ex.getMessage()); // ex.printStackTrace();

				}

			}
		});

	}

}
