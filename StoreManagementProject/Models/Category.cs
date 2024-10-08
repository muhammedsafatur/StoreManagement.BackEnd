using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreManagementProject.Web.Api.Models
{
 
    public class Category 
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
