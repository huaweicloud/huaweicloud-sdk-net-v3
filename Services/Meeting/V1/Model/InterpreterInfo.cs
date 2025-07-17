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
    /// 传译员信息
    /// </summary>
    public class InterpreterInfo 
    {

        /// <summary>
        /// 用户登录账号，可以是账号、手机、邮箱其中一个,loginAccount和userID必须二选一。
        /// </summary>
        [JsonProperty("loginAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginAccount { get; set; }

        /// <summary>
        /// 用户的userUUID。
        /// </summary>
        [JsonProperty("userID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserID { get; set; }

        /// <summary>
        /// 呼叫号码。
        /// </summary>
        [JsonProperty("callNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CallNumber { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 传译员序号，AI传译组下传译员唯一标识。
        /// </summary>
        [JsonProperty("interpreterId", NullValueHandling = NullValueHandling.Ignore)]
        public string InterpreterId { get; set; }

        /// <summary>
        /// 传译员类型，MANUAL：人工传译，AI：AI传译。默认MANUAL。
        /// </summary>
        [JsonProperty("interpreterType", NullValueHandling = NullValueHandling.Ignore)]
        public string InterpreterType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("aiDigitalInfo", NullValueHandling = NullValueHandling.Ignore)]
        public InterpreterAiDigitalInfo AiDigitalInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterpreterInfo {\n");
            sb.Append("  loginAccount: ").Append(LoginAccount).Append("\n");
            sb.Append("  userID: ").Append(UserID).Append("\n");
            sb.Append("  callNumber: ").Append(CallNumber).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  interpreterId: ").Append(InterpreterId).Append("\n");
            sb.Append("  interpreterType: ").Append(InterpreterType).Append("\n");
            sb.Append("  aiDigitalInfo: ").Append(AiDigitalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterpreterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InterpreterInfo input)
        {
            if (input == null) return false;
            if (this.LoginAccount != input.LoginAccount || (this.LoginAccount != null && !this.LoginAccount.Equals(input.LoginAccount))) return false;
            if (this.UserID != input.UserID || (this.UserID != null && !this.UserID.Equals(input.UserID))) return false;
            if (this.CallNumber != input.CallNumber || (this.CallNumber != null && !this.CallNumber.Equals(input.CallNumber))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.InterpreterId != input.InterpreterId || (this.InterpreterId != null && !this.InterpreterId.Equals(input.InterpreterId))) return false;
            if (this.InterpreterType != input.InterpreterType || (this.InterpreterType != null && !this.InterpreterType.Equals(input.InterpreterType))) return false;
            if (this.AiDigitalInfo != input.AiDigitalInfo || (this.AiDigitalInfo != null && !this.AiDigitalInfo.Equals(input.AiDigitalInfo))) return false;

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
                if (this.LoginAccount != null) hashCode = hashCode * 59 + this.LoginAccount.GetHashCode();
                if (this.UserID != null) hashCode = hashCode * 59 + this.UserID.GetHashCode();
                if (this.CallNumber != null) hashCode = hashCode * 59 + this.CallNumber.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InterpreterId != null) hashCode = hashCode * 59 + this.InterpreterId.GetHashCode();
                if (this.InterpreterType != null) hashCode = hashCode * 59 + this.InterpreterType.GetHashCode();
                if (this.AiDigitalInfo != null) hashCode = hashCode * 59 + this.AiDigitalInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
