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
    /// Response Object
    /// </summary>
    public class CheckTableConfigResponse : SdkResponse
    {

        /// <summary>
        /// TaurusDB数据库名。
        /// </summary>
        [JsonProperty("source_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// 目标数据库名。
        /// </summary>
        [JsonProperty("target_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// 表配置检查结果。
        /// </summary>
        [JsonProperty("tbl_config_check_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableConfigCheckResult> TblConfigCheckResults { get; set; }

        /// <summary>
        /// 同步任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckTableConfigResponse {\n");
            sb.Append("  sourceDatabaseName: ").Append(SourceDatabaseName).Append("\n");
            sb.Append("  targetDatabaseName: ").Append(TargetDatabaseName).Append("\n");
            sb.Append("  tblConfigCheckResults: ").Append(TblConfigCheckResults).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckTableConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckTableConfigResponse input)
        {
            if (input == null) return false;
            if (this.SourceDatabaseName != input.SourceDatabaseName || (this.SourceDatabaseName != null && !this.SourceDatabaseName.Equals(input.SourceDatabaseName))) return false;
            if (this.TargetDatabaseName != input.TargetDatabaseName || (this.TargetDatabaseName != null && !this.TargetDatabaseName.Equals(input.TargetDatabaseName))) return false;
            if (this.TblConfigCheckResults != input.TblConfigCheckResults || (this.TblConfigCheckResults != null && input.TblConfigCheckResults != null && !this.TblConfigCheckResults.SequenceEqual(input.TblConfigCheckResults))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;

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
                if (this.SourceDatabaseName != null) hashCode = hashCode * 59 + this.SourceDatabaseName.GetHashCode();
                if (this.TargetDatabaseName != null) hashCode = hashCode * 59 + this.TargetDatabaseName.GetHashCode();
                if (this.TblConfigCheckResults != null) hashCode = hashCode * 59 + this.TblConfigCheckResults.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                return hashCode;
            }
        }
    }
}
