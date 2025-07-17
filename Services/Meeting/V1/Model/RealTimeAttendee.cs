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
    /// 被邀请与会者信息。
    /// </summary>
    public class RealTimeAttendee 
    {

        /// <summary>
        /// 与会者的华为云会议帐号。
        /// </summary>
        [JsonProperty("accountID", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountID { get; set; }

        /// <summary>
        /// 与会者的用户UUID。
        /// </summary>
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// 与会者名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 与会者号码。
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 设备为三屏智真时的左屏号码。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [JsonProperty("phoneLeft", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneLeft { get; set; }

        /// <summary>
        /// 设备为三屏智真时的右屏号码。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [JsonProperty("phoneRight", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneRight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealTimeAttendee {\n");
            sb.Append("  accountID: ").Append(AccountID).Append("\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  phoneLeft: ").Append(PhoneLeft).Append("\n");
            sb.Append("  phoneRight: ").Append(PhoneRight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RealTimeAttendee);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RealTimeAttendee input)
        {
            if (input == null) return false;
            if (this.AccountID != input.AccountID || (this.AccountID != null && !this.AccountID.Equals(input.AccountID))) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.PhoneLeft != input.PhoneLeft || (this.PhoneLeft != null && !this.PhoneLeft.Equals(input.PhoneLeft))) return false;
            if (this.PhoneRight != input.PhoneRight || (this.PhoneRight != null && !this.PhoneRight.Equals(input.PhoneRight))) return false;

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
                if (this.AccountID != null) hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneLeft != null) hashCode = hashCode * 59 + this.PhoneLeft.GetHashCode();
                if (this.PhoneRight != null) hashCode = hashCode * 59 + this.PhoneRight.GetHashCode();
                return hashCode;
            }
        }
    }
}
