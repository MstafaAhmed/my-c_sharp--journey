using System;
using Hospital_Management_System;
namespace Hospital_Management_System
{
    #region Program Execution
    // Main program to create and display hospital, doctor, patient, and appointment details.
    class Program
    {
        static void Main()
        {

            // Creating a patient
            Patient pat1 = new Patient(101, "Ali", 30, "No major history"); // first patient

            Patient pat2 = new Patient(102, "Ahmed", 55, "Diabetes history"); // second patient

            // Creating a doctor
            Doctor doc1 = new Doctor(1, "Dr. Mostafa", 25, "Cardiology"); // first doctor

            Doctor doc2 = new Doctor(2, "Dr. Aya", 30, "surgery");        // first doctor

            // Creating an appointment
            Appointment app1 = new Appointment(1, doc1, pat1, DateTime.Now.AddDays(1));  // appointment for paient 1

            Appointment app2 = new Appointment(2, doc2, pat2, DateTime.Now.AddDays(1));  // appointment for paient 2

            // Creating a hospital with constructor
            Hospital hospital1 = new Hospital("Nasr Hospital", doc1, pat1, app1);

            Hospital hospital2 = new Hospital("Misr Hospital", doc2, pat2, app2);

            // Displaying hospital and appointment details
            pat1.DisplayInfo();
            Console.WriteLine($"Medical History of {pat1.Name} : { pat1.GetMedicalHistory() }");
            doc1.DisplayInfo();
            hospital1.Appointment.DisplayAppointment();
            hospital2.Appointment.DisplayAppointment();
        }
    }
    #endregion
}