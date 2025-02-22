﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ------------------------------------

using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.SecurityInsights.Common;
using Microsoft.Azure.Commands.SecurityInsights.Models.Incidents;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using System.Linq;
using Microsoft.Azure.Management.SecurityInsights;

namespace Microsoft.Azure.Commands.SecurityInsights.Cmdlets.Incidents
{
    [Cmdlet(VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SentinelIncident", DefaultParameterSetName = ParameterSetNames.WorkspaceScope), OutputType(typeof(PSSentinelIncident))]
    public class GetIncidents : SecurityInsightsCmdletBase
    {
        [Parameter(ParameterSetName = ParameterSetNames.WorkspaceScope, Mandatory = true, HelpMessage = ParameterHelpMessages.ResourceGroupName)]
        [Parameter(ParameterSetName = ParameterSetNames.IncidentId, Mandatory = true, HelpMessage = ParameterHelpMessages.ResourceGroupName)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.WorkspaceScope, Mandatory = true, HelpMessage = ParameterHelpMessages.WorkspaceName)]
        [Parameter(ParameterSetName = ParameterSetNames.IncidentId, Mandatory = true, HelpMessage = ParameterHelpMessages.WorkspaceName)]
        [ValidateNotNullOrEmpty]
        public string WorkspaceName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.IncidentId, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.IncidentId)]
        [ValidateNotNullOrEmpty]
        public string IncidentId { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.WorkspaceScope, Mandatory = false, ValueFromPipeline = false, HelpMessage = ParameterHelpMessages.Filter)]
        public string Filter { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.WorkspaceScope, Mandatory = false, ValueFromPipeline = false, HelpMessage = ParameterHelpMessages.OrderBy)]
        public string OrderBy { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.WorkspaceScope, Mandatory = false, ValueFromPipeline = false, HelpMessage = ParameterHelpMessages.Max)]
        [ValidateRange(1, int.MaxValue)]
        public int Max { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ResourceId, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.ResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        public override void ExecuteCmdlet()
        {
            string nextLink = null;
            switch (ParameterSetName)
            {
                case ParameterSetNames.WorkspaceScope:
                    string filter = (Filter == default(string)) ? null : Filter;
                    string orderby = (OrderBy == default(string)) ? null : OrderBy;
                    int max = (Max == default(int)) ? 1000 : Max;
                    var incidents = SecurityInsightsClient.Incidents.List(ResourceGroupName, WorkspaceName, filter: filter, orderby: orderby);
                    var incidentscount = incidents.Count();
                    WriteObject(incidents.ConvertToPSType(), enumerateCollection: true);
                    nextLink = incidents?.NextPageLink;
                    while (!string.IsNullOrWhiteSpace(nextLink) && incidentscount < max)
                    {
                        incidents = SecurityInsightsClient.Incidents.ListNext(incidents.NextPageLink);
                        WriteObject(incidents.ConvertToPSType(), enumerateCollection: true);
                        incidentscount += incidents.Count();
                        nextLink = incidents?.NextPageLink;
                    }
                    break;
                case ParameterSetNames.IncidentId:
                    var incident = SecurityInsightsClient.Incidents.Get(ResourceGroupName, WorkspaceName, IncidentId);
                    WriteObject(incident.ConvertToPSType(), enumerateCollection: false);
                    break;
                case ParameterSetNames.ResourceId:
                    incident = SecurityInsightsClient.Incidents.Get(ResourceGroupName, WorkspaceName, AzureIdUtilities.GetResourceName(ResourceId));
                    WriteObject(incident.ConvertToPSType(), enumerateCollection: false);
                    break;
                default:
                    throw new PSInvalidOperationException();
            }
        }
    }
}
