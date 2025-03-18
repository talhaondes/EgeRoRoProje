using Entity.Concrete;

namespace UI.Models
{
    public class ServiceDetailViewModel
    {
        public List<Service> AllServices { get; set; }
        public Service SelectedService { get; set; }
    }
}
