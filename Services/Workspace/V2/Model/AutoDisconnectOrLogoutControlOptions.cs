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
    public class AutoDisconnectOrLogoutControlOptions 
    {

        /// <summary>
        /// 断开或注销等待时间（分钟）。取值范围为[1-86400]。默认：1440。
        /// </summary>
        [JsonProperty("auto_disconnect_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoDisconnectMinutes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoDisconnectOrLogoutControlOptions {\n");
            sb.Append("  autoDisconnectMinutes: ").Append(AutoDisconnectMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoDisconnectOrLogoutControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoDisconnectOrLogoutControlOptions input)
        {
            if (input == null) return false;
            if (this.AutoDisconnectMinutes != input.AutoDisconnectMinutes || (this.AutoDisconnectMinutes != null && !this.AutoDisconnectMinutes.Equals(input.AutoDisconnectMinutes))) return false;

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
                if (this.AutoDisconnectMinutes != null) hashCode = hashCode * 59 + this.AutoDisconnectMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
