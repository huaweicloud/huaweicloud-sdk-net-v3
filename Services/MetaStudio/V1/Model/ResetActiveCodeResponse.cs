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
    /// Response Object
    /// </summary>
    public class ResetActiveCodeResponse : SdkResponse
    {

        /// <summary>
        /// 激活码ID。
        /// </summary>
        [JsonProperty("active_code_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveCodeId { get; set; }

        /// <summary>
        /// 激活码。
        /// </summary>
        [JsonProperty("active_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveCode { get; set; }

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
        /// 过期时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetActiveCodeResponse {\n");
            sb.Append("  activeCodeId: ").Append(ActiveCodeId).Append("\n");
            sb.Append("  activeCode: ").Append(ActiveCode).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetActiveCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetActiveCodeResponse input)
        {
            if (input == null) return false;
            if (this.ActiveCodeId != input.ActiveCodeId || (this.ActiveCodeId != null && !this.ActiveCodeId.Equals(input.ActiveCodeId))) return false;
            if (this.ActiveCode != input.ActiveCode || (this.ActiveCode != null && !this.ActiveCode.Equals(input.ActiveCode))) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.ValidPeriod != input.ValidPeriod || (this.ValidPeriod != null && !this.ValidPeriod.Equals(input.ValidPeriod))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.ActiveCodeId != null) hashCode = hashCode * 59 + this.ActiveCodeId.GetHashCode();
                if (this.ActiveCode != null) hashCode = hashCode * 59 + this.ActiveCode.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.ValidPeriod != null) hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
