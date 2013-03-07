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
        public StatusItemModel clientSatisfaction { get; set; }
        public StatusItemModel issuesAndRisks { get; set; }
        public StatusItemModel useOfTestControl { get; set; }
        public StatusItemModel employeeSatisfactionIssues { get; set; }

        public DeliveryModel()
        {
        }

        public DeliveryModel(StatusItemModel deliverablesAndResults, StatusItemModel schedule, StatusItemModel capacityResources,
            StatusItemModel scope, StatusItemModel clientSatisfaction, StatusItemModel issuesAndRisks, StatusItemModel useOfTestControl,
            StatusItemModel employeeSatisfactionIssues)
        {
            this.deliverablesAndResults = deliverablesAndResults;
            this.schedule = schedule;
            this.capacityResources = capacityResources;
            this.scope = scope;
            this.clientSatisfaction = clientSatisfaction;
            this.issuesAndRisks = issuesAndRisks;
            this.useOfTestControl = useOfTestControl;
            this.employeeSatisfactionIssues = employeeSatisfactionIssues;
        }

    }
}