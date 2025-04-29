using System;

namespace Hospital_Management_System
{
    internal class Doctor : IComparable<Doctor>
    {
        #region Fields
        private int id;
        private string name;
        private int age;
        private string specialty;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0) throw new ArgumentException("ID cannot be negative.");
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 25 || value > 120)
                    throw new ArgumentException("Age must be between 25 and 120 for a doctor.");
                age = value;
            }
        }

        public string Specialty
        {
            get { return specialty; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Specialty cannot be empty or whitespace.");
                specialty = value;
            }
        }
        #endregion

        #region Constructor
        public Doctor(int id, string name, int age, string specialty)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Specialty = specialty;
        }
        #endregion

        #region Methods
        public void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Doctor ID: {Id}, Name: {Name}, Age: {Age}, Specialty: {Specialty}";
        }

        public int CompareTo(Doctor other)
        {
            if (other == null) return 1;
            return this.Id.CompareTo(other.Id);
        }
        #endregion
    }
}
