using System;
using System.Collections.Generic;

namespace AddressBookFileIo
{
    public class AddressBook
    {
        internal List<AddressBook> people;

        internal static void StoreCityList(string key, List<AddressBook> value, string city)
        {
            throw new NotImplementedException();
        }

        internal static void StoreStateList(string key, List<AddressBook> value, string state)
        {
            throw new NotImplementedException();
        }

        internal static void SortByPersonName(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }

        internal void GetCustomer(string firstName, string lastName, string phoneNumber, string addresses, string city, string state, string zipCode, string emailId)
        {
            throw new NotImplementedException();
        }

        internal void ListContact()
        {
            throw new NotImplementedException();
        }

        internal void EditContact()
        {
            throw new NotImplementedException();
        }

        internal void DeletePeople()
        {
            throw new NotImplementedException();
        }

        internal static void CountCityorState()
        {
            throw new NotImplementedException();
        }

        internal static void SortBasedByCity(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }

        internal static void SortBasedByState(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }

        internal static void SortBasedByZipCode(Dictionary<string, List<AddressBook>> addressBook)
        {
            throw new NotImplementedException();
        }
    }
}