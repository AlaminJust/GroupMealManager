using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMealManagement.ViewModel
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreatAddress1 { get; set; }
        public string StreatAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HowYouKnowAboutUs { get; set; }
        public string FeedBack { get; set; }
        public string SuggestionsToImprove { get; set; }
        public bool WillYOuRecomand { get; set; }
        public string ProfilePictureLink { get; set; }
    }
}
