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
    /// StarRocks修改配置请求体。
    /// </summary>
    public class ModifyDataSyncConfigRequestV3 
    {

        /// <summary>
        /// **参数解释**：  TaurusDB实例ID。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字组成，后缀为in07，长度为36个字符。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  TaurusDB只读节点ID。  **约束限制**：  不涉及。  **取值范围**：  只能由英文字母、数字组成，后缀为no07，长度为36个字符。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("source_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// **参数解释**：  TaurusDB数据库名。  **约束限制**：  不涉及。  **取值范围**：  字符长度限制3~1024位，仅支持英文大小写字母、数字以及下划线。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("source_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// **参数解释**：  数据同步任务名称。  **约束限制**：  不涉及。  **取值范围**：  长度限制3~128位，仅支持英文大小写字母、数字以及下划线。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数解释**：  库配置列表。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("db_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DbConfig> DbConfigs { get; set; }

        /// <summary>
        /// **参数解释**：  表配置信息。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("tables_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TablesConfig> TablesConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("table_repl_config", NullValueHandling = NullValueHandling.Ignore)]
        public TableReplConfig TableReplConfig { get; set; }

        /// <summary>
        /// **参数解释**：  目标数据库名。  **约束限制**：  不涉及。  **取值范围**：  长度限制3~128位，仅支持英文大小写字母、数字以及下划线。  **默认值**：  不涉及。
        /// </summary>
        [JsonProperty("target_database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// **参数解释**：  是否支持实例级同步。  **约束限制**：  不涉及。  **取值范围**：  - true：是。 - false：否。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("is_instance_level_sync", NullValueHandling = NullValueHandling.Ignore)]
        public string IsInstanceLevelSync { get; set; }

        /// <summary>
        /// **参数解释**：  库同步范围。  **约束限制**：  不涉及。  **取值范围**：  - all：同步全部库。 - part：同步部分库。  **默认取值**：  part。
        /// </summary>
        [JsonProperty("database_repl_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseReplScope { get; set; }

        /// <summary>
        /// **参数解释**：  是否支持通配符。  **约束限制**：  不涉及。  **取值范围**：  - true：支持通配符。 - false：不支持通配符。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("is_support_reg_exp", NullValueHandling = NullValueHandling.Ignore)]
        public string IsSupportRegExp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyDataSyncConfigRequestV3 {\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  sourceNodeId: ").Append(SourceNodeId).Append("\n");
            sb.Append("  sourceDatabaseName: ").Append(SourceDatabaseName).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  dbConfigs: ").Append(DbConfigs).Append("\n");
            sb.Append("  tablesConfigs: ").Append(TablesConfigs).Append("\n");
            sb.Append("  tableReplConfig: ").Append(TableReplConfig).Append("\n");
            sb.Append("  targetDatabaseName: ").Append(TargetDatabaseName).Append("\n");
            sb.Append("  isInstanceLevelSync: ").Append(IsInstanceLevelSync).Append("\n");
            sb.Append("  databaseReplScope: ").Append(DatabaseReplScope).Append("\n");
            sb.Append("  isSupportRegExp: ").Append(IsSupportRegExp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyDataSyncConfigRequestV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyDataSyncConfigRequestV3 input)
        {
            if (input == null) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.SourceNodeId != input.SourceNodeId || (this.SourceNodeId != null && !this.SourceNodeId.Equals(input.SourceNodeId))) return false;
            if (this.SourceDatabaseName != input.SourceDatabaseName || (this.SourceDatabaseName != null && !this.SourceDatabaseName.Equals(input.SourceDatabaseName))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.DbConfigs != input.DbConfigs || (this.DbConfigs != null && input.DbConfigs != null && !this.DbConfigs.SequenceEqual(input.DbConfigs))) return false;
            if (this.TablesConfigs != input.TablesConfigs || (this.TablesConfigs != null && input.TablesConfigs != null && !this.TablesConfigs.SequenceEqual(input.TablesConfigs))) return false;
            if (this.TableReplConfig != input.TableReplConfig || (this.TableReplConfig != null && !this.TableReplConfig.Equals(input.TableReplConfig))) return false;
            if (this.TargetDatabaseName != input.TargetDatabaseName || (this.TargetDatabaseName != null && !this.TargetDatabaseName.Equals(input.TargetDatabaseName))) return false;
            if (this.IsInstanceLevelSync != input.IsInstanceLevelSync || (this.IsInstanceLevelSync != null && !this.IsInstanceLevelSync.Equals(input.IsInstanceLevelSync))) return false;
            if (this.DatabaseReplScope != input.DatabaseReplScope || (this.DatabaseReplScope != null && !this.DatabaseReplScope.Equals(input.DatabaseReplScope))) return false;
            if (this.IsSupportRegExp != input.IsSupportRegExp || (this.IsSupportRegExp != null && !this.IsSupportRegExp.Equals(input.IsSupportRegExp))) return false;

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
                if (this.SourceDatabaseName != null) hashCode = hashCode * 59 + this.SourceDatabaseName.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.DbConfigs != null) hashCode = hashCode * 59 + this.DbConfigs.GetHashCode();
                if (this.TablesConfigs != null) hashCode = hashCode * 59 + this.TablesConfigs.GetHashCode();
                if (this.TableReplConfig != null) hashCode = hashCode * 59 + this.TableReplConfig.GetHashCode();
                if (this.TargetDatabaseName != null) hashCode = hashCode * 59 + this.TargetDatabaseName.GetHashCode();
                if (this.IsInstanceLevelSync != null) hashCode = hashCode * 59 + this.IsInstanceLevelSync.GetHashCode();
                if (this.DatabaseReplScope != null) hashCode = hashCode * 59 + this.DatabaseReplScope.GetHashCode();
                if (this.IsSupportRegExp != null) hashCode = hashCode * 59 + this.IsSupportRegExp.GetHashCode();
                return hashCode;
            }
        }
    }
}
