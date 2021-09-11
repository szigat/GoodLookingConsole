using System;
using System.Collections.Generic;

namespace GoodLookingConsole
{
    public class Environment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static IEnumerable<Environment> GetEnvironments()
        {
            return new List<Environment>{
                new Environment
                {
                    Id = 1,
                    Name = "DEV1" 
                },
                new Environment
                {
                    Id = 2,
                    Name = "DEV2" 
                },
                new Environment
                {
                    Id = 3,
                    Name = "DEV3" 
                },
                new Environment
                {
                    Id = 4,
                    Name = "DEV4" 
                },
                new Environment
                {
                    Id = 5,
                    Name = "DEV_TEST" 
                },
                new Environment
                {
                    Id = 6,
                    Name = "UAT" 
                },
                new Environment
                {
                    Id = 7,
                    Name = "PROD" 
                }

            };
        }
    }
}