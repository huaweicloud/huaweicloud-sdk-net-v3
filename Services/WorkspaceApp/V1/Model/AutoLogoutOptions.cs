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
    public class AutoLogoutOptions 
    {

        /// <summary>
        /// 会话断连保留时长（分钟）。
        /// </summary>
        [JsonProperty("sbc_logout_waiting_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? SbcLogoutWaitingTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoLogoutOptions {\n");
            sb.Append("  sbcLogoutWaitingTime: ").Append(SbcLogoutWaitingTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoLogoutOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoLogoutOptions input)
        {
            if (input == null) return false;
            if (this.SbcLogoutWaitingTime != input.SbcLogoutWaitingTime || (this.SbcLogoutWaitingTime != null && !this.SbcLogoutWaitingTime.Equals(input.SbcLogoutWaitingTime))) return false;

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
                if (this.SbcLogoutWaitingTime != null) hashCode = hashCode * 59 + this.SbcLogoutWaitingTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
