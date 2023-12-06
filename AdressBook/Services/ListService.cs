using AdressBook.Interfaces;
using AdressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook.Services
{
    public class ListService
    {
       private static readonly List<Person> persons = [];
        
        //public ListService ()
        //{
        //    persons = new List<Person> ();
        //}


        public List<Person> ShowList()
        {
           
            return persons;
            
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

      
    }
}
