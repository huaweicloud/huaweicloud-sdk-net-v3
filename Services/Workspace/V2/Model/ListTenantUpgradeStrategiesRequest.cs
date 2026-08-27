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
    /// Request Object
    /// </summary>
    public class ListTenantUpgradeStrategiesRequest 
    {

        /// <summary>
        /// 是否精确匹配名称
        /// </summary>
        [SDKProperty("is_accurate_name", IsQuery = true)]
        [JsonProperty("is_accurate_name", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAccurateName { get; set; }

        /// <summary>
        /// 策略名称（支持模糊查询）
        /// </summary>
        [SDKProperty("strategy_name", IsQuery = true)]
        [JsonProperty("strategy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StrategyName { get; set; }

        /// <summary>
        /// 策略类型：0-服务端 1-客户端
        /// </summary>
        [SDKProperty("strategy_type", IsQuery = true)]
        [JsonProperty("strategy_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? StrategyType { get; set; }

        /// <summary>
        /// 是否强制升级：0-否 1-是
        /// </summary>
        [SDKProperty("is_force_upgrade", IsQuery = true)]
        [JsonProperty("is_force_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsForceUpgrade { get; set; }

        /// <summary>
        /// 启用状态：0-禁用 1-启用
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 协议策略优先级
        /// </summary>
        [SDKProperty("strategy_priority", IsQuery = true)]
        [JsonProperty("strategy_priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? StrategyPriority { get; set; }

        /// <summary>
        /// 偏移量，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页数量，默认10，最大100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTenantUpgradeStrategiesRequest {\n");
            sb.Append("  isAccurateName: ").Append(IsAccurateName).Append("\n");
            sb.Append("  strategyName: ").Append(StrategyName).Append("\n");
            sb.Append("  strategyType: ").Append(StrategyType).Append("\n");
            sb.Append("  isForceUpgrade: ").Append(IsForceUpgrade).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  strategyPriority: ").Append(StrategyPriority).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantUpgradeStrategiesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantUpgradeStrategiesRequest input)
        {
            if (input == null) return false;
            if (this.IsAccurateName != input.IsAccurateName || (this.IsAccurateName != null && !this.IsAccurateName.Equals(input.IsAccurateName))) return false;
            if (this.StrategyName != input.StrategyName || (this.StrategyName != null && !this.StrategyName.Equals(input.StrategyName))) return false;
            if (this.StrategyType != input.StrategyType || (this.StrategyType != null && !this.StrategyType.Equals(input.StrategyType))) return false;
            if (this.IsForceUpgrade != input.IsForceUpgrade || (this.IsForceUpgrade != null && !this.IsForceUpgrade.Equals(input.IsForceUpgrade))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StrategyPriority != input.StrategyPriority || (this.StrategyPriority != null && !this.StrategyPriority.Equals(input.StrategyPriority))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.IsAccurateName != null) hashCode = hashCode * 59 + this.IsAccurateName.GetHashCode();
                if (this.StrategyName != null) hashCode = hashCode * 59 + this.StrategyName.GetHashCode();
                if (this.StrategyType != null) hashCode = hashCode * 59 + this.StrategyType.GetHashCode();
                if (this.IsForceUpgrade != null) hashCode = hashCode * 59 + this.IsForceUpgrade.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StrategyPriority != null) hashCode = hashCode * 59 + this.StrategyPriority.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
