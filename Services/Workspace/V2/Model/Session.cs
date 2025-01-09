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
    public class Session 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vdi", NullValueHandling = NullValueHandling.Ignore)]
        public Vdi Vdi { get; set; }

        /// <summary>
        /// 是否开启自助维护台抢占登陆。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("self_help_console", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelfHelpConsole { get; set; }

        /// <summary>
        /// 是否锁屏后断开
        /// </summary>
        [JsonProperty("disconnect_on_lock_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisconnectOnLockFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Session {\n");
            sb.Append("  vdi: ").Append(Vdi).Append("\n");
            sb.Append("  selfHelpConsole: ").Append(SelfHelpConsole).Append("\n");
            sb.Append("  disconnectOnLockFlag: ").Append(DisconnectOnLockFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Session);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Session input)
        {
            if (input == null) return false;
            if (this.Vdi != input.Vdi || (this.Vdi != null && !this.Vdi.Equals(input.Vdi))) return false;
            if (this.SelfHelpConsole != input.SelfHelpConsole || (this.SelfHelpConsole != null && !this.SelfHelpConsole.Equals(input.SelfHelpConsole))) return false;
            if (this.DisconnectOnLockFlag != input.DisconnectOnLockFlag || (this.DisconnectOnLockFlag != null && !this.DisconnectOnLockFlag.Equals(input.DisconnectOnLockFlag))) return false;

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
                if (this.Vdi != null) hashCode = hashCode * 59 + this.Vdi.GetHashCode();
                if (this.SelfHelpConsole != null) hashCode = hashCode * 59 + this.SelfHelpConsole.GetHashCode();
                if (this.DisconnectOnLockFlag != null) hashCode = hashCode * 59 + this.DisconnectOnLockFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
