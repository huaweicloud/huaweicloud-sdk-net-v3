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
    /// 修改安抚话术等待触发时长。
    /// </summary>
    public class UpdatePacifyWordsTriggerTimeReq 
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 安抚话术等待触发时长，单位毫秒
        /// </summary>
        [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TriggerTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePacifyWordsTriggerTimeReq {\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  triggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePacifyWordsTriggerTimeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePacifyWordsTriggerTimeReq input)
        {
            if (input == null) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.Language != input.Language) return false;
            if (this.TriggerTime != input.TriggerTime || (this.TriggerTime != null && !this.TriggerTime.Equals(input.TriggerTime))) return false;

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
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TriggerTime != null) hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
