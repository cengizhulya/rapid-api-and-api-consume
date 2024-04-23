using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please enter the room number")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Please enter the room price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter the room title")]
        [StringLength(100, ErrorMessage ="Please enter max 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the bed count")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter the bathroom count")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
