using System;
using static reuse_component.Program;

namespace reuse_component
{
    public class Person
    {
        public enum GenderTypes { male, female }

        public string Name { set; get; }

        public int Age { set; get; }

        public GenderTypes Gender { set; get; }

    }
}
