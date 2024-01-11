using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using schoolLib;
using System;
using Assert = NUnit.Framework.Assert;

namespace SchoolDataTest
{



    [TestFixture]
    public class SchoolUnitTest
    {
        [Test]
        public void AddStudent()
        {
            var schoolManagement = new SchoolManagement();
            var student = new Student { StudentId = 1, StudentName = "rayar", Class = "Class A" };

            // Act
            schoolManagement.AddStudent(student);

            // Assert
            Assert.Contains(student, schoolManagement.Students);
        }
        [Test]
        public void AddSubject()
        {
            var schoolManagement = new SchoolManagement();
            var subject = new Subject { SubjectId = 1, SubjectName = "Math" };

            // Act
            schoolManagement.AddSubject(subject);

            // Assert
            Assert.Contains(subject, schoolManagement.Subjects);
        }
        [Test]
        public void AddTeacher()
        {
            var schoolManagement = new SchoolManagement();
            var teacher = new Teacher { TeacherId = 1, TeacherName = "Mr. Ashok" };

            // Act
            schoolManagement.AddTeacher(teacher);

            // Assert
            Assert.Contains(teacher, schoolManagement.Teachers);
        }
        [Test]
        public void StudentMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var studentMock = new Mock<Student>();
            studentMock.SetupGet(s => s.StudentId).Returns(1);
            studentMock.SetupGet(s => s.StudentName).Returns("rayar");
            studentMock.SetupGet(s => s.Class).Returns("Class A");

            // Act
            schoolManagement.AddStudent(studentMock.Object);

            // Assert
            Assert.Contains(studentMock.Object, schoolManagement.Students);
        }
        [Test]
        public void TeacherMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var teacherMock = new Mock<Teacher>();
            teacherMock.SetupGet(s => s.TeacherId).Returns(1);
            teacherMock.SetupGet(s => s.TeacherName).Returns("Mr.shanks");


            // Act
            schoolManagement.AddTeacher(teacherMock.Object);

            // Assert
            Assert.Contains(teacherMock.Object, schoolManagement.Teachers);
        }
        [Test]
        public void SubjectMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var subjectMock = new Mock<Subject>();
            subjectMock.SetupGet(s => s.SubjectId).Returns(1);
            subjectMock.SetupGet(s => s.SubjectName).Returns("Math");


            // Act
            schoolManagement.AddSubject(subjectMock.Object);

            // Assert
            Assert.Contains(subjectMock.Object, schoolManagement.Subjects);
        }
    }
}