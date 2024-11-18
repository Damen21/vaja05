using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace University.Models;
public class Student
//test brancha
{
    public int ID { get; set; }
    public string? LastName { get; set; }
    public string? FirstMidName { get; set; }
    [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EnrollmentDate { get; set; }
   // create date of birth field  

    public ICollection<Enrollment>? Enrollments { get; set; }
}