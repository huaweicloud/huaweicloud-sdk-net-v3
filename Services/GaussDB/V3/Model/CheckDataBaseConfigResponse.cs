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
    public class CheckDataBaseConfigResponse : SdkResponse
    {

        /// <summary>
        /// GaussDB(for MySQL)数据库名称。
        /// </summary>
        [JsonProperty("source_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// GaussDB(for MySQL)数据库配置检查结果。
        /// </summary>
        [JsonProperty("source_db_config_check_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbConfigCheckResult> SourceDbConfigCheckResults { get; set; }

        /// <summary>
        /// 目标数据库名称。
        /// </summary>
        [JsonProperty("target_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// 目标数据库配置检查结果。
        /// </summary>
        [JsonProperty("target_db_config_check_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbConfigCheckResult> TargetDbConfigCheckResults { get; set; }

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
            sb.Append("class CheckDataBaseConfigResponse {\n");
            sb.Append("  sourceDatabaseName: ").Append(SourceDatabaseName).Append("\n");
            sb.Append("  sourceDbConfigCheckResults: ").Append(SourceDbConfigCheckResults).Append("\n");
            sb.Append("  targetDatabaseName: ").Append(TargetDatabaseName).Append("\n");
            sb.Append("  targetDbConfigCheckResults: ").Append(TargetDbConfigCheckResults).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckDataBaseConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckDataBaseConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceDatabaseName == input.SourceDatabaseName ||
                    (this.SourceDatabaseName != null &&
                    this.SourceDatabaseName.Equals(input.SourceDatabaseName))
                ) && 
                (
                    this.SourceDbConfigCheckResults == input.SourceDbConfigCheckResults ||
                    this.SourceDbConfigCheckResults != null &&
                    input.SourceDbConfigCheckResults != null &&
                    this.SourceDbConfigCheckResults.SequenceEqual(input.SourceDbConfigCheckResults)
                ) && 
                (
                    this.TargetDatabaseName == input.TargetDatabaseName ||
                    (this.TargetDatabaseName != null &&
                    this.TargetDatabaseName.Equals(input.TargetDatabaseName))
                ) && 
                (
                    this.TargetDbConfigCheckResults == input.TargetDbConfigCheckResults ||
                    this.TargetDbConfigCheckResults != null &&
                    input.TargetDbConfigCheckResults != null &&
                    this.TargetDbConfigCheckResults.SequenceEqual(input.TargetDbConfigCheckResults)
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
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
                if (this.SourceDatabaseName != null)
                    hashCode = hashCode * 59 + this.SourceDatabaseName.GetHashCode();
                if (this.SourceDbConfigCheckResults != null)
                    hashCode = hashCode * 59 + this.SourceDbConfigCheckResults.GetHashCode();
                if (this.TargetDatabaseName != null)
                    hashCode = hashCode * 59 + this.TargetDatabaseName.GetHashCode();
                if (this.TargetDbConfigCheckResults != null)
                    hashCode = hashCode * 59 + this.TargetDbConfigCheckResults.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                return hashCode;
            }
        }
    }
}
