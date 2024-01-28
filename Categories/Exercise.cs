using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Categories
{
    //avem o clasa abstracta care are un text si o lista de optiuni
    public abstract class Exercise
    {
        // Textul intrebarii
        public string Text { get; set; }

        // Lista de optiuni
        public List<string> Options { get; set; }

        // Indexul optiunii corecte
        public int CorrectOptionIndex { get; set; }
    }
}
