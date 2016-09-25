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
    /// The type RemoteItem.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RemoteItem
    {
    
        /// <summary>
        /// Gets or sets file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "file", Required = Required.Default)]
        public File File { get; set; }
    
        /// <summary>
        /// Gets or sets fileSystemInfo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileSystemInfo", Required = Required.Default)]
        public FileSystemInfo FileSystemInfo { get; set; }
    
        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "folder", Required = Required.Default)]
        public Folder Folder { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets parentReference.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentReference", Required = Required.Default)]
        public ItemReference ParentReference { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "size", Required = Required.Default)]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}