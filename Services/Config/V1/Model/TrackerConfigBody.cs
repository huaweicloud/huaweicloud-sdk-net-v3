using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// TrackerConfig对象
    /// </summary>
    public class TrackerConfigBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelConfigBody Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("selector", NullValueHandling = NullValueHandling.Ignore)]
        public SelectorConfigBody Selector { get; set; }

        /// <summary>
        /// 存储历史信息的天数
        /// </summary>
        [JsonProperty("retention_period_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionPeriodInDays { get; set; }

        /// <summary>
        /// IAM委托名称
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackerConfigBody {\n");
            sb.Append("  channel: ").Append(Channel).Append("\n");
            sb.Append("  selector: ").Append(Selector).Append("\n");
            sb.Append("  retentionPeriodInDays: ").Append(RetentionPeriodInDays).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrackerConfigBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrackerConfigBody input)
        {
            if (input == null) return false;
            if (this.Channel != input.Channel || (this.Channel != null && !this.Channel.Equals(input.Channel))) return false;
            if (this.Selector != input.Selector || (this.Selector != null && !this.Selector.Equals(input.Selector))) return false;
            if (this.RetentionPeriodInDays != input.RetentionPeriodInDays || (this.RetentionPeriodInDays != null && !this.RetentionPeriodInDays.Equals(input.RetentionPeriodInDays))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;

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
                if (this.Channel != null) hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Selector != null) hashCode = hashCode * 59 + this.Selector.GetHashCode();
                if (this.RetentionPeriodInDays != null) hashCode = hashCode * 59 + this.RetentionPeriodInDays.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
