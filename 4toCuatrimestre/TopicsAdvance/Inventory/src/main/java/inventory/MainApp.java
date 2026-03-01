package inventory;

import inventory.ui.InventoryFrame;
import javax.swing.SwingUtilities;

public class MainApp {
  public static void main(String[] args){
    SwingUtilities.invokeLater(()->new InventoryFrame().setVisible(true));
  }
}