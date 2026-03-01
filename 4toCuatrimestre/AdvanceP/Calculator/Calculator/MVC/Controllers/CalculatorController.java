package MVC.Controllers;

import MVC.Models.CalculatorModel;
import MVC.Views.Panel;
import javax.swing.*;
import java.awt.event.*;

public class CalculatorController implements ActionListener{
  private Panel view;
  private CalculatorModel model;
  private String current = "";

  public CalculatorController(Panel view, CalculatorModel model) {
    this.view = view;
    this.model = model;

    for (JButton btn : view.getAllButtons()) {
      btn.addActionListener(this);
    }
  }

  @Override    
  public void actionPerformed(ActionEvent e) {
    JButton btn = (JButton) e.getSource();
    String text = btn.getText();

    if (text.matches("[0-9]")) {
      current += text;
      view.setDisplayText(current);
      return;
    }

    if ("+-X/".contains(text)) {
      model.inputNumber(current);
      model.setOperator(text);
      current = "";
      return;
    }

    if (text.equals("=")) {
      model.inputNumber(current);
      double result = model.calculate();
      current = String.valueOf(result);
      view.setDisplayText(current);
      return;
    }

    if (text.equals("C")) {
      current = "";
      view.setDisplayText("0");
      return;
    }

    if (text.equals("CE")) {
      current = "";
      view.setDisplayText("0");
      return;
    }

    if (text.equals("DEL")) {
      if (!current.isEmpty()) {
        current = current.substring(0, current.length() - 1);
        view.setDisplayText(current.isEmpty() ? "0" : current);
      }
    }
  }
}
