package MVC.Views;

import java.awt.GridBagConstraints;
import java.util.ArrayList;
import java.util.List;
import java.awt.BorderLayout;
import java.awt.Component;
import java.awt.Font;

import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JPanel;

public class Panel extends JFrame {
	private static final long serialVersionUID = 1L;
	private int width, height, btnGridX = 0;
	private String[][] btnTitles; // {{names},{titles}}
	private String[] outPutTitles; // {titles}
	private JFrame window;
	private JTextField outPut;
	private JButton btn;
	private JPanel displayPanel = new JPanel(), buttonsPanel = new JPanel();
	private GridBagConstraints displayGrid = new GridBagConstraints(), buttonsGrid = new GridBagConstraints();

	public Panel(final String title, final int width, final int height) {
		this.window = new JFrame(title);
		this.width = width;
		this.height = height;
		this.displayPanel.setLayout(new java.awt.FlowLayout());
		this.buttonsPanel.setLayout(new java.awt.GridLayout(5, 4, 5, 5));
	}

	public void setBtnTitles(final String[][] titles) {
		this.btnTitles = titles;
	}

	public void setOutPutAmount(final String[] amount) {
		this.outPutTitles = amount;
	}

	public void setOutPutColumn(final int colunm) {
		this.outPut.setColumns(colunm);
	}

	public void setOutPutSize(final int width, final int height) {
		this.outPut.setSize(width, height);
	}

	public void setBtnGridX() {
		this.btnGridX = this.btnGridX + 1;
	}

	public void setDisplayGrid() {
		this.displayGrid.fill = GridBagConstraints.HORIZONTAL;
		this.displayGrid.weightx = 0.0;
		this.displayGrid.weighty = 1.0;
	}

	public void setDisplayText(String text) {
		this.outPut.setText(text);
	}

	public String[][] getBtnTitles() {
		return this.btnTitles;
	}

	public String[] getOutPutAmount() {
		return this.outPutTitles;
	}

	public int getBtnGridX() {
		return this.btnGridX;
	}

	public GridBagConstraints getBtnGrid() {
		return this.buttonsGrid;
	}

	public List<JButton> getAllButtons() {
		List<JButton> list = new ArrayList<>();
		for (Component component : buttonsPanel.getComponents()) {
			if (component instanceof JButton button) {
				list.add(button);
			}
		}

		return list;
	}

	public void buildBtn() {
		String[][] btnTitles = getBtnTitles();

		for (int i = 0; i <= btnTitles[0].length - 1; i++) {
			this.btn = new JButton(btnTitles[1][i]);
			this.btn.setName(btnTitles[0][i]);
			this.buttonsPanel.add(this.btn, getBtnGrid());
		}
	}

	public void buildDisplay() {
		String[] outPutTitles = getOutPutAmount();
		setDisplayGrid();

		for (int i = 0; i <= outPutTitles.length - 1; i++) {
			this.outPut = new JTextField();
			this.outPut.setName(outPutTitles[i]);
			this.outPut.setColumns(this.width / 15);
			this.outPut.setFont(new Font("Arial", Font.BOLD, this.height / 20));
			this.outPut.setEditable(false);
			this.outPut.setFocusable(false);
			this.displayPanel.add(this.outPut);
		}
	}

	public void buildPanel() {
		this.window.add(this.displayPanel, BorderLayout.NORTH);
		this.window.add(this.buttonsPanel, BorderLayout.CENTER);
		this.window.setVisible(true);
	}

	public void configPanel(String location) {
		this.window.setLayout(new BorderLayout());
		this.window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.window.setSize(this.width, this.height);
		this.window.setResizable(false);
		this.window.setLocationRelativeTo(null);
	}
}
