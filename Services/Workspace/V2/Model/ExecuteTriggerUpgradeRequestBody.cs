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
    /// 触发升级请求
    /// </summary>
    public class ExecuteTriggerUpgradeRequestBody 
    {

        /// <summary>
        /// 是否强制升级：0-否 1-是
        /// </summary>
        [JsonProperty("is_force_execute", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsForceExecute { get; set; }

        /// <summary>
        /// 升级目标版本
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 升级任务描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 通知开启：0-未开启 1-开启
        /// </summary>
        [JsonProperty("is_notify", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsNotify { get; set; }

        /// <summary>
        /// 扩展参数（JSON格式）
        /// </summary>
        [JsonProperty("extra_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraParams { get; set; }

        /// <summary>
        /// 桌面sids列表
        /// </summary>
        [JsonProperty("desktop_sids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopSids { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteTriggerUpgradeRequestBody {\n");
            sb.Append("  isForceExecute: ").Append(IsForceExecute).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isNotify: ").Append(IsNotify).Append("\n");
            sb.Append("  extraParams: ").Append(ExtraParams).Append("\n");
            sb.Append("  desktopSids: ").Append(DesktopSids).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteTriggerUpgradeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteTriggerUpgradeRequestBody input)
        {
            if (input == null) return false;
            if (this.IsForceExecute != input.IsForceExecute || (this.IsForceExecute != null && !this.IsForceExecute.Equals(input.IsForceExecute))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsNotify != input.IsNotify || (this.IsNotify != null && !this.IsNotify.Equals(input.IsNotify))) return false;
            if (this.ExtraParams != input.ExtraParams || (this.ExtraParams != null && !this.ExtraParams.Equals(input.ExtraParams))) return false;
            if (this.DesktopSids != input.DesktopSids || (this.DesktopSids != null && input.DesktopSids != null && !this.DesktopSids.SequenceEqual(input.DesktopSids))) return false;

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
                if (this.IsForceExecute != null) hashCode = hashCode * 59 + this.IsForceExecute.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsNotify != null) hashCode = hashCode * 59 + this.IsNotify.GetHashCode();
                if (this.ExtraParams != null) hashCode = hashCode * 59 + this.ExtraParams.GetHashCode();
                if (this.DesktopSids != null) hashCode = hashCode * 59 + this.DesktopSids.GetHashCode();
                return hashCode;
            }
        }
    }
}
