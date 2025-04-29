#region Appointment Class

// Represents an appointment between a doctor and a patient at a specific date.

using Hospital_Management_System;
class Appointment
{
    #region fields
    int id;
    Doctor doctor;
    Patient patient;
    DateTime date;
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

    public Doctor Doctor 
    {
        get { return doctor; }
        set { doctor = value;} 
    }
    public Patient Patient 
    { 
        get { return patient; }
        set { patient = value; }
    }
    public DateTime Date
    {
        get { return date; }
        set
        {
            if (value < DateTime.Now) throw new ArgumentException("Appointment date cannot be in the past.");
            date = value;
        }
    }


    #endregion

    #region constructor
    // Constructor to ensure required values are provided

    public Appointment(int id, Doctor doctor, Patient patient, DateTime date)
    {
        Id = id;
        Doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
        Patient = patient ?? throw new ArgumentNullException(nameof(patient));
        Date = date;
    }
    #endregion

    #region Method

    // Method to display appointment details
    public void DisplayAppointment()
    {
        Console.WriteLine($"Appointment ID: {Id}, Doctor: {Doctor.Name}, Patient: {Patient.Name}, Date: {Date}");
    }
    #endregion 
}
#endregion