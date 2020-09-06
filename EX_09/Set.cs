//Corrected by Ricardo Monreal Rubio
//use for CST-117 Exercise 9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace EX_09
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;

                // this returned false even though there was no value to match

                //else
                //    return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            // this is returning the same set, it is needed to create a new set for union

            Set union = new Set();

            

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // add elements to the current union
                union.addElement(rhs.elements[i]);
            }
            // add each element from current elements o the new union set
            foreach (int i in elements)
            {
                union.addElement(i);
                // added sort from small to largest
                union.elements.Sort();
            }

            // this should return the new union set after foreach
            //return rhs;
            return union;
        }
    }
}
