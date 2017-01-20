// ***********************************************************************
// Assembly         : RedisConnectionTest
// Author           : Mariusz
// Created          : 01-17-2017
//
// Last Modified By : Mariusz
// Last Modified On : 01-18-2017
// ***********************************************************************
// <copyright file="Program.cs" company="SoftwareHut">
//     Copyright (c) SoftwareHut
// </copyright>
// <author>Mariusz Maciejczuk</author>
// ***********************************************************************
using System;

namespace RedisConnectionTest
{
    /// <summary>
    /// Class Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //var program = new Program();

            //Console.WriteLine("Saving random data in cache");
            //program.SaveBigData();

            //Console.WriteLine("Reading data from cache");
            //program.ReadData();

            //Console.ReadLine();
            //var foo = new Person("Anaimi_person");
            //var bar = new Employee("Anaimi", "cook food");
            var baz = new Employee();
            Console.ReadKey();
        }

        /// <summary>
        /// Reads the data.
        /// </summary>
        public void ReadData()
        {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            var devicesCount = 10000;
            for (int i = 0; i < devicesCount; i++)
            {
                var value = cache.StringGet($"Device_Status:{i}");
                Console.WriteLine($"Valor={value}");
            }
        }

        /// <summary>
        /// Saves the big data.
        /// </summary>
        public void SaveBigData()
        {
            var devicesCount = 10000;
            var rnd = new Random();
            var cache = RedisConnectorHelper.Connection.GetDatabase();

            for (int i = 1; i < devicesCount; i++)
            {
                var value = rnd.Next(0, 10000);
                cache.StringSet($"Device_Status:{i}", value);
                Console.WriteLine("zapis do bazy Redis");
            }
        }
    }
}
