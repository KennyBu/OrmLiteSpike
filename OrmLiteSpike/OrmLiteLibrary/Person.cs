using System;
namespace OrmLiteLibrary
{
    public class Person
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string User { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}