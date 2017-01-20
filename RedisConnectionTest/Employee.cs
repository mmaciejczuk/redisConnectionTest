// ***********************************************************************
// Assembly         : RedisConnectionTest
// Author           : Mariusz
// Created          : 01-18-2017
//
// Last Modified By : Mariusz
// Last Modified On : 01-18-2017
// ***********************************************************************
// <copyright file="Employee.cs" company="SoftwareHut">
//     Copyright (c) SoftwareHut
// </copyright>
// <author>Mariusz Maciejczuk</author>
// ***********************************************************************
using System;

namespace RedisConnectionTest
{
    /// <summary>
    /// Class Employee.
    /// </summary>
    class Employee 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="job">The job.</param>
        public Employee(string name, string job) {
            Console.WriteLine("I " + job + " for money.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee() : this("kowalski")
        {
            Console.WriteLine("I like cake");            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        public Employee(string lastName)
        {
            Console.WriteLine("Last name : " + lastName);
        }
      
    }
}
