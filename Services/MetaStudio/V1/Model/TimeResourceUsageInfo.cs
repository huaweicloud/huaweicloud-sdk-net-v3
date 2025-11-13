using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeResourceUsageInfo 
    {

        /// <summary>
        /// 查询时间段开始时间,格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 资源用量列表
        /// </summary>
        [JsonProperty("resources_usage", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceUsageInfo> ResourcesUsage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeResourceUsageInfo {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  resourcesUsage: ").Append(ResourcesUsage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimeResourceUsageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TimeResourceUsageInfo input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.ResourcesUsage != input.ResourcesUsage || (this.ResourcesUsage != null && input.ResourcesUsage != null && !this.ResourcesUsage.SequenceEqual(input.ResourcesUsage))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.ResourcesUsage != null) hashCode = hashCode * 59 + this.ResourcesUsage.GetHashCode();
                return hashCode;
            }
        }
    }
}
