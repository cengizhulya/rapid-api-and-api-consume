using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Enter the service icon link ")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Enter the title of the service")]
        [StringLength(100, ErrorMessage = "Title of the service can be max 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter the description of the service")]
        [StringLength(100, ErrorMessage = "Description of the service can be max 500 characters")]
        public string Description { get; set; }
    }
}
