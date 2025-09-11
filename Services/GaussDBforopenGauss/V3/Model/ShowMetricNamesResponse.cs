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
    public class ShowMetricNamesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 指标组名。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**: 指标分组名称信息。
        /// </summary>
        [JsonProperty("metric_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricNameResult> MetricNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetricNamesResponse {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  metricNames: ").Append(MetricNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetricNamesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetricNamesResponse input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.MetricNames != input.MetricNames || (this.MetricNames != null && input.MetricNames != null && !this.MetricNames.SequenceEqual(input.MetricNames))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.MetricNames != null) hashCode = hashCode * 59 + this.MetricNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
