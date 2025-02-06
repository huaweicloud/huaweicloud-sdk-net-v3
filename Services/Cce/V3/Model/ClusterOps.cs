using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** 集群运维参数配置。 **约束限制：** 不涉及
    /// </summary>
    public class ClusterOps 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmInfo Alarm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterOps {\n");
            sb.Append("  alarm: ").Append(Alarm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterOps);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterOps input)
        {
            if (input == null) return false;
            if (this.Alarm != input.Alarm || (this.Alarm != null && !this.Alarm.Equals(input.Alarm))) return false;

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
                if (this.Alarm != null) hashCode = hashCode * 59 + this.Alarm.GetHashCode();
                return hashCode;
            }
        }
    }
}
