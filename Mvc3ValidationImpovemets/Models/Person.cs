namespace Mvc3ValidationImpovemets.Models
{
    using System.Web.Mvc;

    public class Person
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //[SkipRequestValidation]
        public string Bio { get; set; }
    }
}