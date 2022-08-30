using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }//toplam kişi sayısı
        public string RezervastionDate { get; set; }//rezervasyon tarihi
        public string Description { get; set; }//Kişi açıklaması
        public string Status { get; set; }//Rezervasyonun onaylanıp onaylanmadığı bilgisi
        public int DestinationId { get; set; }
        public Destination Destination{ get; set; }
    }
}
