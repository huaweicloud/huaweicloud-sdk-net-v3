using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmNotifyResponse : SdkResponse
    {

        /// <summary>
        /// 告警通知列表。
        /// </summary>
        [JsonProperty("front_alarm_notify_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrontAlarmNotifyResult> FrontAlarmNotifyResults { get; set; }

        /// <summary>
        /// 消息总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmNotifyResponse {\n");
            sb.Append("  frontAlarmNotifyResults: ").Append(FrontAlarmNotifyResults).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmNotifyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmNotifyResponse input)
        {
            if (input == null) return false;
            if (this.FrontAlarmNotifyResults != input.FrontAlarmNotifyResults || (this.FrontAlarmNotifyResults != null && input.FrontAlarmNotifyResults != null && !this.FrontAlarmNotifyResults.SequenceEqual(input.FrontAlarmNotifyResults))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.FrontAlarmNotifyResults != null) hashCode = hashCode * 59 + this.FrontAlarmNotifyResults.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
