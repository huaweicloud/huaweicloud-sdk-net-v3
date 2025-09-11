using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAuditTopicReportSchedulerConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduler", NullValueHandling = NullValueHandling.Ignore)]
        public SchedulerConfigBase Scheduler { get; set; }

        /// <summary>
        /// 是否支持订阅  - true: 支持  - false: 不支持\&quot;
        /// </summary>
        [JsonProperty("smn_effective", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmnEffective { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditTopicReportSchedulerConfigResponse {\n");
            sb.Append("  scheduler: ").Append(Scheduler).Append("\n");
            sb.Append("  smnEffective: ").Append(SmnEffective).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditTopicReportSchedulerConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditTopicReportSchedulerConfigResponse input)
        {
            if (input == null) return false;
            if (this.Scheduler != input.Scheduler || (this.Scheduler != null && !this.Scheduler.Equals(input.Scheduler))) return false;
            if (this.SmnEffective != input.SmnEffective || (this.SmnEffective != null && !this.SmnEffective.Equals(input.SmnEffective))) return false;

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
                if (this.Scheduler != null) hashCode = hashCode * 59 + this.Scheduler.GetHashCode();
                if (this.SmnEffective != null) hashCode = hashCode * 59 + this.SmnEffective.GetHashCode();
                return hashCode;
            }
        }
    }
}
