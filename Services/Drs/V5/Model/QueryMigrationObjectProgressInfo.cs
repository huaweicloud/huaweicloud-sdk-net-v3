using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 迁移中对象进度信息体。
    /// </summary>
    public class QueryMigrationObjectProgressInfo 
    {

        /// <summary>
        /// 概览详情。
        /// </summary>
        [JsonProperty("migration_object_overview", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrationObjectOverviewInfo> MigrationObjectOverview { get; set; }

        /// <summary>
        /// 数据生成时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 全量开始时间。
        /// </summary>
        [JsonProperty("full_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FullStartTime { get; set; }

        /// <summary>
        /// 全量完成时间。
        /// </summary>
        [JsonProperty("full_complete_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FullCompleteTime { get; set; }

        /// <summary>
        /// 增量开始时间。
        /// </summary>
        [JsonProperty("incr_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? IncrStartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryMigrationObjectProgressInfo {\n");
            sb.Append("  migrationObjectOverview: ").Append(MigrationObjectOverview).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  fullStartTime: ").Append(FullStartTime).Append("\n");
            sb.Append("  fullCompleteTime: ").Append(FullCompleteTime).Append("\n");
            sb.Append("  incrStartTime: ").Append(IncrStartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryMigrationObjectProgressInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryMigrationObjectProgressInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MigrationObjectOverview == input.MigrationObjectOverview ||
                    this.MigrationObjectOverview != null &&
                    input.MigrationObjectOverview != null &&
                    this.MigrationObjectOverview.SequenceEqual(input.MigrationObjectOverview)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.FullStartTime == input.FullStartTime ||
                    (this.FullStartTime != null &&
                    this.FullStartTime.Equals(input.FullStartTime))
                ) && 
                (
                    this.FullCompleteTime == input.FullCompleteTime ||
                    (this.FullCompleteTime != null &&
                    this.FullCompleteTime.Equals(input.FullCompleteTime))
                ) && 
                (
                    this.IncrStartTime == input.IncrStartTime ||
                    (this.IncrStartTime != null &&
                    this.IncrStartTime.Equals(input.IncrStartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.MigrationObjectOverview != null)
                    hashCode = hashCode * 59 + this.MigrationObjectOverview.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.FullStartTime != null)
                    hashCode = hashCode * 59 + this.FullStartTime.GetHashCode();
                if (this.FullCompleteTime != null)
                    hashCode = hashCode * 59 + this.FullCompleteTime.GetHashCode();
                if (this.IncrStartTime != null)
                    hashCode = hashCode * 59 + this.IncrStartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
