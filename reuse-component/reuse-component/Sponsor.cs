using System;
namespace reuse_component
{
    public class Sponsor : Person
    {
        public int ID { set; get; }

        public ResidentList<Person> Accompany = new ResidentList<Person>();
    }
}
