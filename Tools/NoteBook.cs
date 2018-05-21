using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class NoteBook:IComparable
    {
        public string Model { get; set; }
        public int Memory { get; set; }
        public int Rating { get; set; }
        public int Cost { get; set; }
        private bool Brend() => Model.Contains("Samsung") || Model.Contains("Asus");

        public NoteBook(string model, int memmory, int rating, int cost)
        {
            Model = model;
            Memory = memmory;
            Rating = rating;
            Cost = cost;
        }

        public int CompareTo(object obj)
        {
            NoteBook book = (NoteBook)obj;
            if (Memory.CompareTo(book.Memory) != 0)
                return Memory.CompareTo(book.Memory);
            if (Rating.CompareTo(book.Rating) != 0)
                return Rating.CompareTo(book.Rating);
            if (Brend() && !book.Brend())
                return 1;
            if (!Brend() && book.Brend())
                return -1;
            if (Cost.CompareTo(book.Cost) != 0)
                return Cost.CompareTo(book.Cost);
            return Model.CompareTo(book.Model);
        }
        public override string ToString()
        {
            return Model;
        }
    }
}
