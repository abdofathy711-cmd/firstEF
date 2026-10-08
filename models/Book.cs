using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_EF.models
{
    /*
     Q1: Why did the property "Id" become a Primary Key
without any explicit configuration? 
    a1 : migration understand this is special because named ID.
Q2: Why is "Country" nullable in the database
while "Price" is not? 
    A2: country nullable because take data type string or null (string?) not required
    while price required so it is not nullable.
     */
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublicedDate { get; set; }
    }
}
