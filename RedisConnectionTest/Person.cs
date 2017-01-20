// ***********************************************************************
// Assembly         : Red isConnectionTest
// Author           : Mariusz
// Created          : 01-18-2017
//
// Last Modified By : Mariusz
// Last Modified On : 01-18-2017
// ***********************************************************************
// <copyright file="Person.cs" company="SoftwareHut">
//     Copyright (c) SoftwareHut
// </copyright>
// <author>Mariusz Maciejczuk</author>
// ***********************************************************************
using System;

namespace RedisConnectionTest
{
    /// <summary>
    /// Class Person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Person(string name)
        {
            Console.WriteLine("My name id " + name);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="job">The job.</param>
        public Person(string name, string job)
        {
            Console.WriteLine("My name id " + name + " job: " + job);
        }
    }
}
