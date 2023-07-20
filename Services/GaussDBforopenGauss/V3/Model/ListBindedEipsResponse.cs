using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBindedEipsResponse : SdkResponse
    {

        /// <summary>
        /// 查询实例已绑定EIP列表。
        /// </summary>
        [JsonProperty("public_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<BindedEipResult> PublicIps { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBindedEipsResponse {\n");
            sb.Append("  publicIps: ").Append(PublicIps).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBindedEipsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBindedEipsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicIps == input.PublicIps ||
                    this.PublicIps != null &&
                    input.PublicIps != null &&
                    this.PublicIps.SequenceEqual(input.PublicIps)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.PublicIps != null)
                    hashCode = hashCode * 59 + this.PublicIps.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
