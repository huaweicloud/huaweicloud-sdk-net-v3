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
    public class ListServiceSpecificCredentialSupportedServicesV5Response : SdkResponse
    {

        /// <summary>
        /// 服务专属凭证所属云服务信息列表。
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportedService> Services { get; set; }

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
            sb.Append("class ListServiceSpecificCredentialSupportedServicesV5Response {\n");
            sb.Append("  services: ").Append(Services).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServiceSpecificCredentialSupportedServicesV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServiceSpecificCredentialSupportedServicesV5Response input)
        {
            if (input == null) return false;
            if (this.Services != input.Services || (this.Services != null && input.Services != null && !this.Services.SequenceEqual(input.Services))) return false;
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
                if (this.Services != null) hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
