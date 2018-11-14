// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AndroidForWorkSettingsRequestBuilder.
    /// </summary>
    public partial class AndroidForWorkSettingsRequestBuilder : EntityRequestBuilder, IAndroidForWorkSettingsRequestBuilder
    {

        /// <summary>
        /// Constructs a new AndroidForWorkSettingsRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AndroidForWorkSettingsRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAndroidForWorkSettingsRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAndroidForWorkSettingsRequest Request(IEnumerable<Option> options)
        {
            return new AndroidForWorkSettingsRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AndroidForWorkSettingsRequestSignupUrl.
        /// </summary>
        /// <returns>The <see cref="IAndroidForWorkSettingsRequestSignupUrlRequestBuilder"/>.</returns>
        public IAndroidForWorkSettingsRequestSignupUrlRequestBuilder RequestSignupUrl(
            string hostName = null)
        {
            return new AndroidForWorkSettingsRequestSignupUrlRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.requestSignupUrl"),
                this.Client,
                hostName);
        }

        /// <summary>
        /// Gets the request builder for AndroidForWorkSettingsCompleteSignup.
        /// </summary>
        /// <returns>The <see cref="IAndroidForWorkSettingsCompleteSignupRequestBuilder"/>.</returns>
        public IAndroidForWorkSettingsCompleteSignupRequestBuilder CompleteSignup(
            string enterpriseToken = null)
        {
            return new AndroidForWorkSettingsCompleteSignupRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.completeSignup"),
                this.Client,
                enterpriseToken);
        }

        /// <summary>
        /// Gets the request builder for AndroidForWorkSettingsSyncApps.
        /// </summary>
        /// <returns>The <see cref="IAndroidForWorkSettingsSyncAppsRequestBuilder"/>.</returns>
        public IAndroidForWorkSettingsSyncAppsRequestBuilder SyncApps()
        {
            return new AndroidForWorkSettingsSyncAppsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.syncApps"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AndroidForWorkSettingsUnbind.
        /// </summary>
        /// <returns>The <see cref="IAndroidForWorkSettingsUnbindRequestBuilder"/>.</returns>
        public IAndroidForWorkSettingsUnbindRequestBuilder Unbind()
        {
            return new AndroidForWorkSettingsUnbindRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unbind"),
                this.Client);
        }
    
    }
}