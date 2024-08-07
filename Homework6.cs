﻿namespace Homework6;

class Student
{
    public int studentID;

    public string studentName;

    public static List<Student> studentList = new List<Student>();
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student name: {studentName}");
    }
   
    public Student(int id, string name){
        this.studentID = id;
        this.studentName = name;
        studentList.Add(this);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>(){
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8},
        };
        if (!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }

        double totalGPA = 0.0;

        foreach(var student in Student.studentList){
            if(gradebook.ContainsKey(student.studentName)){
                totalGPA += gradebook[student.studentName];
            }
        }
        double averageGPA = totalGPA / Student.studentList.Count;
        Console.WriteLine($"Average GPA: {averageGPA}");

        Console.WriteLine("Students with GPA greater than average GPA:");
        foreach(var student in Student.studentList){
            if(gradebook.ContainsKey(student.studentName) &&gradebook[student.studentName]>averageGPA){
                student.PrintInfo();
            }
        }
    }
}
