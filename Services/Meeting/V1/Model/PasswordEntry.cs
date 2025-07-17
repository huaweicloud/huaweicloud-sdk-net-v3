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
    /// 密码信息。
    /// </summary>
    public class PasswordEntry 
    {

        /// <summary>
        /// 会议角色。 - chair: 会议主持人 - general: 普通与会者
        /// </summary>
        [JsonProperty("conferenceRole", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceRole { get; set; }

        /// <summary>
        /// 会议中角色的密码（明文）。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordEntry {\n");
            sb.Append("  conferenceRole: ").Append(ConferenceRole).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PasswordEntry);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PasswordEntry input)
        {
            if (input == null) return false;
            if (this.ConferenceRole != input.ConferenceRole || (this.ConferenceRole != null && !this.ConferenceRole.Equals(input.ConferenceRole))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;

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
                if (this.ConferenceRole != null) hashCode = hashCode * 59 + this.ConferenceRole.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }
}
