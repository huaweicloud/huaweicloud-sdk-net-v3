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
    public class ServerlessInfoResponse 
    {

        /// <summary>
        /// Serverless型实例的算力范围最小值。取值范围：0.5 ~ 8，单位：RCU。
        /// </summary>
        [JsonProperty("min_compute_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string MinComputeUnit { get; set; }

        /// <summary>
        /// Serverless型实例的算力范围最大值。取值范围：0.5 ~ 8，单位：RCU。
        /// </summary>
        [JsonProperty("max_compute_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxComputeUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerlessInfoResponse {\n");
            sb.Append("  minComputeUnit: ").Append(MinComputeUnit).Append("\n");
            sb.Append("  maxComputeUnit: ").Append(MaxComputeUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerlessInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerlessInfoResponse input)
        {
            if (input == null) return false;
            if (this.MinComputeUnit != input.MinComputeUnit || (this.MinComputeUnit != null && !this.MinComputeUnit.Equals(input.MinComputeUnit))) return false;
            if (this.MaxComputeUnit != input.MaxComputeUnit || (this.MaxComputeUnit != null && !this.MaxComputeUnit.Equals(input.MaxComputeUnit))) return false;

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
                if (this.MinComputeUnit != null) hashCode = hashCode * 59 + this.MinComputeUnit.GetHashCode();
                if (this.MaxComputeUnit != null) hashCode = hashCode * 59 + this.MaxComputeUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
