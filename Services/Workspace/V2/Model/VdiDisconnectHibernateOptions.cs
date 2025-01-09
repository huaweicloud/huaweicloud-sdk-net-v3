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
    /// 休眠断开选项
    /// </summary>
    public class VdiDisconnectHibernateOptions 
    {

        /// <summary>
        /// 断连休眠时间。
        /// </summary>
        [JsonProperty("disconnect_hibernate_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectHibernateMinutes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VdiDisconnectHibernateOptions {\n");
            sb.Append("  disconnectHibernateMinutes: ").Append(DisconnectHibernateMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VdiDisconnectHibernateOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VdiDisconnectHibernateOptions input)
        {
            if (input == null) return false;
            if (this.DisconnectHibernateMinutes != input.DisconnectHibernateMinutes || (this.DisconnectHibernateMinutes != null && !this.DisconnectHibernateMinutes.Equals(input.DisconnectHibernateMinutes))) return false;

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
                if (this.DisconnectHibernateMinutes != null) hashCode = hashCode * 59 + this.DisconnectHibernateMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
