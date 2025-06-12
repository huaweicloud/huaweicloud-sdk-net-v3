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
    /// 修改热词功能开关请求。
    /// </summary>
    public class UpdateHotWordsSwitchReq 
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 热词功能开关。
        /// </summary>
        [JsonProperty("enable_hot_words", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHotWords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHotWordsSwitchReq {\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  enableHotWords: ").Append(EnableHotWords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHotWordsSwitchReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHotWordsSwitchReq input)
        {
            if (input == null) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.EnableHotWords != input.EnableHotWords || (this.EnableHotWords != null && !this.EnableHotWords.Equals(input.EnableHotWords))) return false;

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
                if (this.EnableHotWords != null) hashCode = hashCode * 59 + this.EnableHotWords.GetHashCode();
                return hashCode;
            }
        }
    }
}
