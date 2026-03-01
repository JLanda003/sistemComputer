package inventory.ui;

import inventory.model.Product;
import inventory.repository.ProductRepository;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;

public class InventoryFrame extends JFrame {

  private static final long serialVersionUID = 1L;
  private JTextField nameField=new JTextField();
  private JTextField priceField=new JTextField();
  private JTextField stockField=new JTextField();

  private DefaultTableModel model=new DefaultTableModel(
    new Object[]{"Id","Nombre","Precio","Stock"},0);
  private JTable table=new JTable(model);

  private ProductRepository repo=new ProductRepository();

  public InventoryFrame(){
    setTitle("Manejador de inventario");
    setSize(700,400);
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    setLocationRelativeTo(null);

    JPanel form=new JPanel(new GridLayout(2,6,5,5));
    form.add(new JLabel("Nombre"));
    form.add(new JLabel("Precio"));
    form.add(new JLabel("Stock"));
    form.add(new JLabel(""));
    form.add(new JLabel(""));
    form.add(new JLabel(""));

    form.add(nameField);
    form.add(priceField);
    form.add(stockField);

    JButton add=new JButton("Agregar");
    JButton update=new JButton("Actualizar");
    JButton delete=new JButton("Eliminar");

    form.add(add);form.add(update);form.add(delete);

    add(form,BorderLayout.NORTH);
    add(new JScrollPane(table),BorderLayout.CENTER);

    add.addActionListener(e->addProduct());
    update.addActionListener(e->updateProduct());
    delete.addActionListener(e->deleteProduct());

    loadProducts();
  }

  private void loadProducts(){
    model.setRowCount(0);
    repo.findAll().forEach(p->
      model.addRow( new Object[]{
        p.getId(),
        p.getName(),
        p.getPrice(),
        p.getStock()
    }));
  }

  private void addProduct(){
    repo.save(new Product(
    nameField.getText(),
    Double.parseDouble(priceField.getText()),
    Integer.parseInt(stockField.getText())
    ));
    loadProducts();
  }

  private void updateProduct(){
    int r=table.getSelectedRow();
    if(r==-1)return;
    Long id=(Long)model.getValueAt(r,0);
    Product p=new Product(
      nameField.getText(),
      Double.parseDouble(priceField.getText()),
      Integer.parseInt(stockField.getText())
    );
  
    p.setId(id);

    repo.update(p);
    loadProducts();
  }

  private void deleteProduct(){
    int r=table.getSelectedRow();
    if(r==-1)return;
    Long id=(Long)model.getValueAt(r,0);
    repo.delete(id);
    loadProducts();
  }
}