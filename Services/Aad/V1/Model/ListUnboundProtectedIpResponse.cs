using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListUnboundProtectedIpResponse : SdkResponse
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 防护ip列表
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProtectedIpResponse> Ips { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUnboundProtectedIpResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  ips: ").Append(Ips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUnboundProtectedIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUnboundProtectedIpResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    input.Ips != null &&
                    this.Ips.SequenceEqual(input.Ips)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                return hashCode;
            }
        }
    }
}
