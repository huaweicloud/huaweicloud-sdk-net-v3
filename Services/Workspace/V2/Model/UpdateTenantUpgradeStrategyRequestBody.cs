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
    /// 更新升级策略请求
    /// </summary>
    public class UpdateTenantUpgradeStrategyRequestBody 
    {

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("strategy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StrategyName { get; set; }

        /// <summary>
        /// 是否强制升级：0-否 1-是
        /// </summary>
        [JsonProperty("is_force_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsForceUpgrade { get; set; }

        /// <summary>
        /// 低于此版本升级
        /// </summary>
        [JsonProperty("min_version", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVersion { get; set; }

        /// <summary>
        /// 升级目标版本
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("strategy_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string StrategyDesc { get; set; }

        /// <summary>
        /// 优先级（数值越小优先级越高）
        /// </summary>
        [JsonProperty("strategy_priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? StrategyPriority { get; set; }

        /// <summary>
        /// 状态：0-禁用 1-启用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 应用对象列表
        /// </summary>
        [JsonProperty("apply_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplyObjectInfo> ApplyObjects { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTenantUpgradeStrategyRequestBody {\n");
            sb.Append("  strategyName: ").Append(StrategyName).Append("\n");
            sb.Append("  isForceUpgrade: ").Append(IsForceUpgrade).Append("\n");
            sb.Append("  minVersion: ").Append(MinVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  strategyDesc: ").Append(StrategyDesc).Append("\n");
            sb.Append("  strategyPriority: ").Append(StrategyPriority).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  applyObjects: ").Append(ApplyObjects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTenantUpgradeStrategyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantUpgradeStrategyRequestBody input)
        {
            if (input == null) return false;
            if (this.StrategyName != input.StrategyName || (this.StrategyName != null && !this.StrategyName.Equals(input.StrategyName))) return false;
            if (this.IsForceUpgrade != input.IsForceUpgrade || (this.IsForceUpgrade != null && !this.IsForceUpgrade.Equals(input.IsForceUpgrade))) return false;
            if (this.MinVersion != input.MinVersion || (this.MinVersion != null && !this.MinVersion.Equals(input.MinVersion))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.StrategyDesc != input.StrategyDesc || (this.StrategyDesc != null && !this.StrategyDesc.Equals(input.StrategyDesc))) return false;
            if (this.StrategyPriority != input.StrategyPriority || (this.StrategyPriority != null && !this.StrategyPriority.Equals(input.StrategyPriority))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ApplyObjects != input.ApplyObjects || (this.ApplyObjects != null && input.ApplyObjects != null && !this.ApplyObjects.SequenceEqual(input.ApplyObjects))) return false;

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
                if (this.StrategyName != null) hashCode = hashCode * 59 + this.StrategyName.GetHashCode();
                if (this.IsForceUpgrade != null) hashCode = hashCode * 59 + this.IsForceUpgrade.GetHashCode();
                if (this.MinVersion != null) hashCode = hashCode * 59 + this.MinVersion.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.StrategyDesc != null) hashCode = hashCode * 59 + this.StrategyDesc.GetHashCode();
                if (this.StrategyPriority != null) hashCode = hashCode * 59 + this.StrategyPriority.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ApplyObjects != null) hashCode = hashCode * 59 + this.ApplyObjects.GetHashCode();
                return hashCode;
            }
        }
    }
}
