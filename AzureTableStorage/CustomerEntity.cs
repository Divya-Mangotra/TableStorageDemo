using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;



namespace AzureTableStorage
{

    public class CustomerEntity : TableEntity
    {
        public CustomerEntity(string lastName, string firstName)
        {
            this.PartitionKey = lastName;
            this.RowKey = firstName;
        }

        public CustomerEntity() { }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
    
    
    
    
    /*class CustomerEntity
    {
        public class CustomerEntity : TableEntity
        {

            public CustomerEntity(string firstName, string lastName)
            {
                this.PartitionKey = lastName;
                this.RowKey = firstName;
            }


            public CustomerEntity()
            {
            }

            public string Email { get; set; }
            public string PhoneNumber { get; set; }

        }
    }*/
}
