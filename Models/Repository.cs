using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebMvc.Models
{
    public class Repository
    {
        private readonly List<GuestResponse> responses = new List<GuestResponse>();

        public Repository()
        {

        }

        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public IEnumerable<GuestResponse> Responses => responses;
    }
}
