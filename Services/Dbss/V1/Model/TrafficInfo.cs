using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TrafficInfo 
    {

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 每秒钟接收字节数
        /// </summary>
        [JsonProperty("rxmegabytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Rxmegabytes { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 每秒钟发送字节数
        /// </summary>
        [JsonProperty("txmegabytes", NullValueHandling = NullValueHandling.Ignore)]
        public double? Txmegabytes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrafficInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  rxmegabytes: ").Append(Rxmegabytes).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  txmegabytes: ").Append(Txmegabytes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrafficInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrafficInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Rxmegabytes != input.Rxmegabytes || (this.Rxmegabytes != null && !this.Rxmegabytes.Equals(input.Rxmegabytes))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Txmegabytes != input.Txmegabytes || (this.Txmegabytes != null && !this.Txmegabytes.Equals(input.Txmegabytes))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Rxmegabytes != null) hashCode = hashCode * 59 + this.Rxmegabytes.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Txmegabytes != null) hashCode = hashCode * 59 + this.Txmegabytes.GetHashCode();
                return hashCode;
            }
        }
    }
}
