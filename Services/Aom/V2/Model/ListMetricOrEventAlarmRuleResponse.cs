using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMetricOrEventAlarmRuleResponse : SdkResponse
    {

        /// <summary>
        /// 告警规则列表。
        /// </summary>
        [JsonProperty("alarm_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmParamForV4Db> AlarmRules { get; set; }

        /// <summary>
        /// 元数据信息。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Object Metadata { get; set; }

        /// <summary>
        /// 告警规则数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMetricOrEventAlarmRuleResponse {\n");
            sb.Append("  alarmRules: ").Append(AlarmRules).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMetricOrEventAlarmRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMetricOrEventAlarmRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmRules == input.AlarmRules ||
                    this.AlarmRules != null &&
                    input.AlarmRules != null &&
                    this.AlarmRules.SequenceEqual(input.AlarmRules)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.AlarmRules != null)
                    hashCode = hashCode * 59 + this.AlarmRules.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
