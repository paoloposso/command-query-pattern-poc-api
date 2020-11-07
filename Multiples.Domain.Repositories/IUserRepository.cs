using System;
using Multiples.Domain.Entities;

namespace Multiples.Domain.Repositories
{
    public interface IUserRepository
    {
        public void Save(User user);
    }
}
