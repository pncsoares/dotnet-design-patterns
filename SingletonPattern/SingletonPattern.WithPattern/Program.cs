using SingletonPattern.WithPattern;

var fromTeacher = Printer.GetInstance;
fromTeacher.Print("Message from teacher");

var fromStudent = Printer.GetInstance;
fromStudent.Print("Message from student");