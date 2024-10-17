using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// ClickHouse同步信息。
    /// </summary>
    public class ChDatabaseReplicationInfo 
    {

        /// <summary>
        /// 源数据库。
        /// </summary>
        [JsonProperty("source_database", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabase { get; set; }

        /// <summary>
        /// 目标数据库。
        /// </summary>
        [JsonProperty("target_database", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabase { get; set; }

        /// <summary>
        /// 当前状态。 取值范围： - normal：正常 - abnormal：异常
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 同步阶段。 取值范围： - wait：等待同步 - failed：同步失败 - incremental：增量同步 - full：全量同步 - other：其他
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public string Stage { get; set; }

        /// <summary>
        /// 进度百分比。
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string Percentage { get; set; }

        /// <summary>
        /// 追赶阶段。 取值范围： - wait：等待同步 - failed：同步失败 - incremental：增量同步 - full：全量同步 - other：其他
        /// </summary>
        [JsonProperty("catchup_stage", NullValueHandling = NullValueHandling.Ignore)]
        public string CatchupStage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChDatabaseReplicationInfo {\n");
            sb.Append("  sourceDatabase: ").Append(SourceDatabase).Append("\n");
            sb.Append("  targetDatabase: ").Append(TargetDatabase).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  percentage: ").Append(Percentage).Append("\n");
            sb.Append("  catchupStage: ").Append(CatchupStage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChDatabaseReplicationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChDatabaseReplicationInfo input)
        {
            if (input == null) return false;
            if (this.SourceDatabase != input.SourceDatabase || (this.SourceDatabase != null && !this.SourceDatabase.Equals(input.SourceDatabase))) return false;
            if (this.TargetDatabase != input.TargetDatabase || (this.TargetDatabase != null && !this.TargetDatabase.Equals(input.TargetDatabase))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.Percentage != input.Percentage || (this.Percentage != null && !this.Percentage.Equals(input.Percentage))) return false;
            if (this.CatchupStage != input.CatchupStage || (this.CatchupStage != null && !this.CatchupStage.Equals(input.CatchupStage))) return false;

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
                if (this.SourceDatabase != null) hashCode = hashCode * 59 + this.SourceDatabase.GetHashCode();
                if (this.TargetDatabase != null) hashCode = hashCode * 59 + this.TargetDatabase.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Percentage != null) hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                if (this.CatchupStage != null) hashCode = hashCode * 59 + this.CatchupStage.GetHashCode();
                return hashCode;
            }
        }
    }
}
