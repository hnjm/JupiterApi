using System;
using System.Collections.Generic;
using System.Text;

namespace Jupiter.Core.DTOs.Messages
{
   public class MessagesDTO
    {

        public string text { get; set; }
        public int? Like { get; set; }
        public int? DisLike { get; set; }
        public bool? IsImportant { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorMembershipNumber { get; set; }
        public string AuthorAvatar { get; set; }
        public bool AuthorGender { get; set; }

    }
}
