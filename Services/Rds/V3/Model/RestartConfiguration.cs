using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestartConfiguration 
    {

        /// <summary>
        /// 是否重启虚拟机。
        /// </summary>
        [JsonProperty("restart_server", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartServer { get; set; }

        /// <summary>
        /// 是否强制重启, 强制重启会导致数据库服务中未提交的事务强制中断。
        /// </summary>
        [JsonProperty("forcible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forcible { get; set; }

        /// <summary>
        /// 是否在可维护时间段内重启。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartConfiguration {\n");
            sb.Append("  restartServer: ").Append(RestartServer).Append("\n");
            sb.Append("  forcible: ").Append(Forcible).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestartConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestartConfiguration input)
        {
            if (input == null) return false;
            if (this.RestartServer != input.RestartServer || (this.RestartServer != null && !this.RestartServer.Equals(input.RestartServer))) return false;
            if (this.Forcible != input.Forcible || (this.Forcible != null && !this.Forcible.Equals(input.Forcible))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;

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
                if (this.RestartServer != null) hashCode = hashCode * 59 + this.RestartServer.GetHashCode();
                if (this.Forcible != null) hashCode = hashCode * 59 + this.Forcible.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                return hashCode;
            }
        }
    }
}
