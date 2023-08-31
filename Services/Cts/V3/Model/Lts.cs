using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 云日志服务配置
    /// </summary>
    public class Lts 
    {

        /// <summary>
        /// 是否启用日志服务检索功能。
        /// </summary>
        [JsonProperty("is_lts_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLtsEnabled { get; set; }

        /// <summary>
        /// 云审计服务在日志服务中创建的日志组名称。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 云审计服务在日志服务中创建的日志主题名称。
        /// </summary>
        [JsonProperty("log_topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogTopicName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Lts {\n");
            sb.Append("  isLtsEnabled: ").Append(IsLtsEnabled).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logTopicName: ").Append(LogTopicName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Lts);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Lts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsLtsEnabled == input.IsLtsEnabled ||
                    (this.IsLtsEnabled != null &&
                    this.IsLtsEnabled.Equals(input.IsLtsEnabled))
                ) && 
                (
                    this.LogGroupName == input.LogGroupName ||
                    (this.LogGroupName != null &&
                    this.LogGroupName.Equals(input.LogGroupName))
                ) && 
                (
                    this.LogTopicName == input.LogTopicName ||
                    (this.LogTopicName != null &&
                    this.LogTopicName.Equals(input.LogTopicName))
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
                if (this.IsLtsEnabled != null)
                    hashCode = hashCode * 59 + this.IsLtsEnabled.GetHashCode();
                if (this.LogGroupName != null)
                    hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogTopicName != null)
                    hashCode = hashCode * 59 + this.LogTopicName.GetHashCode();
                return hashCode;
            }
        }
    }
}
