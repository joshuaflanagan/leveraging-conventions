using FubuMVC.Core;
using MyApp.Models;

namespace MyApp.Actions
{
    public class Home
    {
        public IndexResponse Index()
        {
            return new IndexResponse();
        }

        public EditPatientResponse EditPatient(EditPatientRequest request)
        {
            return new EditPatientResponse();
        }

        public MakeAppointmentResponse MakeAppointment(MakeAppointmentRequest request)
        {
            return new MakeAppointmentResponse();
        }

        public HelpResponse Help(HelpRequest request)
        {
            return new HelpResponse{Topic = request.Topic};
        }
    }

    public class HelpResponse
    {
        public string Topic { get; set; }
    }

    public class HelpRequest
    {
        [QueryString]
        public string Topic { get; set; }
    }

    public class MakeAppointmentRequest {}

    public class MakeAppointmentResponse
    {
        public Appointment Appointment { get; set; }
    }

    public class EditPatientRequest {}

    public class EditPatientResponse
    {
        public Patient Patient { get; set; }
    }

    public class IndexResponse {}
}