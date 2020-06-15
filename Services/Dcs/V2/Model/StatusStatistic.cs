using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 实例数量统计信息。
    /// </summary>
    public class StatusStatistic 
    {

        /// <summary>
        /// 支付中的实例数。
        /// </summary>
        [JsonProperty("paying_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayingCount { get; set; }

        /// <summary>
        /// 冻结中的实例数。
        /// </summary>
        [JsonProperty("freezing_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreezingCount { get; set; }

        /// <summary>
        /// 迁移中的实例数。
        /// </summary>
        [JsonProperty("migrating_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MigratingCount { get; set; }

        /// <summary>
        /// 清空中的实例数。
        /// </summary>
        [JsonProperty("flushing_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlushingCount { get; set; }

        /// <summary>
        /// 升级中的实例数。
        /// </summary>
        [JsonProperty("upgrading_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpgradingCount { get; set; }

        /// <summary>
        /// 恢复中的实例数。
        /// </summary>
        [JsonProperty("restoring_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RestoringCount { get; set; }

        /// <summary>
        /// 扩容中的实例数。
        /// </summary>
        [JsonProperty("extending_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtendingCount { get; set; }

        /// <summary>
        /// 正在创建的实例数。
        /// </summary>
        [JsonProperty("creating_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatingCount { get; set; }

        /// <summary>
        /// 正在运行的实例数。
        /// </summary>
        [JsonProperty("running_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunningCount { get; set; }

        /// <summary>
        /// 异常的实例数。
        /// </summary>
        [JsonProperty("error_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// 已冻结的实例数。
        /// </summary>
        [JsonProperty("frozen_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrozenCount { get; set; }

        /// <summary>
        /// 创建失败的实例数。
        /// </summary>
        [JsonProperty("createfailed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatefailedCount { get; set; }

        /// <summary>
        /// 正在重启的实例数。
        /// </summary>
        [JsonProperty("restarting_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RestartingCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusStatistic {\n");
            sb.Append("  payingCount: ").Append(PayingCount).Append("\n");
            sb.Append("  freezingCount: ").Append(FreezingCount).Append("\n");
            sb.Append("  migratingCount: ").Append(MigratingCount).Append("\n");
            sb.Append("  flushingCount: ").Append(FlushingCount).Append("\n");
            sb.Append("  upgradingCount: ").Append(UpgradingCount).Append("\n");
            sb.Append("  restoringCount: ").Append(RestoringCount).Append("\n");
            sb.Append("  extendingCount: ").Append(ExtendingCount).Append("\n");
            sb.Append("  creatingCount: ").Append(CreatingCount).Append("\n");
            sb.Append("  runningCount: ").Append(RunningCount).Append("\n");
            sb.Append("  errorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  frozenCount: ").Append(FrozenCount).Append("\n");
            sb.Append("  createfailedCount: ").Append(CreatefailedCount).Append("\n");
            sb.Append("  restartingCount: ").Append(RestartingCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatusStatistic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatusStatistic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayingCount == input.PayingCount ||
                    (this.PayingCount != null &&
                    this.PayingCount.Equals(input.PayingCount))
                ) && 
                (
                    this.FreezingCount == input.FreezingCount ||
                    (this.FreezingCount != null &&
                    this.FreezingCount.Equals(input.FreezingCount))
                ) && 
                (
                    this.MigratingCount == input.MigratingCount ||
                    (this.MigratingCount != null &&
                    this.MigratingCount.Equals(input.MigratingCount))
                ) && 
                (
                    this.FlushingCount == input.FlushingCount ||
                    (this.FlushingCount != null &&
                    this.FlushingCount.Equals(input.FlushingCount))
                ) && 
                (
                    this.UpgradingCount == input.UpgradingCount ||
                    (this.UpgradingCount != null &&
                    this.UpgradingCount.Equals(input.UpgradingCount))
                ) && 
                (
                    this.RestoringCount == input.RestoringCount ||
                    (this.RestoringCount != null &&
                    this.RestoringCount.Equals(input.RestoringCount))
                ) && 
                (
                    this.ExtendingCount == input.ExtendingCount ||
                    (this.ExtendingCount != null &&
                    this.ExtendingCount.Equals(input.ExtendingCount))
                ) && 
                (
                    this.CreatingCount == input.CreatingCount ||
                    (this.CreatingCount != null &&
                    this.CreatingCount.Equals(input.CreatingCount))
                ) && 
                (
                    this.RunningCount == input.RunningCount ||
                    (this.RunningCount != null &&
                    this.RunningCount.Equals(input.RunningCount))
                ) && 
                (
                    this.ErrorCount == input.ErrorCount ||
                    (this.ErrorCount != null &&
                    this.ErrorCount.Equals(input.ErrorCount))
                ) && 
                (
                    this.FrozenCount == input.FrozenCount ||
                    (this.FrozenCount != null &&
                    this.FrozenCount.Equals(input.FrozenCount))
                ) && 
                (
                    this.CreatefailedCount == input.CreatefailedCount ||
                    (this.CreatefailedCount != null &&
                    this.CreatefailedCount.Equals(input.CreatefailedCount))
                ) && 
                (
                    this.RestartingCount == input.RestartingCount ||
                    (this.RestartingCount != null &&
                    this.RestartingCount.Equals(input.RestartingCount))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PayingCount != null)
                    hashCode = hashCode * 59 + this.PayingCount.GetHashCode();
                if (this.FreezingCount != null)
                    hashCode = hashCode * 59 + this.FreezingCount.GetHashCode();
                if (this.MigratingCount != null)
                    hashCode = hashCode * 59 + this.MigratingCount.GetHashCode();
                if (this.FlushingCount != null)
                    hashCode = hashCode * 59 + this.FlushingCount.GetHashCode();
                if (this.UpgradingCount != null)
                    hashCode = hashCode * 59 + this.UpgradingCount.GetHashCode();
                if (this.RestoringCount != null)
                    hashCode = hashCode * 59 + this.RestoringCount.GetHashCode();
                if (this.ExtendingCount != null)
                    hashCode = hashCode * 59 + this.ExtendingCount.GetHashCode();
                if (this.CreatingCount != null)
                    hashCode = hashCode * 59 + this.CreatingCount.GetHashCode();
                if (this.RunningCount != null)
                    hashCode = hashCode * 59 + this.RunningCount.GetHashCode();
                if (this.ErrorCount != null)
                    hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.FrozenCount != null)
                    hashCode = hashCode * 59 + this.FrozenCount.GetHashCode();
                if (this.CreatefailedCount != null)
                    hashCode = hashCode * 59 + this.CreatefailedCount.GetHashCode();
                if (this.RestartingCount != null)
                    hashCode = hashCode * 59 + this.RestartingCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
