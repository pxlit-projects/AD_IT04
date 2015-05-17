package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Font;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;

import net.finah.API.API;
import net.finah.API.PatientVerzorger;
import net.finah.API.Rapport;

public class HoofdPanel extends JFrame {
	// Algemeen
	private JTabbedPane jTabbedPane = new JTabbedPane();
	private JMenuBar menuBar = new JMenuBar();
	private JMenu fileMenu = new JMenu("Login");
	private JMenuItem inloggen = new JMenuItem("Inloggen");
	private JMenuItem uitloggen = new JMenuItem("Uitloggen");

	// Variabelen Panel voor Patient
	private JPanel panelPatient = new JPanel(new BorderLayout());
	private JPanel topPanelPatient = new JPanel(new FlowLayout(
			FlowLayout.CENTER));
	private JPanel bottomPanelPatient = new JPanel(new FlowLayout(
			FlowLayout.CENTER));
	private JTable patientTabel = new JTable();
	private JLabel labelPatient = new JLabel("Patiënten");
	private JButton buttonPatient = new JButton("Voeg patiënt toe");

	// Variabelen Panel voor Mantelzorger
	private JPanel panelRapport = new JPanel(new BorderLayout());
	private JPanel topPanelRapport = new JPanel(new FlowLayout(
			FlowLayout.CENTER));
	private JPanel bottomPanelRapport = new JPanel(new FlowLayout(
			FlowLayout.CENTER));
	private JTable rapportTabel = new JTable();
	private JLabel labelRapport = new JLabel("Rapporten");
	private JButton buttonRapport = new JButton("Download rapport");

	// Variabelen Panel voor Rapport
	private JPanel panelZorger = new JPanel(new BorderLayout());
	private JPanel topPanelZorger = new JPanel(
			new FlowLayout(FlowLayout.CENTER));
	private JPanel bottomPanelZorger = new JPanel(new FlowLayout(
			FlowLayout.CENTER));
	private JTable zorgerTabel = new JTable();
	private JLabel labelZorger = new JLabel("Mantelzorgers");
	private JButton buttonZorger = new JButton("Voeg mantelzorger toe");

	public HoofdPanel() throws IOException {

		Object[][] patienten = new Object[100][3];
		Object[][] mantelzorgers = new Object[100][3];
		Object[][] rapporten = new Object[100][100];
		ArrayList<PatientVerzorger> patientList = new ArrayList<PatientVerzorger>();
		patientList = API.getPatientVerzoger();
		ArrayList<Rapport> rapportList = new ArrayList<Rapport>();
		rapportList = API.getRapport();

		int i = 0;
		int j = 0;
		int k = 0;

		for (PatientVerzorger patientVerzorger : patientList) {
			if (patientVerzorger.isPatient()) {
				patienten[i][0] = patientVerzorger.getVNaam();
				patienten[i][1] = patientVerzorger.getANaam();
				patienten[i][2] = patientVerzorger.getemail();
				i++;
			} else {
				mantelzorgers[j][0] = patientVerzorger.getVNaam();
				mantelzorgers[j][1] = patientVerzorger.getANaam();
				mantelzorgers[j][2] = patientVerzorger.getemail();
				j++;
			}
		}

		for (Rapport rapport : rapportList) {
			rapporten[k][0] = rapport.getId();
			rapporten[k][1] = rapport.getPatientId();
			rapporten[k][2] = rapport.getVerzorgerId();
			rapporten[k][3] = rapport.getVragenlijstId();
			rapporten[k][4] = rapport.getDate();
			k++;
		}

		Object[] column = { "Voornaam", "Achternaam", "Email" };
		Object[] columnRapport = { "Rapport ID", "Patient ID", "Verzoger ID",
				"Vragenlijst ID", "Datum" };

		// Panel voor Patiënten
		patientTabel = new JTable(patienten, column) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};
		labelPatient.setFont(labelPatient.getFont().deriveFont(
				Font.BOLD | Font.ITALIC, 18));
		topPanelPatient.add(labelPatient);
		bottomPanelPatient.add(buttonPatient);
		panelPatient.add(bottomPanelPatient, BorderLayout.SOUTH);
		panelPatient.add(topPanelPatient, BorderLayout.NORTH);

		JScrollPane scrollPatient = new JScrollPane(patientTabel);
		panelPatient.add(scrollPatient, BorderLayout.CENTER);

		// Panel voor Mantelzorgers
		zorgerTabel = new JTable(mantelzorgers, column) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};
		labelZorger.setFont(labelZorger.getFont().deriveFont(
				Font.BOLD | Font.ITALIC, 18));
		topPanelZorger.add(labelZorger);
		bottomPanelZorger.add(buttonZorger);
		panelZorger.add(bottomPanelZorger, BorderLayout.SOUTH);
		panelZorger.add(topPanelZorger, BorderLayout.NORTH);

		JScrollPane scrollZorger = new JScrollPane(zorgerTabel);
		panelZorger.add(scrollZorger, BorderLayout.CENTER);

		// Panel voor Rapporten
		rapportTabel = new JTable(rapporten, columnRapport) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};
		labelRapport.setFont(labelRapport.getFont().deriveFont(
				Font.BOLD | Font.ITALIC, 18));
		topPanelRapport.add(labelRapport);
		bottomPanelRapport.add(buttonRapport);
		panelRapport.add(bottomPanelRapport, BorderLayout.SOUTH);
		panelRapport.add(topPanelRapport, BorderLayout.NORTH);

		JScrollPane scrollRapport = new JScrollPane(rapportTabel);
		panelRapport.add(scrollRapport, BorderLayout.CENTER);

		// Algemeen
		menuBar.add(fileMenu);
		fileMenu.add(inloggen);
		fileMenu.add(uitloggen);

		jTabbedPane.addTab("Patiënt", panelPatient);
		jTabbedPane.addTab("Mantelzorger", panelZorger);
		jTabbedPane.addTab("Rapport", panelRapport);
		add(menuBar, BorderLayout.NORTH);
		add(jTabbedPane, BorderLayout.CENTER);
	}

	public static void main(String[] args) throws IOException {
		API.setURL("http://finahweb.azurewebsites.net/api/");
		HoofdPanel panel = new HoofdPanel();
		panel.setSize(800, 600);
		panel.setVisible(true);
		panel.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

	}

}
