using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Ip访问限频。
    /// </summary>
    public class IpFrequencyLimitQuery 
    {

        /// <summary>
        /// 状态，on：打开，off：关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 访问阈值，单位：次/秒。
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpFrequencyLimitQuery {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpFrequencyLimitQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpFrequencyLimitQuery input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Qps != input.Qps || (this.Qps != null && !this.Qps.Equals(input.Qps))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Qps != null) hashCode = hashCode * 59 + this.Qps.GetHashCode();
                return hashCode;
            }
        }
    }
}
