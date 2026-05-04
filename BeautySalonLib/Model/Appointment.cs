using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonLib.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public int MasterId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Status { get; set; }
        public string ClientComment { get; set; }


        //Они нужны чтобы показывать пользователю имя клиента, а не ID
        public string ClientName { get; set; } 
        public string ServiceName { get; set; } 
        public string MasterName { get; set; } 
        public decimal ServicePrice { get; set; } 
    }
}
