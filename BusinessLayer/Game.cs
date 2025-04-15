using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Title cannot be more than 20 symbols!")]
        public string Title { get; set; }

        public List<User> Users { get; set; }
        public List<Genre> Genres { get; set; }

        private Game() 
        { 

        }

        public Game(string title)
        {
            Title = title;
            Users = new List<User>();
            Genres = new List<Genre>();
        }
    }
}
