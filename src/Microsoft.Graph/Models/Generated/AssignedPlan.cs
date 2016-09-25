// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AssignedPlan.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AssignedPlan
    {
    
        /// <summary>
        /// Gets or sets assignedDateTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedDateTime", Required = Required.Default)]
        public DateTimeOffset? AssignedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets capabilityStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "capabilityStatus", Required = Required.Default)]
        public string CapabilityStatus { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service", Required = Required.Default)]
        public string Service { get; set; }
    
        /// <summary>
        /// Gets or sets servicePlanId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePlanId", Required = Required.Default)]
        public Guid? ServicePlanId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}