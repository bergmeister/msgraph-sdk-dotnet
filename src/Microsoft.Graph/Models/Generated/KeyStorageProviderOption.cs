// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum KeyStorageProviderOption.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum KeyStorageProviderOption
    {
    
        /// <summary>
        /// use Tpm Ksp Otherwise Use Software Ksp
        /// </summary>
        UseTpmKspOtherwiseUseSoftwareKsp = 0,
	
        /// <summary>
        /// use Tpm Ksp Otherwise Fail
        /// </summary>
        UseTpmKspOtherwiseFail = 1,
	
        /// <summary>
        /// use Passport For Work Ksp Otherwise Fail
        /// </summary>
        UsePassportForWorkKspOtherwiseFail = 2,
	
        /// <summary>
        /// use Software Ksp
        /// </summary>
        UseSoftwareKsp = 3,
	
    }
}