import javax.swing.SwingUtilities;
import View.Panel;
import Model.TaskList;
import Controller.TaskController;

public class Main {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            TaskList list = new TaskList();
            Panel view = new Panel();
            TaskController controller = new TaskController(list, view);
            view.setController(controller);
            view.setVisible(true);
        });
    }
}