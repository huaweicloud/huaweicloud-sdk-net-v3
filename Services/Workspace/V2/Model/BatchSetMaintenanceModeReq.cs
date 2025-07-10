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
    /// 批量设置桌面管理员维护模式。
    /// </summary>
    public class BatchSetMaintenanceModeReq 
    {

        /// <summary>
        /// 需要设置维护模式的desktopId列表。
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 进入或退出管理员维护模式 false:  退出维护模式 true: 维护模式
        /// </summary>
        [JsonProperty("in_maintenance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InMaintenanceMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSetMaintenanceModeReq {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  inMaintenanceMode: ").Append(InMaintenanceMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSetMaintenanceModeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSetMaintenanceModeReq input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.InMaintenanceMode != input.InMaintenanceMode || (this.InMaintenanceMode != null && !this.InMaintenanceMode.Equals(input.InMaintenanceMode))) return false;

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
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.InMaintenanceMode != null) hashCode = hashCode * 59 + this.InMaintenanceMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
