using DataAccessLayer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataAccess.Interfaces
{
    public interface IUserRepository : IRepository<UserModel>
    {
    }
}
