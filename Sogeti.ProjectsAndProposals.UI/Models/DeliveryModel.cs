using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sogeti.ProjectsAndProposals.UI.Models
{
    public class DeliveryModel
    {
        public StatusItemModel deliverablesAndResults { get; set; }
        public StatusItemModel schedule { get; set; }
        public StatusItemModel capacityResources { get; set; }
        public StatusItemModel scope { get; set; }

    }
}