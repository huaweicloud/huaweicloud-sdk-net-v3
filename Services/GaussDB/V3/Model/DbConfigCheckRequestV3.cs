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
    /// HTAP库配置校验请求体。
    /// </summary>
    public class DbConfigCheckRequestV3 
    {

        /// <summary>
        /// GaussDB(for MySQL)实例ID。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// GaussDB(for MySQL)只读节点ID。如为空，则取GaussDB(for MySQL)主节点ID
        /// </summary>
        [JsonProperty("source_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// GaussDB(for MySQL)数据库名。
        /// </summary>
        [JsonProperty("source_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// 目标数据库名。字符长度限制3~128位，仅支持英文大小写字母、数字以及下划线_。
        /// </summary>
        [JsonProperty("target_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// 同步任务名称。字符长度限制3~128位，仅支持英文大小写字母、数字以及下划线_。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 库配置列表。
        /// </summary>
        [JsonProperty("db_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbConfig> DbConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("table_repl_config", NullValueHandling = NullValueHandling.Ignore)]
        public TableReplConfig TableReplConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbConfigCheckRequestV3 {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceNodeId: ").Append(SourceNodeId).Append("\n");
            sb.Append("  sourceDatabaseName: ").Append(SourceDatabaseName).Append("\n");
            sb.Append("  targetDatabaseName: ").Append(TargetDatabaseName).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  dbConfigs: ").Append(DbConfigs).Append("\n");
            sb.Append("  tableReplConfig: ").Append(TableReplConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbConfigCheckRequestV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbConfigCheckRequestV3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceInstanceId == input.SourceInstanceId ||
                    (this.SourceInstanceId != null &&
                    this.SourceInstanceId.Equals(input.SourceInstanceId))
                ) && 
                (
                    this.SourceNodeId == input.SourceNodeId ||
                    (this.SourceNodeId != null &&
                    this.SourceNodeId.Equals(input.SourceNodeId))
                ) && 
                (
                    this.SourceDatabaseName == input.SourceDatabaseName ||
                    (this.SourceDatabaseName != null &&
                    this.SourceDatabaseName.Equals(input.SourceDatabaseName))
                ) && 
                (
                    this.TargetDatabaseName == input.TargetDatabaseName ||
                    (this.TargetDatabaseName != null &&
                    this.TargetDatabaseName.Equals(input.TargetDatabaseName))
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
                ) && 
                (
                    this.DbConfigs == input.DbConfigs ||
                    this.DbConfigs != null &&
                    input.DbConfigs != null &&
                    this.DbConfigs.SequenceEqual(input.DbConfigs)
                ) && 
                (
                    this.TableReplConfig == input.TableReplConfig ||
                    (this.TableReplConfig != null &&
                    this.TableReplConfig.Equals(input.TableReplConfig))
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
                if (this.SourceInstanceId != null)
                    hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceNodeId != null)
                    hashCode = hashCode * 59 + this.SourceNodeId.GetHashCode();
                if (this.SourceDatabaseName != null)
                    hashCode = hashCode * 59 + this.SourceDatabaseName.GetHashCode();
                if (this.TargetDatabaseName != null)
                    hashCode = hashCode * 59 + this.TargetDatabaseName.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.DbConfigs != null)
                    hashCode = hashCode * 59 + this.DbConfigs.GetHashCode();
                if (this.TableReplConfig != null)
                    hashCode = hashCode * 59 + this.TableReplConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
