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
    /// Response Object
    /// </summary>
    public class ShowHibernateTypeResponse : SdkResponse
    {

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hibernate_type", NullValueHandling = NullValueHandling.Ignore)]
        public HibernateType? HibernateType { get; set; }

        /// <summary>
        /// 休眠关机时长（天）
        /// </summary>
        [JsonProperty("shutdown_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShutdownDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHibernateTypeResponse {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  hibernateType: ").Append(HibernateType).Append("\n");
            sb.Append("  shutdownDays: ").Append(ShutdownDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHibernateTypeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHibernateTypeResponse input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.HibernateType != input.HibernateType || (this.HibernateType != null && !this.HibernateType.Equals(input.HibernateType))) return false;
            if (this.ShutdownDays != input.ShutdownDays || (this.ShutdownDays != null && !this.ShutdownDays.Equals(input.ShutdownDays))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.HibernateType != null) hashCode = hashCode * 59 + this.HibernateType.GetHashCode();
                if (this.ShutdownDays != null) hashCode = hashCode * 59 + this.ShutdownDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
