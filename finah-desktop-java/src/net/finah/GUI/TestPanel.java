package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;
import javax.swing.table.DefaultTableModel;

import org.apache.pdfbox.exceptions.COSVisitorException;

import net.finah.API.API;
import net.finah.API.Antwoord;
import net.finah.API.Login;
import net.finah.API.PatientVerzorger;
import net.finah.API.Rapport;
import net.finah.Debug.Debug;

public class TestPanel extends JFrame {
	JTable patientTabel = new JTable();

	public TestPanel() throws IOException {
		JButton button = new JButton("Click");
		add(button, BorderLayout.NORTH);
		Object[] columnnames = { "Rapport ID", "Patient ID", "Verzoger ID",
				"Vragenlijst ID", "Datum" };
		ArrayList<PatientVerzorger> patientVerzorger = new ArrayList<PatientVerzorger>();
		ArrayList<Rapport> rapporten = new ArrayList<Rapport>();
		ArrayList<Antwoord> antwoorden = new ArrayList<Antwoord>();
		rapporten = API.getRapport();
		antwoorden = API.getAntwoordLijst(1);
		patientVerzorger = API.getPatientVerzoger();

		Object[][] object = new Object[100][100];
		int i = 0;
		if (rapporten.size() != 0) {
			for (Rapport rapport : rapporten) {
				object[i][0] = rapport.getId();
				object[i][1] = rapport.getPatientId();
				object[i][2] = rapport.getVerzorgerId();
				object[i][3] = rapport.getVragenlijstId();
				object[i][4] = rapport.getDate();
				i++;

			}

		}
		patientTabel = new JTable(object, columnnames);
		JScrollPane scrollPane = new JScrollPane(patientTabel);
		add(scrollPane, BorderLayout.CENTER);

		button.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				int rij = patientTabel.getSelectedRow();
				if (rij == -1) {
					JFrame frame = new JFrame(
							"JOptionPane showMessageDialog example");

					JOptionPane.showMessageDialog(frame,
							"Gelieve een rij te selecteren", "Ongeldige rij",
							JOptionPane.WARNING_MESSAGE);

				} else {
					if (patientTabel.getValueAt(rij, 0) == null) {
						JFrame frame = new JFrame(
								"JOptionPane showMessageDialog example");

						JOptionPane.showMessageDialog(frame,
								"Gelieve een geldige rij te selecteren",
								"Ongeldige rij", JOptionPane.WARNING_MESSAGE);
					} else {
						int id = Integer.parseInt(patientTabel.getValueAt(rij,
								0).toString());
						try {
							PDFMaker.bekijkRapport(id);
						} catch (IOException | COSVisitorException e1) {
							// TODO Auto-generated catch block
							e1.printStackTrace();

						}
					}
				}
			}
		});
	}

	public static void main(String[] args) throws IOException {
		API.init();

		try {
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		} catch (UnsupportedLookAndFeelException | ClassNotFoundException
				| InstantiationException | IllegalAccessException e) {
			Debug.log("Unable to change the UI to the system UI");
		}
		try {
			API.setURL("http://finahweb.azurewebsites.net/api/");
		} catch (Exception e) {
			Debug.err(e.getStackTrace().toString());
		}

		try {
			Login test = new Login("jan.schoefs@gmail.com", "P@ssw0rd");
			API.setLogin(test);
			API.login(new URL("http://finahweb.azurewebsites.net/account/login"));
		} catch (Exception e) {
			Debug.err("Could not insert 'cached' values: " + e.toString());
			e.printStackTrace();
		}

		TestPanel panel = new TestPanel();
		panel.setSize(800, 600);
		panel.setVisible(true);

	}

}
