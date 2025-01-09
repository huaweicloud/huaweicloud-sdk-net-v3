using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DisconnectLogoutOptions 
    {

        /// <summary>
        /// 断开后自动注销等待时间（分钟）。取值范围为[3-86400]。默认：10。
        /// </summary>
        [JsonProperty("disconnect_logout_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectLogoutMinutes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisconnectLogoutOptions {\n");
            sb.Append("  disconnectLogoutMinutes: ").Append(DisconnectLogoutMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisconnectLogoutOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisconnectLogoutOptions input)
        {
            if (input == null) return false;
            if (this.DisconnectLogoutMinutes != input.DisconnectLogoutMinutes || (this.DisconnectLogoutMinutes != null && !this.DisconnectLogoutMinutes.Equals(input.DisconnectLogoutMinutes))) return false;

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
                if (this.DisconnectLogoutMinutes != null) hashCode = hashCode * 59 + this.DisconnectLogoutMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
