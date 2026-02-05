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
    /// 更新热点会话迁移配置请求体。
    /// </summary>
    public class UpdateHotspotSessionConfigReq 
    {

        /// <summary>
        /// 是否开启热点会话迁移。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("hotspot_session_migration_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HotspotSessionMigrationEnable { get; set; }

        /// <summary>
        /// 热点时退出会话个数。
        /// </summary>
        [JsonProperty("hotspot_exit_session_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? HotspotExitSessionNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHotspotSessionConfigReq {\n");
            sb.Append("  hotspotSessionMigrationEnable: ").Append(HotspotSessionMigrationEnable).Append("\n");
            sb.Append("  hotspotExitSessionNum: ").Append(HotspotExitSessionNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHotspotSessionConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHotspotSessionConfigReq input)
        {
            if (input == null) return false;
            if (this.HotspotSessionMigrationEnable != input.HotspotSessionMigrationEnable || (this.HotspotSessionMigrationEnable != null && !this.HotspotSessionMigrationEnable.Equals(input.HotspotSessionMigrationEnable))) return false;
            if (this.HotspotExitSessionNum != input.HotspotExitSessionNum || (this.HotspotExitSessionNum != null && !this.HotspotExitSessionNum.Equals(input.HotspotExitSessionNum))) return false;

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
                if (this.HotspotSessionMigrationEnable != null) hashCode = hashCode * 59 + this.HotspotSessionMigrationEnable.GetHashCode();
                if (this.HotspotExitSessionNum != null) hashCode = hashCode * 59 + this.HotspotExitSessionNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
