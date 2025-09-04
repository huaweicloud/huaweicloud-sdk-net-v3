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
    /// 查询HTAP主实例数据库表列表请求体。
    /// </summary>
    public class QueryTableRequestV3 
    {

        /// <summary>
        /// **参数解释**：  查询的数据库及表名称的列表。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("database_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseTablesInfo> DatabaseTables { get; set; }

        /// <summary>
        /// **参数解释**：  需要查询数据库的源实例ID，严格匹配UUID规则。  **约束限制**：  只能由英文字母、数字组成，且长度为36个字符。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("source_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// **参数解释**：  已选择的数据库及表名称的列表。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("selected_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseTablesInfo> SelectedTables { get; set; }

        /// <summary>
        /// **参数解释**：  表黑白名单设置。include_tables：白名单，exclude_tables：黑名单。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTableRequestV3 {\n");
            sb.Append("  databaseTables: ").Append(DatabaseTables).Append("\n");
            sb.Append("  sourceInstanceId: ").Append(SourceInstanceId).Append("\n");
            sb.Append("  selectedTables: ").Append(SelectedTables).Append("\n");
            sb.Append("  filterType: ").Append(FilterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTableRequestV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTableRequestV3 input)
        {
            if (input == null) return false;
            if (this.DatabaseTables != input.DatabaseTables || (this.DatabaseTables != null && input.DatabaseTables != null && !this.DatabaseTables.SequenceEqual(input.DatabaseTables))) return false;
            if (this.SourceInstanceId != input.SourceInstanceId || (this.SourceInstanceId != null && !this.SourceInstanceId.Equals(input.SourceInstanceId))) return false;
            if (this.SelectedTables != input.SelectedTables || (this.SelectedTables != null && input.SelectedTables != null && !this.SelectedTables.SequenceEqual(input.SelectedTables))) return false;
            if (this.FilterType != input.FilterType || (this.FilterType != null && !this.FilterType.Equals(input.FilterType))) return false;

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
                if (this.DatabaseTables != null) hashCode = hashCode * 59 + this.DatabaseTables.GetHashCode();
                if (this.SourceInstanceId != null) hashCode = hashCode * 59 + this.SourceInstanceId.GetHashCode();
                if (this.SelectedTables != null) hashCode = hashCode * 59 + this.SelectedTables.GetHashCode();
                if (this.FilterType != null) hashCode = hashCode * 59 + this.FilterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
