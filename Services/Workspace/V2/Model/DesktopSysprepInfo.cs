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
    /// 查询sysprep版本信息响应。
    /// </summary>
    public class DesktopSysprepInfo 
    {

        /// <summary>
        /// 桌面id。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// sysprep版本。
        /// </summary>
        [JsonProperty("sysprep_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SysprepVersion { get; set; }

        /// <summary>
        /// 是否支持休眠。
        /// </summary>
        [JsonProperty("support_hibernate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportHibernate { get; set; }

        /// <summary>
        /// 是否支持修改路由。
        /// </summary>
        [JsonProperty("support_update_route", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportUpdateRoute { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopSysprepInfo {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  sysprepVersion: ").Append(SysprepVersion).Append("\n");
            sb.Append("  supportHibernate: ").Append(SupportHibernate).Append("\n");
            sb.Append("  supportUpdateRoute: ").Append(SupportUpdateRoute).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopSysprepInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopSysprepInfo input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.SysprepVersion != input.SysprepVersion || (this.SysprepVersion != null && !this.SysprepVersion.Equals(input.SysprepVersion))) return false;
            if (this.SupportHibernate != input.SupportHibernate || (this.SupportHibernate != null && !this.SupportHibernate.Equals(input.SupportHibernate))) return false;
            if (this.SupportUpdateRoute != input.SupportUpdateRoute || (this.SupportUpdateRoute != null && !this.SupportUpdateRoute.Equals(input.SupportUpdateRoute))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.SysprepVersion != null) hashCode = hashCode * 59 + this.SysprepVersion.GetHashCode();
                if (this.SupportHibernate != null) hashCode = hashCode * 59 + this.SupportHibernate.GetHashCode();
                if (this.SupportUpdateRoute != null) hashCode = hashCode * 59 + this.SupportUpdateRoute.GetHashCode();
                return hashCode;
            }
        }
    }
}
