package net.finah.GUI;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.net.MalformedURLException;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;

import net.finah.API.API;
import net.finah.API.PatientVerzorger;

public class PatientPanel extends JFrame {
	private JLabel voornaam = new JLabel(" Voornaam: ");
	private JLabel achternaam = new JLabel(" Achternaam: ");
	private JLabel email = new JLabel(" Email: ");
	private JTextField tekstVoornaam = new JTextField(20);
	private JTextField tekstAchternaam = new JTextField(20);
	private JTextField tekstEmail = new JTextField(20);
	private JButton button = new JButton("Voeg patiënt toe");
	private String achternaamString, voornaamString, emailString;
	private PatientVerzorger patient = new PatientVerzorger();
	private ImageIcon icon;

	public PatientPanel() {
		super("Toevoegen Patiënt");

		icon = new ImageIcon("background.jpg");
		JPanel newPanel = new JPanel(new GridBagLayout()) {

			protected void paintComponent(Graphics g) {
				g.drawImage(icon.getImage(), 0, 0, this.getWidth(),this.getHeight(),this);
				super.paintComponent(g);
			}
		};
		newPanel.setOpaque(false);

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
	
		button.setBackground(Color.GREEN);
		button.setContentAreaFilled(false);
		button.setOpaque(true);
		button.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				achternaamString = tekstAchternaam.getText();
				voornaamString = tekstVoornaam.getText();
				emailString = tekstEmail.getText();
				validate(emailString);

				patient.setaNaam(achternaamString);
				patient.setvNaam(voornaamString);
				patient.setEmail(emailString);
				patient.setVerzorger(false);
				patient.setDokterId(1);

				try {
					API.writePatientMantelzorger(patient);
					HoofdPanel.refreshHoofdPanel();
					dispose();
				} catch (IOException e1) {
					e1.printStackTrace();
				}

				System.out.println(patient);
			}
		});
	}

	public void validate(String email) {
		int staart = email.indexOf("@");
		int punt = email.indexOf(".");
		if (!(email.contains("@") && email.contains("."))) {
			JFrame frame = new JFrame();

			JOptionPane.showMessageDialog(frame,
					"Gelieve een geldig emailadres in te geven",
					"Ongeldig emailadres", JOptionPane.WARNING_MESSAGE);
		} else if (!(email.contains("@") || email.contains("."))) {
			JFrame frame = new JFrame();

			JOptionPane.showMessageDialog(frame,
					"Gelieve een geldig emailadres in te geven",
					"Ongeldig emailadres", JOptionPane.WARNING_MESSAGE);
		} else if (email.length() < 8) {
			JFrame frame = new JFrame();

			JOptionPane.showMessageDialog(frame,
					"Gelieve een geldig emailadres in te geven",
					"Ongeldig emailadres", JOptionPane.WARNING_MESSAGE);

		} else if (punt == staart + 1) {
			JFrame frame = new JFrame();

			JOptionPane.showMessageDialog(frame,
					"Gelieve een geldig emailadres in te geven",
					"Ongeldig emailadres", JOptionPane.WARNING_MESSAGE);

		}
	}

}
