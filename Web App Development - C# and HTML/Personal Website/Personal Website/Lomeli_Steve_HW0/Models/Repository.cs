using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lomeli_Steve_HW0.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>(); //constructor

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
