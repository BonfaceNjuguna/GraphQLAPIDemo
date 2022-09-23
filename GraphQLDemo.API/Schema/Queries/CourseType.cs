﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace GraphQLDemo.API.Schema.Queries
{
    public enum Subject
    {
        Maths,
        Science,
        History
    }
    public class CourseType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public InstructorType Instructor { get; set; }
        public IEnumerable<StudentType> Students { get; set; }

    }
}
