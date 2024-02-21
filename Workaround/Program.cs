// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "YİĞİT";
        person.LastName = "TOPCU";
        person.BirthOfDateYear = 1994;
        person.NationalIdentity = 123;


        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
    }
}
