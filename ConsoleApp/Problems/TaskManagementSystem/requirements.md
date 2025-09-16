## Task Management System

- Users can create, update and delete task
- Each task can be assigned to only a single user
- Each task should have title, description, due date, user it is assigned to, date & time of creation, and status (Pending, InProgress, Completed)
- User can assign task to other users
- User should be able to set remainder for a task
- User should be able to search and filter out tasks based on different criteria (i.e., priority, due date, assigned user)
- User should be able to mark the task as completed and view its history

## Entities

### User

- should have `id`
- should have `name`
- can create task
- can update task
- can delete task
- can assign task to other user
- can search task based on different criteria (priority, due date, assigned user)
- can mark task as completed
- can view task history

### Task

- should have `description`
- should have `title`
- should have `priority` (HIGH, MEDIUM, LOW)
- should have `status` (PENDING, INPROGRESS, COMPELTED)
- should have `dueDate`
