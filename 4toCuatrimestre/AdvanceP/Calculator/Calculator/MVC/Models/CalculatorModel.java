package MVC.Models;

public class CalculatorModel {
	private double currentValue = 0;
	private double storedValue = 0;
	private String operator = "";
	
	public void inputNumber(String number) {
		this.currentValue = Double.parseDouble(number);
	}

	public void setOperator(String operator) {
		this.operator = operator;
		this.storedValue = this.currentValue;
		this.currentValue = 0;
	}

	public double calculate() {
		return switch(this.operator) {
			case "+" -> this.storedValue + this.currentValue;
			case "-" -> this.storedValue - this.currentValue;
			case "X" -> this.storedValue * this.currentValue;
			case "/" -> this.currentValue != 0 ? this.storedValue / this.currentValue : 0;
			default -> this.currentValue;
		};
	}
}
