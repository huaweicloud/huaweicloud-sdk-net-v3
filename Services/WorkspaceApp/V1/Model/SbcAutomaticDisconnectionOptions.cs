using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SbcAutomaticDisconnectionOptions 
    {

        /// <summary>
        /// 等待时间（分钟）。
        /// </summary>
        [JsonProperty("disconnection_waiting_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectionWaitingTime { get; set; }

        /// <summary>
        /// 是否自动注销。取值为：false：表示是。true：表示否。
        /// </summary>
        [JsonProperty("sbc_auto_logout", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SbcAutoLogout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auto_logout_options", NullValueHandling = NullValueHandling.Ignore)]
        public AutoLogoutOptions AutoLogoutOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SbcAutomaticDisconnectionOptions {\n");
            sb.Append("  disconnectionWaitingTime: ").Append(DisconnectionWaitingTime).Append("\n");
            sb.Append("  sbcAutoLogout: ").Append(SbcAutoLogout).Append("\n");
            sb.Append("  autoLogoutOptions: ").Append(AutoLogoutOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SbcAutomaticDisconnectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SbcAutomaticDisconnectionOptions input)
        {
            if (input == null) return false;
            if (this.DisconnectionWaitingTime != input.DisconnectionWaitingTime || (this.DisconnectionWaitingTime != null && !this.DisconnectionWaitingTime.Equals(input.DisconnectionWaitingTime))) return false;
            if (this.SbcAutoLogout != input.SbcAutoLogout || (this.SbcAutoLogout != null && !this.SbcAutoLogout.Equals(input.SbcAutoLogout))) return false;
            if (this.AutoLogoutOptions != input.AutoLogoutOptions || (this.AutoLogoutOptions != null && !this.AutoLogoutOptions.Equals(input.AutoLogoutOptions))) return false;

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
                if (this.DisconnectionWaitingTime != null) hashCode = hashCode * 59 + this.DisconnectionWaitingTime.GetHashCode();
                if (this.SbcAutoLogout != null) hashCode = hashCode * 59 + this.SbcAutoLogout.GetHashCode();
                if (this.AutoLogoutOptions != null) hashCode = hashCode * 59 + this.AutoLogoutOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
