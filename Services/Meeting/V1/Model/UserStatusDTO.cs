using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 终端状态信息
    /// </summary>
    public class UserStatusDTO 
    {

        /// <summary>
        /// 终端号码
        /// </summary>
        [JsonProperty("Number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 注册状态。 * 1：是未注册上 * 0：是已注册 
        /// </summary>
        [JsonProperty("RegStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string RegStatus { get; set; }

        /// <summary>
        /// 呼叫状态。 * 0：未上线 * 1：空闲中 * 2：使用中 * 3：非会议硬终端统一的无效值 
        /// </summary>
        [JsonProperty("CallStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string CallStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStatusDTO {\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  regStatus: ").Append(RegStatus).Append("\n");
            sb.Append("  callStatus: ").Append(CallStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserStatusDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserStatusDTO input)
        {
            if (input == null) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.RegStatus != input.RegStatus || (this.RegStatus != null && !this.RegStatus.Equals(input.RegStatus))) return false;
            if (this.CallStatus != input.CallStatus || (this.CallStatus != null && !this.CallStatus.Equals(input.CallStatus))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.RegStatus != null) hashCode = hashCode * 59 + this.RegStatus.GetHashCode();
                if (this.CallStatus != null) hashCode = hashCode * 59 + this.CallStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
