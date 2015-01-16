using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace MvcApplication34.Controllers
{
    public class custom
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
    }
    public class ValuesController : ApiController
    {
        List<custom> usersData = new List<custom>()
        {
            new custom{Id=1, FirstName="John", LastName="Smith",Mobile="9999999991",Email="john@demo.com", City="kn", State="as", Country="usa",Zip="12401"},
            new custom{Id=2, FirstName="Adam", LastName="Gril", Mobile="9999999992",Email="adam@demo.com", City="bk",State="al", Country="usa",Zip="99701"},
            new custom{Id=3, FirstName="James", LastName="Franklin", Mobile="9999999993",Email="james@demo.com", City="js",State="nj", Country="usa",Zip="07097"},
            new custom{Id=4, FirstName="Vicky", LastName="Merry" , Mobile="9999999994",Email="vicky@demo.com", City="ol",State="ny", Country="usa",Zip="14760"},
            new custom{Id=5, FirstName="Cena", LastName="Rego", Mobile="9999999995",Email="cena@demo.com", City="as",State="tx", Country="usa",Zip="78610"}
        };

     // http://stackoverflow.com/questions/24876593/resource-query-return-split-strings-array-of-char-instead-of-a-string

        public string Get()
        {


            // Return a static list of users
            return "hello world";
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            ArrayList ar = new ArrayList();
            ar.Add("value");
            return new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(Json.Encode(ar))
            };
        }

        public custom Post(custom user)
        {
            usersData.Add(user);
            return user;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}