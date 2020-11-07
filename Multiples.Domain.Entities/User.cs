using System;

namespace Multiples.Domain.Entities
{
    public class User
    {
        public string Name { get; private set; }
        public int Id { get; private set; }


        public User(string name)
        {
            Name = name;
        }

        public User(string name, int id) : this(name)
        {
            Id = id;
        }
    }
}
