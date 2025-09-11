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
    /// 
    /// </summary>
    public class ConfigReportTopicRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduler", NullValueHandling = NullValueHandling.Ignore)]
        public SchedulerBean Scheduler { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigReportTopicRequest {\n");
            sb.Append("  scheduler: ").Append(Scheduler).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigReportTopicRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigReportTopicRequest input)
        {
            if (input == null) return false;
            if (this.Scheduler != input.Scheduler || (this.Scheduler != null && !this.Scheduler.Equals(input.Scheduler))) return false;

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
                return hashCode;
            }
        }
    }
}
