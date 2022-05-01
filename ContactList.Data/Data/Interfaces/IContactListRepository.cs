using ContactList.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Data.Data.Classes
{
    public interface IContactListRepository
    {
        Task CreateNewContactAsync(UserContactList user);
        Task<List<UserContactList>> GetContactListAsync();
    }
}
