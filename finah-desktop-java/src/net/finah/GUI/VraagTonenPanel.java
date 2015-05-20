package net.finah.GUI;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.GridBagLayout;
import java.awt.event.ActionListener;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
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
	private JLabel labelVraag = new JLabel(" Vragenlijst Tonen ");

	public VraagTonenPanel(int ID) throws IOException {
		super("Vragenlijst tonen");

		Object[][] vragen = new Object[100][2];
		ArrayList<Vraag> vraagList = new ArrayList<Vraag>();
		try {
			vraagList = API.getVragenLijst(ID);
		} catch (FileNotFoundException e) {
			JFrame frame = new JFrame();

			JOptionPane.showMessageDialog(frame,
					"Deze vragenlijst bevat geen vragen", "Lege vragenlijst",
					JOptionPane.WARNING_MESSAGE);
		}

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

}
