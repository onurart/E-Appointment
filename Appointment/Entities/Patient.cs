using Appointment.Enums;

namespace Appointment.Entities;
public sealed class Patient
{
    public Patient()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => string.Join(",", FirstName, LastName);
    public string IdentitNumber { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Town { get; set; } = string.Empty;
    public string FullAddress { get; set; } = string.Empty;
    public DepartmentEnum Department { get; set; } = DepartmentEnum.Acil;
}
