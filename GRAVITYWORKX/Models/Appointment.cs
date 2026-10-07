namespace GRAVITYWORKX.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int vechicleID { get; set; }
        public string Service {  get; set; }

        public string Status { get; set; }
        public DateTime? AppointmentDate { get; set; }
    }
}
