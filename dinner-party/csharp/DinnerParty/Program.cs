using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;


namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guests = GetGuests();
            List<List<string>> tables = new List<List<string>>();
            tables.Add(new List<string> {"Table 1"}); // pushing a new string type list to the List type collection
            tables.Add(new List<string> {"Table 2"});

            // A method to make and return list of guests:
            List<Guest> GetGuests()
            {
                //Make a list of guest objects:
                List<Guest> guests = new List<Guest>() 
                {
                    new Guest() {
                        Name = "Marilyn Monroe",
                        Occupation = "entertainer",
                        Bio = "(1926 - 1962) American actress, singer, model"
                    },
                    new Guest() {
                        Name = "Abraham Lincoln",
                        Occupation = "politician",
                        Bio = "(1809 - 1865) US President during American civil war"
                    },
                    new Guest() {
                        Name = "Martin Luther King",
                        Occupation = "activist",
                        Bio = "(1929 - 1968)  American civil rights campaigner"
                    },
                    new Guest() {
                        Name = "Rosa Parks",
                        Occupation = "activist",
                        Bio = "(1913 - 2005)  American civil rights activist"
                    },
                    new Guest() {
                        Name = "Peter Sellers",
                        Occupation = "entertainer",
                        Bio = "(1925 - 1980) British actor and comedian"
                    },
                    new Guest() {
                        Name = "Alan Turing",
                        Occupation = "computer scientist",
                        Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                    },
                    new Guest() {
                        Name = "Admiral Grace Hopper",
                        Occupation = "computer scientist",
                        Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                    },
                    new Guest() {
                        Name = "Indira Gandhi",
                        Occupation = "politician",
                        Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                    }
                };

                return guests;
            }

            var OrganizeGuests()
            {
                foreach (Guest guest in guests) 
                {
                    string table1Occupations = tables.Select(guest => guest.Occupation); // iterating through the tables collection
                    if (table1Occupations.Contains(guest.Occupation))
                    {
                        tables["Table 2"].Add(guest);
                    }
                    else 
                    {
                        tables["Table 1"].Add(guest);
                    }
                }

                foreach (string table in tables)
                {   
                    string tableGuests = tables[tableName];
                    Console.WriteLine(tableName);
                }

                foreach (Guest guest in tableGuests) 
                {
                    Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
                }
            }

            OrganizeGuests();
            
            // Classes are how objects are defined in C#. Classes help ensure that the objects always have the correct properties/methods.
            public class Guest
            {
                public string Name { get; set; }
                public string Occupation { get; set; }
                public string Bio { get; set; }
            }
        }
    }
}
