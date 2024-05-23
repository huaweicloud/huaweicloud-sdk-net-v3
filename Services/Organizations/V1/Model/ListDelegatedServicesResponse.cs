using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDelegatedServicesResponse : SdkResponse
    {

        /// <summary>
        /// 账号是其委托管理员的服务。
        /// </summary>
        [JsonProperty("delegated_services", NullValueHandling = NullValueHandling.Ignore)]
        public List<DelegatedServiceDto> DelegatedServices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDelegatedServicesResponse {\n");
            sb.Append("  delegatedServices: ").Append(DelegatedServices).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDelegatedServicesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDelegatedServicesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DelegatedServices == input.DelegatedServices ||
                    this.DelegatedServices != null &&
                    input.DelegatedServices != null &&
                    this.DelegatedServices.SequenceEqual(input.DelegatedServices)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DelegatedServices != null)
                    hashCode = hashCode * 59 + this.DelegatedServices.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
