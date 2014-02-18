using System.Collections.Generic;
using System.Web.Mvc;
using AspNetMvcTalk.Web.Models.Objects;

namespace AspNetMvcTalk.Web.Models.Comments
{
    public class NewModel
    {
        public NewModel()
        {
            Members = new List<SelectListItem> {
                new SelectListItem {Text = "Harry Styles", Value = "Harry"},
                new SelectListItem {Text = "Liam Payne", Value = "Liam"},
                new SelectListItem {Text = "Louis Tomlinson", Value = "Louis"},
                new SelectListItem {Text = "Nial Horan", Value = "Niall"},
                new SelectListItem {Text = "Zayn Malik", Value="Zayn"}
            };
        }

        public string Name { get; set; }
        public string Favorite { get; set; }
        public string Text { get; set; }
        public IList<SelectListItem> Members { get; set; }

        public Comment ToComment()
        {
            return new Comment
                   {
                       Name = Name,
                       Favorite = Favorite,
                       Text = Text
                   };
        }
    }


}