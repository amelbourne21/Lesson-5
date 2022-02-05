// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

var students = new List<string>{"Darcy", "Aria", "Blaise", "Lachy", "Grace", "Issy"};
var courses = new List<string>{"Bioengineering", "Psychology", "Commerce", "Data Science", "Art", "History", "Software Engineering"};

Dictionary<string, string> studentCourseDict =  new Dictionary<string, string>(){{"Darcy", "Bioengineering"},
    {"Aria", "Psychology"},{"Blaise", "Commerce"}, {"Lachy", "Data Science"}, {"Charles", "Commerce"},
    {"Grace", "Art"}, {"Issy", "History"}};


Console.WriteLine("Welcome to the MyUni app!");
Console.WriteLine("Please choose one of the options below: ");
Console.WriteLine("1 - Current students");
Console.WriteLine("2 - Courses available");
Console.WriteLine("3 - Study plan");
Console.WriteLine("4 - Search students by course");
Console.WriteLine("5 - Search course by studnets");
Console.WriteLine("6 - Enrol");

var input = Console.ReadLine();

switch(input)
{
    case "1":
    showCurrentStudents(students);
    break;   
    
    case "2":
    showCurrentCourses(courses);
    break;

    case "3":
    Console.WriteLine("You are currently enrolled in Software Engineering");
    break;

    case "4":
    Console.WriteLine("Which student would you like to search?");
    var studentSelected = Console.ReadLine();
    var studentsCourse = studentCourseDict[studentSelected];
    Console.WriteLine($"{studentSelected} is enrolled in {studentsCourse}");
    break;

    case "5":
    Console.WriteLine("Which course would you like to search?");
    var courseSelected = Console.ReadLine();
    var studentsInCourse = studentCourseDict.FirstOrDefault(x => x.Value == courseSelected).Key;
    Console.WriteLine($"{studentsInCourse} is enrolled in {courseSelected}");
    break;

    case "6":
    addNewStudent(students);
    break;

}


static void showCurrentStudents(List<string>students)
{
    Console.WriteLine("Here are the current enrolled students: ");
    foreach(var student in students)
{
    Console.WriteLine($"{student}");
}
}

static void showCurrentCourses(List<string>courses)
{
    Console.WriteLine("Here are the current courses: ");
    foreach(var course in courses)
{
    Console.WriteLine($"{course}");
}
}

static void addNewStudent(List<string>students)
{
    Console.WriteLine("What is your first name?");
    var newStudent = Console.ReadLine();
    students.Add(newStudent);
    Console.WriteLine($"{newStudent} you have now been added to the list of students.");
}
