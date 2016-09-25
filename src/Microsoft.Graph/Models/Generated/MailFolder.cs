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
    /// The type Mail Folder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MailFolder : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets child folder count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "childFolderCount", Required = Required.Default)]
        public Int32? ChildFolderCount { get; set; }
    
        /// <summary>
        /// Gets or sets unread item count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unreadItemCount", Required = Required.Default)]
        public Int32? UnreadItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets total item count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalItemCount", Required = Required.Default)]
        public Int32? TotalItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messages", Required = Required.Default)]
        public IMailFolderMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets child folders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "childFolders", Required = Required.Default)]
        public IMailFolderChildFoldersCollectionPage ChildFolders { get; set; }
    
    }
}
