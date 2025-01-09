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
    /// 返回时区配置信息
    /// </summary>
    public class Timezones 
    {

        /// <summary>
        /// 时区描述
        /// </summary>
        [JsonProperty("time_zone_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneDesc { get; set; }

        /// <summary>
        /// 时区偏移量
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 时区地名
        /// </summary>
        [JsonProperty("time_zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneName { get; set; }

        /// <summary>
        /// 时区英文描述
        /// </summary>
        [JsonProperty("time_zone_desc_us", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneDescUs { get; set; }

        /// <summary>
        /// 时区中文描述
        /// </summary>
        [JsonProperty("time_zone_desc_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneDescCn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Timezones {\n");
            sb.Append("  timeZoneDesc: ").Append(TimeZoneDesc).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  timeZoneName: ").Append(TimeZoneName).Append("\n");
            sb.Append("  timeZoneDescUs: ").Append(TimeZoneDescUs).Append("\n");
            sb.Append("  timeZoneDescCn: ").Append(TimeZoneDescCn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Timezones);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Timezones input)
        {
            if (input == null) return false;
            if (this.TimeZoneDesc != input.TimeZoneDesc || (this.TimeZoneDesc != null && !this.TimeZoneDesc.Equals(input.TimeZoneDesc))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.TimeZoneName != input.TimeZoneName || (this.TimeZoneName != null && !this.TimeZoneName.Equals(input.TimeZoneName))) return false;
            if (this.TimeZoneDescUs != input.TimeZoneDescUs || (this.TimeZoneDescUs != null && !this.TimeZoneDescUs.Equals(input.TimeZoneDescUs))) return false;
            if (this.TimeZoneDescCn != input.TimeZoneDescCn || (this.TimeZoneDescCn != null && !this.TimeZoneDescCn.Equals(input.TimeZoneDescCn))) return false;

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
                if (this.TimeZoneDesc != null) hashCode = hashCode * 59 + this.TimeZoneDesc.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TimeZoneName != null) hashCode = hashCode * 59 + this.TimeZoneName.GetHashCode();
                if (this.TimeZoneDescUs != null) hashCode = hashCode * 59 + this.TimeZoneDescUs.GetHashCode();
                if (this.TimeZoneDescCn != null) hashCode = hashCode * 59 + this.TimeZoneDescCn.GetHashCode();
                return hashCode;
            }
        }
    }
}
