using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 基于会话的弹性策略。
    /// </summary>
    public class ScalingPolicyBySession 
    {

        /// <summary>
        /// 分组的总会话使用率(达到该阈值后扩容)。
        /// </summary>
        [JsonProperty("session_usage_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionUsageThreshold { get; set; }

        /// <summary>
        /// 给定时间内无会话连接的的实例进行释放。
        /// </summary>
        [JsonProperty("shrink_after_session_idle_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShrinkAfterSessionIdleMinutes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingPolicyBySession {\n");
            sb.Append("  sessionUsageThreshold: ").Append(SessionUsageThreshold).Append("\n");
            sb.Append("  shrinkAfterSessionIdleMinutes: ").Append(ShrinkAfterSessionIdleMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingPolicyBySession);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingPolicyBySession input)
        {
            if (input == null) return false;
            if (this.SessionUsageThreshold != input.SessionUsageThreshold || (this.SessionUsageThreshold != null && !this.SessionUsageThreshold.Equals(input.SessionUsageThreshold))) return false;
            if (this.ShrinkAfterSessionIdleMinutes != input.ShrinkAfterSessionIdleMinutes || (this.ShrinkAfterSessionIdleMinutes != null && !this.ShrinkAfterSessionIdleMinutes.Equals(input.ShrinkAfterSessionIdleMinutes))) return false;

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
                if (this.SessionUsageThreshold != null) hashCode = hashCode * 59 + this.SessionUsageThreshold.GetHashCode();
                if (this.ShrinkAfterSessionIdleMinutes != null) hashCode = hashCode * 59 + this.ShrinkAfterSessionIdleMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
