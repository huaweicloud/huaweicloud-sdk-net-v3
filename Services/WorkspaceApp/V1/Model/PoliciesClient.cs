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
    /// 客户端。
    /// </summary>
    public class PoliciesClient 
    {

        /// <summary>
        /// 自动重连间隔（秒）。取值范围为[1-50]。默认：5。
        /// </summary>
        [JsonProperty("automatic_reconnection_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomaticReconnectionInterval { get; set; }

        /// <summary>
        /// 自动重连会话保持时长（秒）。取值范围为[0-180]。默认：180。
        /// </summary>
        [JsonProperty("session_persistence_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionPersistenceTime { get; set; }

        /// <summary>
        /// 防截屏策略开关。 false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("forbid_screen_capture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForbidScreenCapture { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesClient {\n");
            sb.Append("  automaticReconnectionInterval: ").Append(AutomaticReconnectionInterval).Append("\n");
            sb.Append("  sessionPersistenceTime: ").Append(SessionPersistenceTime).Append("\n");
            sb.Append("  forbidScreenCapture: ").Append(ForbidScreenCapture).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesClient);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesClient input)
        {
            if (input == null) return false;
            if (this.AutomaticReconnectionInterval != input.AutomaticReconnectionInterval || (this.AutomaticReconnectionInterval != null && !this.AutomaticReconnectionInterval.Equals(input.AutomaticReconnectionInterval))) return false;
            if (this.SessionPersistenceTime != input.SessionPersistenceTime || (this.SessionPersistenceTime != null && !this.SessionPersistenceTime.Equals(input.SessionPersistenceTime))) return false;
            if (this.ForbidScreenCapture != input.ForbidScreenCapture || (this.ForbidScreenCapture != null && !this.ForbidScreenCapture.Equals(input.ForbidScreenCapture))) return false;

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
                if (this.AutomaticReconnectionInterval != null) hashCode = hashCode * 59 + this.AutomaticReconnectionInterval.GetHashCode();
                if (this.SessionPersistenceTime != null) hashCode = hashCode * 59 + this.SessionPersistenceTime.GetHashCode();
                if (this.ForbidScreenCapture != null) hashCode = hashCode * 59 + this.ForbidScreenCapture.GetHashCode();
                return hashCode;
            }
        }
    }
}
