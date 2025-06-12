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
    /// 创建激活码请求。
    /// </summary>
    public class CreateActiveCodeReq 
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 智能交互对话ID。
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 有效天数（0表示长期有效）。
        /// </summary>
        [JsonProperty("valid_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? ValidPeriod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateActiveCodeReq {\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateActiveCodeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateActiveCodeReq input)
        {
            if (input == null) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.ValidPeriod != input.ValidPeriod || (this.ValidPeriod != null && !this.ValidPeriod.Equals(input.ValidPeriod))) return false;

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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.ValidPeriod != null) hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}
