using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 应用信息。
    /// </summary>
    public class AppInfo 
    {

        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 组件id。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppId { get; set; }

        /// <summary>
        /// 在线探针数。
        /// </summary>
        [JsonProperty("online_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlineCount { get; set; }

        /// <summary>
        /// 手动停止探针数。
        /// </summary>
        [JsonProperty("disable_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisableCount { get; set; }

        /// <summary>
        /// 离线探针数。
        /// </summary>
        [JsonProperty("offline_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OfflineCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppInfo {\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  onlineCount: ").Append(OnlineCount).Append("\n");
            sb.Append("  disableCount: ").Append(DisableCount).Append("\n");
            sb.Append("  offlineCount: ").Append(OfflineCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppInfo input)
        {
            if (input == null) return false;
            if (this.EnvName != input.EnvName || (this.EnvName != null && !this.EnvName.Equals(input.EnvName))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.OnlineCount != input.OnlineCount || (this.OnlineCount != null && !this.OnlineCount.Equals(input.OnlineCount))) return false;
            if (this.DisableCount != input.DisableCount || (this.DisableCount != null && !this.DisableCount.Equals(input.DisableCount))) return false;
            if (this.OfflineCount != input.OfflineCount || (this.OfflineCount != null && !this.OfflineCount.Equals(input.OfflineCount))) return false;

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
                if (this.EnvName != null) hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.OnlineCount != null) hashCode = hashCode * 59 + this.OnlineCount.GetHashCode();
                if (this.DisableCount != null) hashCode = hashCode * 59 + this.DisableCount.GetHashCode();
                if (this.OfflineCount != null) hashCode = hashCode * 59 + this.OfflineCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
