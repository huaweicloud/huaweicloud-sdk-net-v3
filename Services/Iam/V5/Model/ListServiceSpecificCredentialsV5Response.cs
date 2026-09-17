using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServiceSpecificCredentialsV5Response : SdkResponse
    {

        /// <summary>
        /// 服务专属凭证列表。
        /// </summary>
        [JsonProperty("service_specific_credentials", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceSpecificCredentialMetadata> ServiceSpecificCredentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServiceSpecificCredentialsV5Response {\n");
            sb.Append("  serviceSpecificCredentials: ").Append(ServiceSpecificCredentials).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServiceSpecificCredentialsV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServiceSpecificCredentialsV5Response input)
        {
            if (input == null) return false;
            if (this.ServiceSpecificCredentials != input.ServiceSpecificCredentials || (this.ServiceSpecificCredentials != null && input.ServiceSpecificCredentials != null && !this.ServiceSpecificCredentials.SequenceEqual(input.ServiceSpecificCredentials))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.ServiceSpecificCredentials != null) hashCode = hashCode * 59 + this.ServiceSpecificCredentials.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
