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
    class Program
    {
        static void Main(string[] args)
        {

            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=tableeg;AccountKey=r0PEVAtFwFdl5P3Zl21obz0tfNNsSwhdHAUNSCHCmjKcqnLXD39Xmo2TVnOaIrrOnvgySN5SoEenaNImO8OWmg==");
            
            CloudTableClient tableclient = cloudStorageAccount.CreateCloudTableClient();

            CloudTable table = tableclient.GetTableReference("people1");
            table.CreateIfNotExists();


            Console.WriteLine(table.Uri.ToString());



            CustomerEntity customer2 = new CustomerEntity("Rahul","Sharma");
            customer2.Email = "rahuls@gmail.com";
            customer2.PhoneNumber = "9199677888";
         

            TableOperation insertoperation = TableOperation.Insert(customer2);
            table.Execute(insertoperation);
            insertoperation = TableOperation.InsertOrReplace(customer2);

            Console.WriteLine("Entity inserted!");

          



        }

       



        
    }
}
