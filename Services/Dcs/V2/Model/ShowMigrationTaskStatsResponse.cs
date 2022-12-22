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
    /// Response Object
    /// </summary>
    public class ShowMigrationTaskStatsResponse : SdkResponse
    {

        /// <summary>
        /// 全量迁移进度百分比。
        /// </summary>
        [JsonProperty("full_migration_progress", NullValueHandling = NullValueHandling.Ignore)]
        public string FullMigrationProgress { get; set; }

        /// <summary>
        /// 增量迁移偏移量。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 源redis键数量
        /// </summary>
        [JsonProperty("source_dbsize", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbsize { get; set; }

        /// <summary>
        /// 目标redis键数量
        /// </summary>
        [JsonProperty("target_dbsize", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbsize { get; set; }

        /// <summary>
        /// 目标redis键写入流量，单位KB/s
        /// </summary>
        [JsonProperty("target_input_kbps", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetInputKbps { get; set; }

        /// <summary>
        /// 目标redis每秒并发操作数
        /// </summary>
        [JsonProperty("target_ops", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetOps { get; set; }

        /// <summary>
        /// 迁移任务是否在进行
        /// </summary>
        [JsonProperty("is_migrating", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMigrating { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMigrationTaskStatsResponse {\n");
            sb.Append("  fullMigrationProgress: ").Append(FullMigrationProgress).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  sourceDbsize: ").Append(SourceDbsize).Append("\n");
            sb.Append("  targetDbsize: ").Append(TargetDbsize).Append("\n");
            sb.Append("  targetInputKbps: ").Append(TargetInputKbps).Append("\n");
            sb.Append("  targetOps: ").Append(TargetOps).Append("\n");
            sb.Append("  isMigrating: ").Append(IsMigrating).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMigrationTaskStatsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMigrationTaskStatsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FullMigrationProgress == input.FullMigrationProgress ||
                    (this.FullMigrationProgress != null &&
                    this.FullMigrationProgress.Equals(input.FullMigrationProgress))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.SourceDbsize == input.SourceDbsize ||
                    (this.SourceDbsize != null &&
                    this.SourceDbsize.Equals(input.SourceDbsize))
                ) && 
                (
                    this.TargetDbsize == input.TargetDbsize ||
                    (this.TargetDbsize != null &&
                    this.TargetDbsize.Equals(input.TargetDbsize))
                ) && 
                (
                    this.TargetInputKbps == input.TargetInputKbps ||
                    (this.TargetInputKbps != null &&
                    this.TargetInputKbps.Equals(input.TargetInputKbps))
                ) && 
                (
                    this.TargetOps == input.TargetOps ||
                    (this.TargetOps != null &&
                    this.TargetOps.Equals(input.TargetOps))
                ) && 
                (
                    this.IsMigrating == input.IsMigrating ||
                    (this.IsMigrating != null &&
                    this.IsMigrating.Equals(input.IsMigrating))
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
                if (this.FullMigrationProgress != null)
                    hashCode = hashCode * 59 + this.FullMigrationProgress.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.SourceDbsize != null)
                    hashCode = hashCode * 59 + this.SourceDbsize.GetHashCode();
                if (this.TargetDbsize != null)
                    hashCode = hashCode * 59 + this.TargetDbsize.GetHashCode();
                if (this.TargetInputKbps != null)
                    hashCode = hashCode * 59 + this.TargetInputKbps.GetHashCode();
                if (this.TargetOps != null)
                    hashCode = hashCode * 59 + this.TargetOps.GetHashCode();
                if (this.IsMigrating != null)
                    hashCode = hashCode * 59 + this.IsMigrating.GetHashCode();
                return hashCode;
            }
        }
    }
}
