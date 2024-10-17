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
    public class ListStarRocksDataReplicationConfigResponse : SdkResponse
    {

        /// <summary>
        /// GaussDB(for MySQL)实例ID。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// GaussDB(for MySQL)节点ID。
        /// </summary>
        [JsonProperty("source_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("database_info", NullValueHandling = NullValueHandling.Ignore)]
        public DataBaseInfo DatabaseInfo { get; set; }

        /// <summary>
        /// 表配置信息。
        /// </summary>
        [JsonProperty("table_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableConfigCheckResult> TableInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("table_repl_config", NullValueHandling = NullValueHandling.Ignore)]
        public TableReplConfig TableReplConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("new_table_repl_config", NullValueHandling = NullValueHandling.Ignore)]
        public TableReplConfig NewTableReplConfig { get; set; }

        /// <summary>
        /// 目标数据库名。
        /// </summary>
        [JsonProperty("target_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// 同步任务表是否变化。
        /// </summary>
        [JsonProperty("is_tables_change", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTablesChange { get; set; }

        /// <summary>
        /// 最近一次alter table的异常信息。
        /// </summary>
        [JsonProperty("last_error_of_alter_table", NullValueHandling = NullValueHandling.Ignore)]
        public string LastErrorOfAlterTable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStarRocksDataReplicationConfigResponse {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceNodeId: ").Append(SourceNodeId).Append("\n");
            sb.Append("  databaseInfo: ").Append(DatabaseInfo).Append("\n");
            sb.Append("  tableInfos: ").Append(TableInfos).Append("\n");
            sb.Append("  tableReplConfig: ").Append(TableReplConfig).Append("\n");
            sb.Append("  newTableReplConfig: ").Append(NewTableReplConfig).Append("\n");
            sb.Append("  targetDatabaseName: ").Append(TargetDatabaseName).Append("\n");
            sb.Append("  isTablesChange: ").Append(IsTablesChange).Append("\n");
            sb.Append("  lastErrorOfAlterTable: ").Append(LastErrorOfAlterTable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStarRocksDataReplicationConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStarRocksDataReplicationConfigResponse input)
        {
            if (input == null) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.SourceNodeId != input.SourceNodeId || (this.SourceNodeId != null && !this.SourceNodeId.Equals(input.SourceNodeId))) return false;
            if (this.DatabaseInfo != input.DatabaseInfo || (this.DatabaseInfo != null && !this.DatabaseInfo.Equals(input.DatabaseInfo))) return false;
            if (this.TableInfos != input.TableInfos || (this.TableInfos != null && input.TableInfos != null && !this.TableInfos.SequenceEqual(input.TableInfos))) return false;
            if (this.TableReplConfig != input.TableReplConfig || (this.TableReplConfig != null && !this.TableReplConfig.Equals(input.TableReplConfig))) return false;
            if (this.NewTableReplConfig != input.NewTableReplConfig || (this.NewTableReplConfig != null && !this.NewTableReplConfig.Equals(input.NewTableReplConfig))) return false;
            if (this.TargetDatabaseName != input.TargetDatabaseName || (this.TargetDatabaseName != null && !this.TargetDatabaseName.Equals(input.TargetDatabaseName))) return false;
            if (this.IsTablesChange != input.IsTablesChange || (this.IsTablesChange != null && !this.IsTablesChange.Equals(input.IsTablesChange))) return false;
            if (this.LastErrorOfAlterTable != input.LastErrorOfAlterTable || (this.LastErrorOfAlterTable != null && !this.LastErrorOfAlterTable.Equals(input.LastErrorOfAlterTable))) return false;

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
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SourceNodeId != null) hashCode = hashCode * 59 + this.SourceNodeId.GetHashCode();
                if (this.DatabaseInfo != null) hashCode = hashCode * 59 + this.DatabaseInfo.GetHashCode();
                if (this.TableInfos != null) hashCode = hashCode * 59 + this.TableInfos.GetHashCode();
                if (this.TableReplConfig != null) hashCode = hashCode * 59 + this.TableReplConfig.GetHashCode();
                if (this.NewTableReplConfig != null) hashCode = hashCode * 59 + this.NewTableReplConfig.GetHashCode();
                if (this.TargetDatabaseName != null) hashCode = hashCode * 59 + this.TargetDatabaseName.GetHashCode();
                if (this.IsTablesChange != null) hashCode = hashCode * 59 + this.IsTablesChange.GetHashCode();
                if (this.LastErrorOfAlterTable != null) hashCode = hashCode * 59 + this.LastErrorOfAlterTable.GetHashCode();
                return hashCode;
            }
        }
    }
}
