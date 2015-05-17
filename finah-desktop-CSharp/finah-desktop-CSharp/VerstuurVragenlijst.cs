using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    class VerstuurVragenlijst
    {

        private DbFunctions dbfunctions = new DbFunctions();

        public String sendMessage(int patientId, int mantelzorgerId, int rapportId, int vragenlijstId)
        {
            Patientmantelzorger patient = dbfunctions.loadPatientMantelzorger(patientId).First();
            Patientmantelzorger mantelzorger = dbfunctions.loadPatientMantelzorger(mantelzorgerId).First();

            // Create the email object first, then add the properties.
            SendGridMessage messageToPatient = new SendGridMessage();
            messageToPatient.AddTo(patient.Email);
            messageToPatient.From = new MailAddress("mail@finah.com", "Finah");
            messageToPatient.Subject = "Finah vragenlijst";
            messageToPatient.Text = "Beste " + patient.Vnaam + " " + patient.Anaam + ", \n\n"
                + "via volgende link kom je uit op je finah-vragenlijst: \n\n"
                + "http://webclientfinah.azurewebsites.net/?verzorger=false&rapportId=" + rapportId + "&vragenlijstId=" + vragenlijstId +
                "\n\n Mvg, \n\n Finah";

            // Create the email object first, then add the properties.
            SendGridMessage messageToMantelzorger = new SendGridMessage();
            messageToMantelzorger.AddTo(mantelzorger.Email);
            messageToMantelzorger.From = new MailAddress("mail@finah.com", "Finah");
            messageToMantelzorger.Subject = "Finah vragenlijst";
            messageToMantelzorger.Text = "Beste " + mantelzorger.Vnaam + " " + mantelzorger.Anaam + ", \n\n"
                + "via volgende link kom je uit op je finah-vragenlijst voor je patiënt " + patient.Vnaam + " " + patient.Anaam + ": \n\n"
                + "http://webclientfinah.azurewebsites.net/?verzorger=true&rapportId=" + rapportId + "&vragenlijstId=" + vragenlijstId +
                "\n\n Mvg, \n\n Finah";

            // Create credentials, specifying your user name and password.
            var credentials = new NetworkCredential("azure_73831b50370c5a0dbf1553c548f93e44@azure.com", "2zylOlXk4oYhh1l");

            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the emails.
            transportWeb.DeliverAsync(messageToPatient);
            transportWeb.DeliverAsync(messageToMantelzorger);

            return "Email was sent succesfully!";
        }
    }
}
