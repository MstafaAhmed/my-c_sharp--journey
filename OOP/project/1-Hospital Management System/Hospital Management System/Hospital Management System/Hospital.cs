#region Hospital Class
// Represents a hospital that contains doctors, patients, and appointments.
using Hospital_Management_System;

class Hospital
{
    #region Fields
    private string name;
    #endregion

    #region Properties
    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(Name));
    }

    public Doctor Doctor { get;}
    public Patient Patient { get;}
    public Appointment Appointment { get; }
    #endregion

    #region Constructor
    // Constructor to initialize a hospital with required objects
    public Hospital(string name, Doctor doctor, Patient patient, Appointment appointment)
    {
        Name = name;
        Doctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
        Patient = patient ?? throw new ArgumentNullException(nameof(patient));
        Appointment = appointment ?? throw new ArgumentNullException(nameof(appointment));
    }
    #endregion

    #region Methods
    public void DisplayHospitalDetails()
    {
        Console.WriteLine($"Hospital: {Name}");
        Appointment.DisplayAppointment();
    }
    #endregion
}
#endregion