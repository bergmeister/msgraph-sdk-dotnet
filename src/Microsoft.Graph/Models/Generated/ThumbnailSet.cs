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
    /// The type Thumbnail Set.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ThumbnailSet : Entity
    {
    
        /// <summary>
        /// Gets or sets large.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "large", Required = Required.Default)]
        public Thumbnail Large { get; set; }
    
        /// <summary>
        /// Gets or sets medium.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "medium", Required = Required.Default)]
        public Thumbnail Medium { get; set; }
    
        /// <summary>
        /// Gets or sets small.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "small", Required = Required.Default)]
        public Thumbnail Small { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "source", Required = Required.Default)]
        public Thumbnail Source { get; set; }
    
    }
}
