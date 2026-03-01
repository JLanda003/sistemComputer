package MVC.Views;

import MVC.Models.CalculatorModel;
import MVC.Controllers.CalculatorController;

public class Calculator{
	public static void main(String[] args) {
		Panel pane = new Panel("Calculadora", 450, 270);

		String[][] btn = {
			{
				"btn_CE", "btn_C", "btn_DEL", "btn_div",
				"btn_7", "btn_8", "btn_9", "btn_mult",
				"btn_4", "btn_5", "btn_6", "btn_min",
				"btn_1", "btn_2", "btn_3", "btn_plus",
				"btn", "btn_0", "btn_dot", "btn_equal",
			},{
					"CE", "C", "DEL", "/",
					"7", "8", "9", "X",
					"4", "5", "6", "-",
					"1", "2", "3", "+",
					"", "0", ".", "=",
			}
		};

		String[] outPut = {"display"};

		pane.setBtnTitles(btn);
		pane.setOutPutAmount(outPut);
		pane.buildBtn();
		pane.buildDisplay();
		pane.configPanel(null);
		pane.buildPanel();

		CalculatorModel model = new CalculatorModel();
		new CalculatorController(pane, model);
	}
}
