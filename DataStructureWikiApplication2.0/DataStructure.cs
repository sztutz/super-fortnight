using System;

namespace DataStructureWikiApplication2._0
{
    public class DataStructure : IComparable<DataStructure>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public DataStructure (string name, string category, string structure, string definition)
        {
            this.name = name;
            this.category = category;
            this.structure = structure;
            this.definition = definition;
        }

        public int CompareTo(other : DataStructure)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) return 1;

            // The data structure comparison depends on the comparison of the String name values.
            return name.CompareTo(other.name);
        }

        // Define the is greater than operator.
        public static bool operator > (DataStructure operand1, DataStructure operand2)
        {
            return operand1.CompareTo(operand2) > 0;
        }

        // Define the is less than operator.
        public static bool operator < (DataStructure operand1, DataStructure operand2)
        {
            return operand1.CompareTo(operand2) < 0;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >= (DataStructure operand1, DataStructure operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <= (DataStructure operand1, DataStructure operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

        public string GetName ()
        {
            return name;
        }

        public void SetName (string name)
        {
            this.name = name;
        }

        public string GetCategory ()
        {
            return category;
        }

        public void SetCategory (string category)
        {
            this.category = category;
        }

        public string GetStructure ()
        {
            return structure;
        }

        public void SetStructure (string structure)
        {
            this.structure = structure;
        }

        public string GetDefinition ()
        {
            return structure;
        }

        public void SetDefinition (string definition)
        {
            this.definition = definition;
        }
    }
}