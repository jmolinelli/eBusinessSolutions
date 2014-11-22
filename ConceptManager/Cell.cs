using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptManager
{
    /// <summary>
    /// Encapsulates a single concept
    /// </summary>
    public class Cell
    {
        /// <summary>
        /// The concept's term -- the character string used to label this individual concept
        /// </summary>
        public string term {get; set;}

        /// <summary>
        /// The concept's type
        /// </summary>
        public Cell type {get; set;}

        /// <summary>
        /// The concept's parent concept
        /// </summary>
        public Cell parent {get; set;}

        /// <summary>
        /// The concept's children
        /// </summary>
        public Cell children {get; set;}

        /// <summary>
        /// Converts the cell and its children to a List of strings
        /// </summary>
        /// <returns></returns>
        public List<string> ToItems()
        {
            var l = new List<string>();
            l.Add(this.term);
            return l;
        }
    }
}
