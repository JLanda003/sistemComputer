package Model;

import java.util.*;

public class TaskList {
    private java.util.List<Task> tasks = new ArrayList<>();

    public void addTask(Task t) { tasks.add(t); }

    public void removeTask(Task t) { tasks.remove(t); }

    public java.util.List<Task> getTasks() { return tasks; }

    public void sortTasks() {
        tasks.sort(Comparator.comparing(Task::isCompleted));
    }
}
