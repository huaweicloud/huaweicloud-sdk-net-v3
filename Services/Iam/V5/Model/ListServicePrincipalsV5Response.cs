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
    public class ListServicePrincipalsV5Response : SdkResponse
    {

        /// <summary>
        /// 服务主体列表。
        /// </summary>
        [JsonProperty("service_principals", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServicePrincipalMetadata> ServicePrincipals { get; set; }

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
            sb.Append("class ListServicePrincipalsV5Response {\n");
            sb.Append("  servicePrincipals: ").Append(ServicePrincipals).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServicePrincipalsV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServicePrincipalsV5Response input)
        {
            if (input == null) return false;
            if (this.ServicePrincipals != input.ServicePrincipals || (this.ServicePrincipals != null && input.ServicePrincipals != null && !this.ServicePrincipals.SequenceEqual(input.ServicePrincipals))) return false;
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
                if (this.ServicePrincipals != null) hashCode = hashCode * 59 + this.ServicePrincipals.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
