using vidly.Models;
using System.Collections.Generic;

namespace vidly.ViewModels
{
    public class MovieRandomVIew
    {
        public Movie movie { get; set; }
        public Customer customer { get; set; } 

        public List<Customer> customers { get; set; }
    }
}