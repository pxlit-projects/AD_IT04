package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Font;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;

import net.finah.API.API;
import net.finah.API.Rapport;
import net.finah.API.Vraag;
import net.finah.API.Vragenlijst;

public class VraagTonenPanel extends JFrame {
	private JPanel panelVraag = new JPanel(new BorderLayout());
	private JPanel topPanelVraag = new JPanel(new FlowLayout(FlowLayout.CENTER));
	private JTable vraagTabel = new JTable();
	private JLabel labelVraag = new JLabel("Vragenlijst Tonen");

	public VraagTonenPanel() throws IOException {
		super("Vragenlijst tonen");

		Object[][] vragen = new Object[100][2];
		ArrayList<Vraag> vraagList = new ArrayList<Vraag>();
		vraagList = API.getVragenLijst(1);

		int i = 0;

		for (Vraag vraag : vraagList) {
			vragen[i][0] = vraag.getId();
			vragen[i][1] = vraag.getBeschrijving();
			i++;
		}

		Object[] column = { "ID", "Beschrijving" };

		vraagTabel = new JTable(vragen, column) {
			public boolean isCellEditable(int row, int column) {
				return false;
			}
		};
		vraagTabel.getColumnModel().getColumn(1).setPreferredWidth(800);
		labelVraag.setFont(labelVraag.getFont().deriveFont(
				Font.BOLD | Font.ITALIC, 18));
		topPanelVraag.add(labelVraag);
		panelVraag.add(topPanelVraag, BorderLayout.NORTH);

		JScrollPane scrollVraag = new JScrollPane(vraagTabel);
		panelVraag.add(scrollVraag, BorderLayout.CENTER);
		add(panelVraag);
	}

	public static void main(String[] args) throws IOException {
		API.setURL("http://finahweb.azurewebsites.net/api/");
		VraagTonenPanel panel = new VraagTonenPanel();
		panel.setSize(800, 600);
		panel.setVisible(true);
		panel.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

	}

}
