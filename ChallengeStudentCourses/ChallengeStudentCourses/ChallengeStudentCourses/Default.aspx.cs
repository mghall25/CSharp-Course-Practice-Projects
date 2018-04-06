using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in each Course.
             */

            // create list of at least 3 courses, at least two students enrolled in each
            var courses = new List<Course>()
            {
                 new Course {CourseId = 101,
                             Name = "HTML/CSS/Bootstrap",
                             Students = new List<Student>()
                                 {
                                     new Student {StudentId=5001,Name="Ashley Black"},
                                     new Student {StudentId=5002,Name="John Calvin"}
                                 }
                             },   
                 new Course {CourseId = 102,
                             Name ="JavaScript/jQuery",
                             Students = new List<Student>()
                                 {
                                     new Student {StudentId=5003,Name="Philip Hamilton"},
                                     new Student {StudentId=5002,Name="John Calvin"}
                                 }
                            },
                 new Course {CourseId = 103,
                             Name = "SQL",
                             Students = new List<Student>()
                                 {
                                     new Student {StudentId=5001,Name="Ashley Black"},
                                     new Student {StudentId=5003,Name="Philip Hamilton"}
                                 }
                             },
                 new Course {CourseId = 104,
                             Name = "C#",
                             Students = new List<Student>()
                                 {
                                     new Student {StudentId=5001,Name="Ashley Black"},
                                     new Student {StudentId=5002,Name="John Calvin"}
                                 }
                             },
                 new Course {CourseId = 105,
                             Name = "ASP.NET",
                             Students = new List<Student>()
                                 {
                                     new Student {StudentId=5001,Name="Ashley Black"},
                                     new Student {StudentId=5003,Name="Philip Hamilton"}
                                 }
                             }
            };

            // print course detils with students enrolled   
            resultLabel.Text = "";
            foreach (var course in courses)
            {
                resultLabel.Text += "<strong>Course: " + course.CourseId + " " + course.Name + "</strong><br>";
                foreach (var student in course.Students)
                {
                    resultLabel.Text += "&nbsp;&nbsp;&nbsp;   Student: " + student.StudentId + " " + student.Name + "<br>";
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students.  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use Object and Collection Initializers.  
             */
            // define courses
            Course c101 = new Course { CourseId = 101, Name = "HTML/CSS/Bootstrap" };
            Course c102 = new Course { CourseId = 102, Name = "JavaScript/jQuery" };
            Course c103 = new Course { CourseId = 103, Name = "SQL" };
            Course c104 = new Course { CourseId = 104, Name = "C#" };
            Course c105 = new Course { CourseId = 105, Name = "ASP.NET" };

            // create students dictionary, 3 students enrolled in at least 2 courses each
            var students = new Dictionary<int,Student>()
            {
               { 50001, new Student{StudentId=50001,
                                    Name ="Ashley Black",
                                    Courses = new List<Course>()        // illustrates shorter method of adding info to list
                                        { c101, c103, c104, c105 }    
                                    }       
               },
               { 50002, new Student{StudentId=50002,
                                    Name ="John Calvin",
                                    Courses = new List<Course>()
                                        { c101, c102, c105 }
                                    }
               },
               { 50003, new Student{StudentId=50003,
                                    Name ="Philip Hamilton",
                                    Courses = new List<Course>()        // illustrates longer method of adding info to list
                                        {
                                            new Course {CourseId = 102, Name="JavaScript/jQuery"},
                                            new Course {CourseId = 103, Name = "SQL" },
                                            new Course {CourseId = 104, Name="C#"}
                                        }
                                    }
               }
            };

            // print student info and their courses
            resultLabel.Text = "";
            foreach (var student in students)
            {
                resultLabel.Text += "<strong>Student: " + student.Key + " " + student.Value.Name + "</strong><br>";
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += "&nbsp;&nbsp;&nbsp;   Course: " + course.CourseId + " " + course.Name + "<br>";
                }
            }
        }

        // define courses and students here for use in assignment3Button_Click
        // define students
        Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
               { 50001, new Student{StudentId=50001,
                                    Name ="Ashley Black",
                                    Courses = new List<Course>()
                                        {
                                            new Course {CourseId = 101, Name = "HTML/CSS/Bootstrap" },
                                            new Course {CourseId = 103, Name = "SQL" },
                                            new Course {CourseId = 104, Name="C#"},
                                            new Course {CourseId = 105, Name = "ASP.NET" }
                                        }
                                    }
               },
               { 50002, new Student{StudentId=50002,
                                    Name ="John Calvin",
                                    Courses = new List<Course>()
                                        {
                                            new Course {CourseId = 101, Name = "HTML/CSS/Bootstrap" },
                                            new Course {CourseId = 102, Name="JavaScript/jQuery"},
                                            new Course {CourseId = 105, Name = "ASP.NET" }
                                        }
                                    }
               },
               { 50003, new Student{StudentId=50003,
                                    Name ="Philip Hamilton",
                                    Courses = new List<Course>()
                                        {
                                            new Course {CourseId = 102, Name="JavaScript/jQuery"},
                                            new Course {CourseId = 103, Name = "SQL" },
                                            new Course {CourseId = 104, Name="C#"}
                                        }
                                    }
               }
            };

        //define courses as a dictionary rather than a list to allow for lookup in assignment3Button_Click
        Dictionary<int,Course> courses = new Dictionary<int, Course>()
            {
                { 101, new Course {CourseId = 101,
                                   Name = "HTML/CSS/Bootstrap",
                                   Students = new List<Student>()
                                        {
                                            new Student {StudentId=5001,Name="Ashley Black"},
                                            new Student {StudentId=5002,Name="John Calvin"}
                                        }
                                   }
                },
                { 102, new Course {CourseId = 102,
                                   Name ="JavaScript/jQuery",
                                   Students = new List<Student>()
                                         {
                                             new Student {StudentId=5003,Name="Philip Hamilton"},
                                             new Student {StudentId=5002,Name="John Calvin"}
                                         }
                                   }
                },
                { 103, new Course {CourseId = 103,
                                   Name = "SQL",
                                   Students = new List<Student>()
                                     {
                                         new Student {StudentId=5001,Name="Ashley Black"},
                                         new Student {StudentId=5003,Name="Philip Hamilton"}
                                     }
                                   }
                },
                { 104, new Course {CourseId = 104,
                                  Name = "C#",
                                  Students = new List<Student>()
                                      {
                                         new Student {StudentId=5001,Name="Ashley Black"},
                                         new Student {StudentId=5002,Name="John Calvin"}
                                      }
                                  }
                },
                { 105, new Course {CourseId = 105,
                                   Name = "ASP.NET",
                                   Students = new List<Student>()
                                      {
                                        new Student {StudentId=5001,Name="Ashley Black"},
                                        new Student {StudentId=5003,Name="Philip Hamilton"}
                                      }
                                   }
                }
            };
        
        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            // add class to hold grade. Class Added: StudentCourse - this includes the student's id, course id, and the grade. 
            // Course and student data will be accessed by finding the matching information in those collections.
            // This design contains classes that are meant to mimic tables in a relational database, avoiding the re-entry of Student and Course Names in the StudentCourse class by use of Ids, and looking up the Names when needed.
            var grades = new List<StudentCourse>()
            {
                { new StudentCourse {StudentId = 50001, CourseId = 101, Grade = 95 } },
                { new StudentCourse {StudentId = 50001, CourseId = 103, Grade = 98 } },
                { new StudentCourse {StudentId = 50001, CourseId = 104, Grade = 97 } },
                { new StudentCourse {StudentId = 50001, CourseId = 105, Grade = 91 } },
                { new StudentCourse {StudentId = 50002, CourseId = 101, Grade = 85 } },
                { new StudentCourse {StudentId = 50002, CourseId = 102, Grade = 88 } },
                { new StudentCourse {StudentId = 50002, CourseId = 105, Grade = 87 } },
                { new StudentCourse {StudentId = 50003, CourseId = 102, Grade = 91 } },
                { new StudentCourse {StudentId = 50003, CourseId = 103, Grade = 96 } },
                { new StudentCourse {StudentId = 50003, CourseId = 104, Grade = 78 } }
            };

            // print out courses each student is enrolled in and their grade
            var result = "";
            var studentName = "";
            var courseName = "";
            var prevStudent = "";
          

            foreach (var grade in grades)
            {
                // get student and course names from corresponding lists
                if (students.TryGetValue(grade.StudentId, out Student student))
                {
                    studentName = student.Name;
                }
                if (courses.TryGetValue(grade.CourseId, out Course course))     
                {
                    courseName = course.Name;
                }

                // print student info only if it's the first occurrence of this name.
                // Assumption: grades are sorted by StudentId and CourseId
                if (studentName != prevStudent)
                {
                    result += "<strong>Student: " + grade.StudentId + " " + studentName + "</strong><br>";
                    prevStudent = studentName;
                }

                //print course info and grade
                result += "&nbsp;&nbsp;&nbsp;   Course: " + grade.CourseId + " " + courseName + " Grade: " + grade.Grade + "<br>";
                
            }
            resultLabel.Text = result;
        }
    }
}