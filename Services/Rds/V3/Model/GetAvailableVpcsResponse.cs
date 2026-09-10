using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetAvailableVpcsResponse : SdkResponse
    {

        /// <summary>
        /// 可用的VPC列表
        /// </summary>
        [JsonProperty("vpcs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Vpc> Vpcs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-TRACE-ID", IsHeader = true)]
        [JsonProperty("X-TRACE-ID", NullValueHandling = NullValueHandling.Ignore)]
        public string XTraceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAvailableVpcsResponse {\n");
            sb.Append("  vpcs: ").Append(Vpcs).Append("\n");
            sb.Append("  xTraceId: ").Append(XTraceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetAvailableVpcsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetAvailableVpcsResponse input)
        {
            if (input == null) return false;
            if (this.Vpcs != input.Vpcs || (this.Vpcs != null && input.Vpcs != null && !this.Vpcs.SequenceEqual(input.Vpcs))) return false;
            if (this.XTraceId != input.XTraceId || (this.XTraceId != null && !this.XTraceId.Equals(input.XTraceId))) return false;

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
                if (this.Vpcs != null) hashCode = hashCode * 59 + this.Vpcs.GetHashCode();
                if (this.XTraceId != null) hashCode = hashCode * 59 + this.XTraceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
