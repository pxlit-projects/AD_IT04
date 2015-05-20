package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
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
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableCellRenderer;
import javax.swing.table.TableModel;

import org.apache.pdfbox.exceptions.COSVisitorException;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.edit.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDFont;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

import net.finah.API.API;
import net.finah.API.Login;
import net.finah.API.PatientVerzorger;
import net.finah.Debug.*;

public class JavaJFrameApplication {

	public class MyTabJPanel extends JPanel {
		private JTabbedPane jTabbedPane = new JTabbedPane();
		private JMenuBar menuBar = new JMenuBar();
		private JMenu fileMenu = new JMenu("Login");
		private JMenuItem inloggen = new JMenuItem("Inloggen");
		private JMenuItem uitloggen = new JMenuItem("Uitloggen");
		private DefaultTableModel model = new DefaultTableModel();
		private JTable patientTabel = new JTable(model) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};

		private JTable mantelzorgerTabel = new JTable(250, 3) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};
		private JTable rapportTabel = new JTable(250, 5) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};

		private JTable vraagTabel = new JTable(250, 2) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};

		private JScrollPane patientPane = new JScrollPane(patientTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);

		private JScrollPane rapportPane = new JScrollPane(rapportTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
		private JScrollPane vraagPane = new JScrollPane(vraagTabel, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
		private JButton jButton = new JButton("Voeg patient toe");
		private JButton button = new JButton("Test");

		public MyTabJPanel() {
			super(new BorderLayout());

			LoginPanel login = new LoginPanel();

			inloggen.addActionListener(new ActionListener() {
				@Override
				public void actionPerformed(ActionEvent e) {
					login.setSize(400, 300);
					login.setVisible(true);
				}
			});

			JPanel jPaneA = new JPanel();
			JLabel label = new JLabel("Title ");
			label.setFont(label.getFont().deriveFont(Font.BOLD | Font.ITALIC, 18));
			JPanel topPanel = new JPanel(new FlowLayout(FlowLayout.CENTER));
			topPanel.add(label);

			JButton button = new JButton("Log In");
			JPanel bottomPanel = new JPanel(new FlowLayout(FlowLayout.RIGHT));
			bottomPanel.add(button);
			jPaneA.add(bottomPanel, BorderLayout.NORTH);
			jPaneA.add(topPanel, BorderLayout.SOUTH);

			JPanel jPaneB = new JPanel();
			rapportTabel.getColumnModel().getColumn(0).setHeaderValue("Patient");
			rapportTabel.getColumnModel().getColumn(1).setHeaderValue("Mantelzorger");
			rapportTabel.getColumnModel().getColumn(2).setHeaderValue("Vragenlijst");
			rapportTabel.getColumnModel().getColumn(3).setHeaderValue("Datum");
			jPaneB.add(rapportPane);
			jPaneB.add(button);

			JPanel jPaneC = new JPanel();
			vraagTabel.getColumnModel().getColumn(0).setHeaderValue("Beschrijving");
			jPaneC.add(vraagPane);

			menuBar.add(fileMenu);
			fileMenu.add(inloggen);
			fileMenu.add(uitloggen);

			jTabbedPane.addTab("Patiënt", jPaneA);
			jTabbedPane.addTab("Rapport", jPaneB);
			jTabbedPane.addTab("Vragenlijst", jPaneC);

			add(menuBar, BorderLayout.NORTH);
			add(jTabbedPane, BorderLayout.CENTER);
		}
	}

	public static void main(String[] args) {

		API.init();

		try {
			UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
		} catch (UnsupportedLookAndFeelException | ClassNotFoundException | InstantiationException | IllegalAccessException e) {
			Debug.log("Unable to change the UI to the system UI");
		}
		try {
			API.setURL("http://finahweb.azurewebsites.net/api/");
		} catch (Exception e) {
			Debug.err(e.getStackTrace().toString());
		}

		// TODO: fix set limit of 50
		Object[][] rowdata = new Object[50][3];
		try {
			Debug.log("Patienten inladen");
			ArrayList<PatientVerzorger> list = API.getPatientVerzoger();
			int i = 0;
			for (PatientVerzorger patientVerzorger : list) {
				if (patientVerzorger.isPatient()) {
					Debug.log("is een patient, voeg toe");
					rowdata[i][0] = patientVerzorger.getVNaam();
					rowdata[i][1] = patientVerzorger.getANaam();
					rowdata[i][2] = patientVerzorger.getemail();

					i++;
				} else {
					Debug.log("is een verzorger");
				}
			}
			Debug.log("Klaar met laden van patienten");
		} catch (IOException e2) {
			Debug.log(" patienten: " + e2.getMessage());
		}

		Object[] columnnames = { "Voornaam", "achternaam", "email" };

		// dit is een static function dus we kunnen niet aan die andere
		// variables?
		// patientTabel = new JTable(rowdata,columnnames);

		JFrame mainJFrame = new JFrame();
		mainJFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		mainJFrame.setTitle("test");
		mainJFrame.setSize(800, 600);
		/*
		 * MyTabJPanel myTabJPanel = new MyTabJPanel();
		 * mainJFrame.add(myTabJPanel); mainJFrame.setVisible(true);
		 */
		try {
			Login test = new Login("jan.schoefs@gmail.com", "P@ssw0rd");
			API.setLogin(test);
			API.login(new URL("http://finahweb.azurewebsites.net/account/login"));
		} catch (Exception e) {
			Debug.err("Could not insert 'cached' values: " + e.toString());
			e.printStackTrace();
		}

	}
}
