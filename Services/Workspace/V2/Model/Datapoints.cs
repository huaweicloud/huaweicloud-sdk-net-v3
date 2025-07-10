using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面监控Cpu与Mem时间点信息。
    /// </summary>
    public class Datapoints 
    {

        /// <summary>
        /// 平均数值。
        /// </summary>
        [JsonProperty("average", NullValueHandling = NullValueHandling.Ignore)]
        public double? Average { get; set; }

        /// <summary>
        /// 时间戳。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Datapoints {\n");
            sb.Append("  average: ").Append(Average).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Datapoints);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Datapoints input)
        {
            if (input == null) return false;
            if (this.Average != input.Average || (this.Average != null && !this.Average.Equals(input.Average))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;

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
                if (this.Average != null) hashCode = hashCode * 59 + this.Average.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
