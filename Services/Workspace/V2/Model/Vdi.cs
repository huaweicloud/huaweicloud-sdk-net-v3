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
    public class Vdi 
    {

        /// <summary>
        /// 是否开启自动锁屏。取值为：false：表示关闭。true：表示开启。
        /// </summary>
        [JsonProperty("auto_lock_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoLockEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auto_lock_options", NullValueHandling = NullValueHandling.Ignore)]
        public AutoLockOptions AutoLockOptions { get; set; }

        /// <summary>
        /// 是否开启断开后自动注销。取值为：0：表示关闭。1：表示开启。
        /// </summary>
        [JsonProperty("disconnect_logout_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectLogoutEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("disconnect_logout_options", NullValueHandling = NullValueHandling.Ignore)]
        public DisconnectLogoutOptions DisconnectLogoutOptions { get; set; }

        /// <summary>
        /// 是否开启断开后自动注销。取值为：0：表示关闭。1：表示开启。
        /// </summary>
        [JsonProperty("disconnect_hibernate_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisconnectHibernateEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("disconnect_hibernate_options", NullValueHandling = NullValueHandling.Ignore)]
        public VdiDisconnectHibernateOptions DisconnectHibernateOptions { get; set; }

        /// <summary>
        /// 是否开启断开后自动注销。取值为：0：表示关闭。1：表示开启。
        /// </summary>
        [JsonProperty("no_operation_hibernate_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoOperationHibernateEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("no_operation_hibernate_options", NullValueHandling = NullValueHandling.Ignore)]
        public VdiNoOperationHibernateOptions NoOperationHibernateOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vdi {\n");
            sb.Append("  autoLockEnable: ").Append(AutoLockEnable).Append("\n");
            sb.Append("  autoLockOptions: ").Append(AutoLockOptions).Append("\n");
            sb.Append("  disconnectLogoutEnable: ").Append(DisconnectLogoutEnable).Append("\n");
            sb.Append("  disconnectLogoutOptions: ").Append(DisconnectLogoutOptions).Append("\n");
            sb.Append("  disconnectHibernateEnable: ").Append(DisconnectHibernateEnable).Append("\n");
            sb.Append("  disconnectHibernateOptions: ").Append(DisconnectHibernateOptions).Append("\n");
            sb.Append("  noOperationHibernateEnable: ").Append(NoOperationHibernateEnable).Append("\n");
            sb.Append("  noOperationHibernateOptions: ").Append(NoOperationHibernateOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Vdi);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Vdi input)
        {
            if (input == null) return false;
            if (this.AutoLockEnable != input.AutoLockEnable || (this.AutoLockEnable != null && !this.AutoLockEnable.Equals(input.AutoLockEnable))) return false;
            if (this.AutoLockOptions != input.AutoLockOptions || (this.AutoLockOptions != null && !this.AutoLockOptions.Equals(input.AutoLockOptions))) return false;
            if (this.DisconnectLogoutEnable != input.DisconnectLogoutEnable || (this.DisconnectLogoutEnable != null && !this.DisconnectLogoutEnable.Equals(input.DisconnectLogoutEnable))) return false;
            if (this.DisconnectLogoutOptions != input.DisconnectLogoutOptions || (this.DisconnectLogoutOptions != null && !this.DisconnectLogoutOptions.Equals(input.DisconnectLogoutOptions))) return false;
            if (this.DisconnectHibernateEnable != input.DisconnectHibernateEnable || (this.DisconnectHibernateEnable != null && !this.DisconnectHibernateEnable.Equals(input.DisconnectHibernateEnable))) return false;
            if (this.DisconnectHibernateOptions != input.DisconnectHibernateOptions || (this.DisconnectHibernateOptions != null && !this.DisconnectHibernateOptions.Equals(input.DisconnectHibernateOptions))) return false;
            if (this.NoOperationHibernateEnable != input.NoOperationHibernateEnable || (this.NoOperationHibernateEnable != null && !this.NoOperationHibernateEnable.Equals(input.NoOperationHibernateEnable))) return false;
            if (this.NoOperationHibernateOptions != input.NoOperationHibernateOptions || (this.NoOperationHibernateOptions != null && !this.NoOperationHibernateOptions.Equals(input.NoOperationHibernateOptions))) return false;

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
                if (this.AutoLockEnable != null) hashCode = hashCode * 59 + this.AutoLockEnable.GetHashCode();
                if (this.AutoLockOptions != null) hashCode = hashCode * 59 + this.AutoLockOptions.GetHashCode();
                if (this.DisconnectLogoutEnable != null) hashCode = hashCode * 59 + this.DisconnectLogoutEnable.GetHashCode();
                if (this.DisconnectLogoutOptions != null) hashCode = hashCode * 59 + this.DisconnectLogoutOptions.GetHashCode();
                if (this.DisconnectHibernateEnable != null) hashCode = hashCode * 59 + this.DisconnectHibernateEnable.GetHashCode();
                if (this.DisconnectHibernateOptions != null) hashCode = hashCode * 59 + this.DisconnectHibernateOptions.GetHashCode();
                if (this.NoOperationHibernateEnable != null) hashCode = hashCode * 59 + this.NoOperationHibernateEnable.GetHashCode();
                if (this.NoOperationHibernateOptions != null) hashCode = hashCode * 59 + this.NoOperationHibernateOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
