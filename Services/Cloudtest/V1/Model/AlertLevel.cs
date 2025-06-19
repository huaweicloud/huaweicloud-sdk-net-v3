using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlertLevel 
    {

        /// <summary>
        /// 告警渠道列表
        /// </summary>
        [JsonProperty("alert_channel", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlertChannel { get; set; }

        /// <summary>
        /// 告警组列表
        /// </summary>
        [JsonProperty("alertGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlertGroup> AlertGroups { get; set; }

        /// <summary>
        /// 告警模板ID
        /// </summary>
        [JsonProperty("alertTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertTemplateId { get; set; }

        /// <summary>
        /// 告警次数
        /// </summary>
        [JsonProperty("alertTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertLevel {\n");
            sb.Append("  alertChannel: ").Append(AlertChannel).Append("\n");
            sb.Append("  alertGroups: ").Append(AlertGroups).Append("\n");
            sb.Append("  alertTemplateId: ").Append(AlertTemplateId).Append("\n");
            sb.Append("  alertTimes: ").Append(AlertTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertLevel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlertLevel input)
        {
            if (input == null) return false;
            if (this.AlertChannel != input.AlertChannel || (this.AlertChannel != null && input.AlertChannel != null && !this.AlertChannel.SequenceEqual(input.AlertChannel))) return false;
            if (this.AlertGroups != input.AlertGroups || (this.AlertGroups != null && input.AlertGroups != null && !this.AlertGroups.SequenceEqual(input.AlertGroups))) return false;
            if (this.AlertTemplateId != input.AlertTemplateId || (this.AlertTemplateId != null && !this.AlertTemplateId.Equals(input.AlertTemplateId))) return false;
            if (this.AlertTimes != input.AlertTimes || (this.AlertTimes != null && !this.AlertTimes.Equals(input.AlertTimes))) return false;

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
                if (this.AlertChannel != null) hashCode = hashCode * 59 + this.AlertChannel.GetHashCode();
                if (this.AlertGroups != null) hashCode = hashCode * 59 + this.AlertGroups.GetHashCode();
                if (this.AlertTemplateId != null) hashCode = hashCode * 59 + this.AlertTemplateId.GetHashCode();
                if (this.AlertTimes != null) hashCode = hashCode * 59 + this.AlertTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
