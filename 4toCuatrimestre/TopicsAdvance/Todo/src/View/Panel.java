package View;

import Model.Task;
import Model.TaskList;
import Controller.TaskController;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.HashMap;
import java.util.Map;

public class Panel extends JFrame {
    private static final long serialVersionUID = 1L;

    private TaskController controller;
    private JPanel taskContainer;
    private JScrollPane scroll;

    private Map<Task, JPanel> taskRows = new HashMap<>();

    public Panel() {
        setTitle("Lista de tareas");
        setSize(500, 600);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setLayout(new BorderLayout());

        JPanel topPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        JTextField  inputField = new JTextField(33);
        JButton addButton = new JButton("Nueva Tarea");
        topPanel.add(inputField);
        topPanel.add(addButton);
        add(topPanel, BorderLayout.NORTH);

        taskContainer = new JPanel();
        taskContainer.setLayout(new BoxLayout(taskContainer, BoxLayout.Y_AXIS));
        scroll = new JScrollPane(taskContainer);
        add(scroll, BorderLayout.CENTER);

        addButton.addActionListener(e -> {
            if (controller != null) {
                controller.addTask(inputField.getText());
                inputField.setText("");
            }
        });
    }

    public void setController(TaskController controller) {
        this.controller = controller;
    }

    public void refresh(TaskList list) {
        taskContainer.removeAll();
        taskRows.clear();

        for (Task task : list.getTasks()) {
            JPanel row = createRow(task, list);
            taskRows.put(task, row);
            taskContainer.add(row);
        }

        taskContainer.revalidate();
        taskContainer.repaint();
    }

    private JPanel createRow(Task task, TaskList list) {
        JPanel row = new JPanel();
        row.setLayout(new BorderLayout());
        row.setPreferredSize(new Dimension(450, 50));
        row.setMaximumSize(new Dimension(Integer.MAX_VALUE, 50));
        row.setBorder(BorderFactory.createLineBorder(Color.GRAY));

        JCheckBox check = new JCheckBox();
        check.setSelected(task.isCompleted());
        check.addActionListener(e -> {
            if (controller != null) {
                controller.toggleTask(task);
            }
        });

        JLabel titleLabel = new JLabel(task.getTitle());
        titleLabel.setBorder(BorderFactory.createEmptyBorder(0, 10, 0, 0));

        JButton edit = new JButton("Editar");
        edit.addActionListener(e -> {
            JTextField editor = new JTextField(task.getTitle());
            editor.setBorder(BorderFactory.createEmptyBorder(5,5,5,5));

            row.remove(titleLabel);
            row.add(editor, BorderLayout.CENTER);
            row.revalidate();
            row.repaint();
            editor.requestFocusInWindow();

            editor.addActionListener(ev -> finishEdit(task, editor, row, list));

            editor.addKeyListener(new KeyAdapter() {
                @Override
                public void keyPressed(KeyEvent ke) {
                    if (ke.getKeyCode() == KeyEvent.VK_ESCAPE) {
                        row.remove(editor);
                        row.add(titleLabel, BorderLayout.CENTER);
                        row.revalidate();
                        row.repaint();
                    }
                }
            });
        });


        JButton delete = new JButton("Eliminar");
        delete.addActionListener(e -> {
            if (controller != null) {
                JPanel targetRow = getRow(task);
                controller.deleteTask(task);
            }
        });

        JPanel actions = new JPanel(new FlowLayout(FlowLayout.RIGHT));
        actions.add(edit);
        actions.add(delete);

        row.add(check, BorderLayout.WEST);
        row.add(titleLabel, BorderLayout.CENTER);
        row.add(actions, BorderLayout.EAST);

        if (task.isCompleted()) row.setBackground(new Color(120, 255, 120));
        else row.setBackground(new Color(230, 230, 230));

        return row;
    }

    private void finishEdit(Task task, JTextField editor, JPanel row, TaskList list) {
        String newText = editor.getText();
        if (newText != null && !newText.isBlank()) {
            if (controller != null) {
                controller.editTask(task, newText);
            }
        }
    }

    public JPanel getRow(Task task) {
        return taskRows.get(task);
    }

    public void animateTaskCreation(Task task) {
        JPanel row = getRow(task);
        if (row == null) return;
        row.setVisible(false);
        Timer timer = new Timer(10, null);
        final int[] h = {0};
        timer.addActionListener(e -> {
            h[0] += 3;
            row.setPreferredSize(new Dimension(450, h[0]));
            row.revalidate();
            if (h[0] >= 50) {
                row.setVisible(true);
                timer.stop();
            }
        });
        timer.start();
    }

    public void animateTaskReorder() {
        taskContainer.setBackground(Color.YELLOW);
        Timer timer = new Timer(10, e -> taskContainer.setBackground(null));
        timer.setRepeats(false);
        timer.start();
    }

    public void animateTaskDeletion(Task task, JPanel row) {
        if (row == null) return;
        Timer timer = new Timer(15, null);
        final float[] opacity = {1f};
        timer.addActionListener(e -> {
            opacity[0] -= 0.07f;
            opacity[0] = Math.max(0f, opacity[0]);
            int alpha = (int) (opacity[0] * 255);
            alpha = Math.max(0, Math.min(255, alpha));
            row.setOpaque(true);
            Color bg = new Color(255, 80, 80);
            row.setBackground(new Color(bg.getRed(), bg.getGreen(), bg.getBlue(), alpha));
            row.repaint();
            if (opacity[0] <= 0f) {
                timer.stop();
                taskContainer.remove(row);
                taskContainer.revalidate();
                taskContainer.repaint();
            }
        });
        timer.start();
    }
}