package Controller;

import javax.swing.JPanel;
import Model.Task;
import Model.TaskList;
import View.Panel;

public class TaskController {
    private TaskList list;
    private Panel view;

    public TaskController(TaskList list, Panel view) {
        this.list = list;
        this.view = view;
    }

    public void addTask(String title) {
        if (title == null || title.isBlank()) return;
        Task task = new Task(title);
        list.addTask(task);
        view.refresh(list);
        view.animateTaskCreation(task);
    }

    public void toggleTask(Task task) {
        task.toggleCompleted();
        list.sortTasks();
        view.refresh(list);
        view.animateTaskReorder();
    }

    public void deleteTask(Task task) {
        JPanel row = view.getRow(task);
        view.animateTaskDeletion(task, row);
        list.removeTask(task);
    }

    public void editTask(Task task, String newTitle) {
        if (newTitle == null || newTitle.isBlank()) return;
        task.setTitle(newTitle);
        list.sortTasks();
        view.refresh(list);
    }
}
