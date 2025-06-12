using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 语音驱动时的动作标签配置
    /// </summary>
    public class AudioDriveActionConfig 
    {

        /// <summary>
        /// 动作标签
        /// </summary>
        [JsonProperty("action_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionTag { get; set; }

        /// <summary>
        /// 动作名称
        /// </summary>
        [JsonProperty("action_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionName { get; set; }

        /// <summary>
        /// 动作开始时间
        /// </summary>
        [JsonProperty("action_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? ActionStartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioDriveActionConfig {\n");
            sb.Append("  actionTag: ").Append(ActionTag).Append("\n");
            sb.Append("  actionName: ").Append(ActionName).Append("\n");
            sb.Append("  actionStartTime: ").Append(ActionStartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioDriveActionConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioDriveActionConfig input)
        {
            if (input == null) return false;
            if (this.ActionTag != input.ActionTag || (this.ActionTag != null && !this.ActionTag.Equals(input.ActionTag))) return false;
            if (this.ActionName != input.ActionName || (this.ActionName != null && !this.ActionName.Equals(input.ActionName))) return false;
            if (this.ActionStartTime != input.ActionStartTime || (this.ActionStartTime != null && !this.ActionStartTime.Equals(input.ActionStartTime))) return false;

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
                if (this.ActionTag != null) hashCode = hashCode * 59 + this.ActionTag.GetHashCode();
                if (this.ActionName != null) hashCode = hashCode * 59 + this.ActionName.GetHashCode();
                if (this.ActionStartTime != null) hashCode = hashCode * 59 + this.ActionStartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
