using System;
using System.Collections.Generic;
using System.Text;

namespace SwaggerWebAPI.Entities
{
    class Author
    {
        /// <summary>
        /// Name of author.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Surname of author.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Nationality.
        /// </summary>
        public string Nationality { get; set; }

        /// <summary>
        /// Birthday.
        /// </summary>
        public DateTime Birth { get; set; }

        /// <summary>
        /// All books.
        /// </summary>
        public List<Book> Publications { get; set; }
    }
}
