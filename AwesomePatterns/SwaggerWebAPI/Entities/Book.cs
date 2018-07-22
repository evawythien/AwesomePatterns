using System;

namespace SwaggerWebAPI
{
    public class Book
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Editorial.
        /// </summary>
        public string Editorial { get; set; }

        /// <summary>
        /// Serial number.
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Number of pages.
        /// </summary>
        public string NumPages { get; set; }

        /// <summary>
        /// Is in stock.
        /// </summary>
        public bool InStock { get; set; }
    }
}
