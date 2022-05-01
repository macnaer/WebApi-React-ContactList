using ContactList.Data.Data.Context;
using ContactList.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Data.Data.Classes
{
    public class ContactListRepository : IContactListRepository
    {
        public Task CreateNewContactAsync(UserContactList user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserContactList>> GetContactListAsync()
        {
            using(var context = new AppDbContext())
            {
                return await context.ContactList.ToListAsync();
            }
        }
    }
}
