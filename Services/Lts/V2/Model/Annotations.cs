using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Annotations 
    {

        /// <summary>
        /// 告警列表详情
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 日志组/流id,名称
        /// </summary>
        [JsonProperty("log_info", NullValueHandling = NullValueHandling.Ignore)]
        public string LogInfo { get; set; }

        /// <summary>
        /// 当前值
        /// </summary>
        [JsonProperty("current_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentValue { get; set; }

        /// <summary>
        /// (sql/关键词)告警详情原始数据
        /// </summary>
        [JsonProperty("old_annotations", NullValueHandling = NullValueHandling.Ignore)]
        public string OldAnnotations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Annotations {\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  logInfo: ").Append(LogInfo).Append("\n");
            sb.Append("  currentValue: ").Append(CurrentValue).Append("\n");
            sb.Append("  oldAnnotations: ").Append(OldAnnotations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Annotations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Annotations input)
        {
            if (input == null) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.LogInfo != input.LogInfo || (this.LogInfo != null && !this.LogInfo.Equals(input.LogInfo))) return false;
            if (this.CurrentValue != input.CurrentValue || (this.CurrentValue != null && !this.CurrentValue.Equals(input.CurrentValue))) return false;
            if (this.OldAnnotations != input.OldAnnotations || (this.OldAnnotations != null && !this.OldAnnotations.Equals(input.OldAnnotations))) return false;

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
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.LogInfo != null) hashCode = hashCode * 59 + this.LogInfo.GetHashCode();
                if (this.CurrentValue != null) hashCode = hashCode * 59 + this.CurrentValue.GetHashCode();
                if (this.OldAnnotations != null) hashCode = hashCode * 59 + this.OldAnnotations.GetHashCode();
                return hashCode;
            }
        }
    }
}
