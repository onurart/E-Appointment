namespace Appointment.Entities;
public sealed class Appointmentses
{
    public Appointmentses()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public Guid DoctorId { get; set; }
    public Doctor? Doctor { get; set; }
    public Guid PatientId { get; set; }
    public Patient? Patient { get; set; }
    public DateTime StatDae { get; set; }
    public DateTime EndDae { get; set; }
    public bool IsComleted { get; set; }

}
