// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Office365Groups Activity Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Office365GroupsActivityDetail : Entity
    {
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets group display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string GroupDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeleted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets owner principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string OwnerPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets group type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupType", Required = Newtonsoft.Json.Required.Default)]
        public string GroupType { get; set; }
    
        /// <summary>
        /// Gets or sets member count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? MemberCount { get; set; }
    
        /// <summary>
        /// Gets or sets external member count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalMemberCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ExternalMemberCount { get; set; }
    
        /// <summary>
        /// Gets or sets exchange received email count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeReceivedEmailCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ExchangeReceivedEmailCount { get; set; }
    
        /// <summary>
        /// Gets or sets share point active file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePointActiveFileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharePointActiveFileCount { get; set; }
    
        /// <summary>
        /// Gets or sets yammer posted message count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yammerPostedMessageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? YammerPostedMessageCount { get; set; }
    
        /// <summary>
        /// Gets or sets yammer read message count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yammerReadMessageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? YammerReadMessageCount { get; set; }
    
        /// <summary>
        /// Gets or sets yammer liked message count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yammerLikedMessageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? YammerLikedMessageCount { get; set; }
    
        /// <summary>
        /// Gets or sets exchange mailbox total item count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeMailboxTotalItemCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ExchangeMailboxTotalItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets exchange mailbox storage used in bytes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeMailboxStorageUsedInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ExchangeMailboxStorageUsedInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets share point total file count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePointTotalFileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharePointTotalFileCount { get; set; }
    
        /// <summary>
        /// Gets or sets share point site storage used in bytes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePointSiteStorageUsedInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? SharePointSiteStorageUsedInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}
