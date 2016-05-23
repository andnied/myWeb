﻿using ContactsBook.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsBook.Data.Models;
using ContactsBook.Data;

namespace ContactsBook.SqlRepository
{
    public class ContactsSqlRepository : IContactsRepository
    {
        private ContactsModel _context = new ContactsModel();

        public IEnumerable<Contact> GetAll()
        {
            return (from c in _context.Contacts
                   select c).ToList();
        }

        public Contact GetById(int id)
        {
            return (from c in _context.Contacts
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public void Add(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void Update(Contact contact)
        {
            var toBeUpdated = (from c in _context.Contacts
                               where c.Id == contact.Id
                               select c).FirstOrDefault();

            //TODO: if == null

            //foreach (var prop in collection)
            //{

            //}
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        #region IDisposable

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                try
                {
                    if (_context != null)
                    {
                        _context.Dispose();
                        _context = null;
                    }
                }
                catch { }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
