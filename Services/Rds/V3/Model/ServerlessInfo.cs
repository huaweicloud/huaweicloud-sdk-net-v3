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
    /// 
    /// </summary>
    public class ServerlessInfo 
    {

        /// <summary>
        /// Serverless型实例的最小算力，单位RCU，范围0.5~8，步进0.5。
        /// </summary>
        [JsonProperty("min_cap", NullValueHandling = NullValueHandling.Ignore)]
        public string MinCap { get; set; }

        /// <summary>
        /// Serverless型实例的最大算力，单位RCU，范围0.5~8，步进0.5。
        /// </summary>
        [JsonProperty("max_cap", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxCap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerlessInfo {\n");
            sb.Append("  minCap: ").Append(MinCap).Append("\n");
            sb.Append("  maxCap: ").Append(MaxCap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerlessInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerlessInfo input)
        {
            if (input == null) return false;
            if (this.MinCap != input.MinCap || (this.MinCap != null && !this.MinCap.Equals(input.MinCap))) return false;
            if (this.MaxCap != input.MaxCap || (this.MaxCap != null && !this.MaxCap.Equals(input.MaxCap))) return false;

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
                if (this.MinCap != null) hashCode = hashCode * 59 + this.MinCap.GetHashCode();
                if (this.MaxCap != null) hashCode = hashCode * 59 + this.MaxCap.GetHashCode();
                return hashCode;
            }
        }
    }
}
