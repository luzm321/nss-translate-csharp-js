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

            foreach (Guest guest in guests) 
            {
                string table1Occupations = tables.Select(guest => guest.occupation); // iterating through the tables collection
                if (table1Occupations.Contains(guest.occupation))
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
                Console.WriteLine($"{guest.name} ({guest.occupation}) {guest.bio}");
            }

            // A method to make and return list of guests:
            List<Guest> GetGuests()
            {
                //Make a list of guest objects:
                List<Guest> guests = new List<Guest>() 
                {
                    new Guest {
                        name = "Marilyn Monroe",
                        occupation = "entertainer",
                        bio = "(1926 - 1962) American actress, singer, model"
                    },
                    new Guest {
                        name = "Abraham Lincoln",
                        occupation = "politician",
                        bio = "(1809 - 1865) US President during American civil war"
                    },
                    new Guest {
                        name = "Martin Luther King",
                        occupation = "activist",
                        bio = "(1929 - 1968)  American civil rights campaigner"
                    },
                    new Guest {
                        name = "Rosa Parks",
                        occupation = "activist",
                        bio = "(1913 - 2005)  American civil rights activist"
                    },
                    new Guest {
                        name = "Peter Sellers",
                        occupation = "entertainer",
                        bio = "(1925 - 1980) British actor and comedian"
                    },
                    new Guest {
                        name = "Alan Turing",
                        occupation = "computer scientist",
                        bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                    },
                    new Guest {
                        name = "Admiral Grace Hopper",
                        occupation = "computer scientist",
                        bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                    },
                    new Guest {
                        name = "Indira Gandhi",
                        occupation = "politician",
                        bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                    }
                };

                return guests;
            }
            
            // Classes are how objects are defined in C#. Classes help ensure that the objects always have the correct properties/methods.
            public class Guest
            {
                public string name { get; set; }
                public string occupation { get; set; }
                public string bio { get; set; }
            }
        }
    }
}
