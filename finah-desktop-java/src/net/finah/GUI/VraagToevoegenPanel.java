package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextField;

import net.finah.API.API;
import net.finah.API.PatientVerzorger;
import net.finah.API.Vraag;
import net.finah.API.Vragenlijst;

public class VraagToevoegenPanel extends JFrame {
	private JLabel titel = new JLabel("Titel: ");
	private JTextField tekstTitel = new JTextField(25);
	private JButton button = new JButton("Voeg vraag toe");
	private JButton toevoegen = new JButton("Voeg vragenlijst toe");
	private static Integer indexer = 1;
	private static List<JLabel> listOfLabels = new ArrayList<JLabel>();
	private static List<JTextField> listOfTextFields = new ArrayList<JTextField>();
	private ArrayList<String> tekstVragen = new ArrayList<String>();
	private ArrayList<Vraag> vragen = new ArrayList<Vraag>();

	public VraagToevoegenPanel() {
		super("Toevoegen vragenlijst");
		JPanel newPanel = new JPanel(new GridBagLayout());
		JScrollPane pane = new JScrollPane(newPanel,
				JScrollPane.VERTICAL_SCROLLBAR_ALWAYS,
				JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
		JPanel panelMain = new JPanel(new BorderLayout());

		GridBagConstraints constraints = new GridBagConstraints();

		constraints.gridx = 0;
		constraints.gridy = 0;
		newPanel.add(titel, constraints);

		constraints.gridx = 1;
		newPanel.add(tekstTitel, constraints);

		constraints.gridx = 0;
		constraints.gridy = 1;
		constraints.gridwidth = 2;
		constraints.anchor = GridBagConstraints.CENTER;
		newPanel.add(button, constraints);

		button.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// newPanel.removeAll();

				// Create label and text field
				listOfTextFields.add(new JTextField(25));
				listOfLabels.add(new JLabel("Vraag " + indexer + ": "));

				// Create constraints
				GridBagConstraints textFieldConstraints = new GridBagConstraints();
				GridBagConstraints labelConstraints = new GridBagConstraints();

				// Add labels and text fields
				for (int i = 0; i < indexer; i++) {
					// Text field constraints
					textFieldConstraints.gridx = 1;
					textFieldConstraints.gridy = i + 1;
					textFieldConstraints.insets = new Insets(10, 10, 10, 10);

					// Label constraints
					labelConstraints.gridx = 0;
					labelConstraints.gridy = i + 1;

					// Add them to panel
					newPanel.add(listOfLabels.get(i), labelConstraints);
					newPanel.add(listOfTextFields.get(i), textFieldConstraints);
				}

				// button
				constraints.gridx = 0;
				constraints.gridy = indexer + 1;
				constraints.gridwidth = 2;
				constraints.anchor = GridBagConstraints.CENTER;
				newPanel.add(button, constraints);

				// toevoegen
				constraints.gridx = 0;
				constraints.gridy = indexer + 2;
				constraints.gridwidth = 2;
				constraints.anchor = GridBagConstraints.CENTER;
				constraints.insets = new Insets(10, 10, 10, 10);
				newPanel.add(toevoegen, constraints);

				// Increment indexer
				indexer++;
				revalidate();
				repaint();
			}

		});
		panelMain.add(pane, BorderLayout.CENTER);
		add(panelMain);

		toevoegen.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				int i = 1;

				for (JTextField field : listOfTextFields) {
					tekstVragen.add(field.getText());
				}

				for (String tekst : tekstVragen) {
					Vraag vraag = new Vraag();
					vraag.setId(i);
					vraag.setBeschrijving(tekst);
					vraag.setVragenLijst_Id(99);
					vragen.add(vraag);
					i++;
				}
				System.out.println(vragen);

			}
		});
	}
}
