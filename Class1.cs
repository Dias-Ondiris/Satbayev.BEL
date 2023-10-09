using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbayev.DAL;
namespace Satbayev.BEL
{
    public class ServiceClient
    {
        public string Path { get; set; }
        public ServiceClient(string path)
        {
            this.Path = path;
        }
        public void Registration(Client client)
        {
            RepositoryClient repository = new RepositoryClient(Path);
            bool result=repository.CreateClient(client);
        }
        public Client Auth(string Login,string Password)
        {
            RepositoryClient repository = new RepositoryClient(Path);
            Client client = repository.GetClient(Login, Password);
            return client;
        }
    }
}
