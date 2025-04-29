using System;
 
namespace Hospital_Management_System
{
    internal class Patient
    {
        #region fields
        int id;
        string name;
        int age;
        string medicalHistory;
        #endregion

        #region property
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
                if (value < 0) throw new ArgumentException("Age cannot be negative.");
                age = value;
            }
        }
        public string MedicalHistory
        {
            get { return medicalHistory; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Medical history cannot be empty or whitespace.");
                medicalHistory = value;
            }
        }


        #endregion

        #region Constructor
        public Patient(int id, string name, int age, string history)
            {
                Id = id;
                Name = name;
                Age = age;
                MedicalHistory = history;
            }
        #endregion

        #region Method
        public void DisplayInfo()
            {
                Console.WriteLine($"Patient ID: {id}, Name: {name}, Age: {age}");
            }
        public string GetMedicalHistory()
        {
            return medicalHistory ;
        }
    }
    #endregion

}
