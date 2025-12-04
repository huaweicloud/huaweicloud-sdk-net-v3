using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradeInstanceReq 
    {

        /// <summary>
        /// 是否作为定时任务执行。若非定时执行，is_schedule和execute_at字段可为空。若为定时执行，is_schedule为true，execute_at字段非空。
        /// </summary>
        [JsonProperty("is_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSchedule { get; set; }

        /// <summary>
        /// 定时时间，格式为Unix时间戳，单位为毫秒
        /// </summary>
        [JsonProperty("execute_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecuteAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeInstanceReq {\n");
            sb.Append("  isSchedule: ").Append(IsSchedule).Append("\n");
            sb.Append("  executeAt: ").Append(ExecuteAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeInstanceReq input)
        {
            if (input == null) return false;
            if (this.IsSchedule != input.IsSchedule || (this.IsSchedule != null && !this.IsSchedule.Equals(input.IsSchedule))) return false;
            if (this.ExecuteAt != input.ExecuteAt || (this.ExecuteAt != null && !this.ExecuteAt.Equals(input.ExecuteAt))) return false;

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
                if (this.IsSchedule != null) hashCode = hashCode * 59 + this.IsSchedule.GetHashCode();
                if (this.ExecuteAt != null) hashCode = hashCode * 59 + this.ExecuteAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
