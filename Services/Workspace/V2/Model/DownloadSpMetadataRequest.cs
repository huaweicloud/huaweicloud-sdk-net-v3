using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DownloadSpMetadataRequest 
    {

        /// <summary>
        /// 身份提供者名称。
        /// </summary>
        [SDKProperty("identity_provider", IsQuery = true)]
        [JsonProperty("identity_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityProvider { get; set; }

        /// <summary>
        /// 接入服务器地址。
        /// </summary>
        [SDKProperty("access_server_address", IsQuery = true)]
        [JsonProperty("access_server_address", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessServerAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadSpMetadataRequest {\n");
            sb.Append("  identityProvider: ").Append(IdentityProvider).Append("\n");
            sb.Append("  accessServerAddress: ").Append(AccessServerAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadSpMetadataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadSpMetadataRequest input)
        {
            if (input == null) return false;
            if (this.IdentityProvider != input.IdentityProvider || (this.IdentityProvider != null && !this.IdentityProvider.Equals(input.IdentityProvider))) return false;
            if (this.AccessServerAddress != input.AccessServerAddress || (this.AccessServerAddress != null && !this.AccessServerAddress.Equals(input.AccessServerAddress))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.IdentityProvider != null) hashCode = hashCode * 59 + this.IdentityProvider.GetHashCode();
                if (this.AccessServerAddress != null) hashCode = hashCode * 59 + this.AccessServerAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
