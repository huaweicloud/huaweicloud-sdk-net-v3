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
    /// 数据库列信息。
    /// </summary>
    public class ColumnObject 
    {

        /// <summary>
        /// 该列在实时同步场景下的类型。取值： - config：当该列作为数据过滤高级设置的关联列时，需要填写，同时如果该列是主建或优化查询所需的索引，则需要填写primary_key_for_data_filtering或index_for_data_filtering。（注意：是否同步该列到目标库由“filtered”属性控制，与库级、模式级、表级控制方式不同。）
        /// </summary>
        [JsonProperty("sync_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncType { get; set; }

        /// <summary>
        /// 该列是否在数据过滤高级设置场景下为主键，如果是主建则填该列列名，否则不填。
        /// </summary>
        [JsonProperty("primary_key_for_data_filtering", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryKeyForDataFiltering { get; set; }

        /// <summary>
        /// 优化查询所需的索引，将会为缓存数据增加索引，不会影响源表，当该列作为数据过滤高级设置的关联索引时，需要填写，否则不填。
        /// </summary>
        [JsonProperty("index_for_data_filtering", NullValueHandling = NullValueHandling.Ignore)]
        public string IndexForDataFiltering { get; set; }

        /// <summary>
        /// 该列在目标库的名称（列名映射），当该列为“附加列”时须与数据库表级对象中列名保持一致。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 该列字段的数据类型。 列过滤：填写源列字段的数据类型。 附加列：新填充的列指定字段的数据类型，根据不同操作类型来决定取值范围与约束。取值： - 以默认值方式，支持：int,long,varchar(256),datetime,timestamp。 - 以create_time为列，支持：long,datetime,timestamp。 - 以update_time为列，支持：long,datetime,timestamp。 - 以表达式为列，支持：varchar(256)，且列值仅为：concat(__current_database, &#39;@&#39;, __current_table) - 以serverName@database@table为列，支持：varchar(256)。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 该列是否在列映射场景下为主键，如果是主建则填PRI，否则填空。
        /// </summary>
        [JsonProperty("primary_key_for_column_filtering", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryKeyForColumnFiltering { get; set; }

        /// <summary>
        /// 该列是否进列过滤，不能与附加列additional同时使用。取值： - true：表示同步该列。 - false：表示过滤该列不同步。
        /// </summary>
        [JsonProperty("filtered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filtered { get; set; }

        /// <summary>
        /// 该列是否为附加列，当该列为附加列时：name必须与表级对象中列名一致，并且不能与列过滤filtered同时使用。
        /// </summary>
        [JsonProperty("additional", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Additional { get; set; }

        /// <summary>
        /// 操作类型，以特定的操作类型填充新加的列。取值： - 以默认值方式：\&quot;operation_type\&quot;:\&quot;ADDITIONALCOLUMN,default_value\&quot; - 以create_time为列：\&quot;operation_type\&quot;:\&quot;ADDITIONALCOLUMN,create_time\&quot; - 以update_time为列：\&quot;operation_type\&quot;:\&quot;ADDITIONALCOLUMN,update_time\&quot; - 以表达式为列：\&quot;operation_type\&quot;:\&quot;ADDITIONALCOLUMN,expression\&quot; - 以serverName@database@table为列：\&quot;operation_type\&quot;:\&quot;ADDITIONALCOLUMN,server_database_table\&quot;
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// 附加列的值。约束： - 当操作类型仅“以默认值方式”，“以serverName@database@table为列”时，才支持输入对应字段类型的值。 - 当操作类型为“以表达式为列”时，该字段为固定值\&quot;concat(__current_database, &#39;@&#39;, __current_table)\&quot;，不需要填写。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnObject {\n");
            sb.Append("  syncType: ").Append(SyncType).Append("\n");
            sb.Append("  primaryKeyForDataFiltering: ").Append(PrimaryKeyForDataFiltering).Append("\n");
            sb.Append("  indexForDataFiltering: ").Append(IndexForDataFiltering).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  primaryKeyForColumnFiltering: ").Append(PrimaryKeyForColumnFiltering).Append("\n");
            sb.Append("  filtered: ").Append(Filtered).Append("\n");
            sb.Append("  additional: ").Append(Additional).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColumnObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColumnObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SyncType == input.SyncType ||
                    (this.SyncType != null &&
                    this.SyncType.Equals(input.SyncType))
                ) && 
                (
                    this.PrimaryKeyForDataFiltering == input.PrimaryKeyForDataFiltering ||
                    (this.PrimaryKeyForDataFiltering != null &&
                    this.PrimaryKeyForDataFiltering.Equals(input.PrimaryKeyForDataFiltering))
                ) && 
                (
                    this.IndexForDataFiltering == input.IndexForDataFiltering ||
                    (this.IndexForDataFiltering != null &&
                    this.IndexForDataFiltering.Equals(input.IndexForDataFiltering))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PrimaryKeyForColumnFiltering == input.PrimaryKeyForColumnFiltering ||
                    (this.PrimaryKeyForColumnFiltering != null &&
                    this.PrimaryKeyForColumnFiltering.Equals(input.PrimaryKeyForColumnFiltering))
                ) && 
                (
                    this.Filtered == input.Filtered ||
                    (this.Filtered != null &&
                    this.Filtered.Equals(input.Filtered))
                ) && 
                (
                    this.Additional == input.Additional ||
                    (this.Additional != null &&
                    this.Additional.Equals(input.Additional))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.SyncType != null)
                    hashCode = hashCode * 59 + this.SyncType.GetHashCode();
                if (this.PrimaryKeyForDataFiltering != null)
                    hashCode = hashCode * 59 + this.PrimaryKeyForDataFiltering.GetHashCode();
                if (this.IndexForDataFiltering != null)
                    hashCode = hashCode * 59 + this.IndexForDataFiltering.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PrimaryKeyForColumnFiltering != null)
                    hashCode = hashCode * 59 + this.PrimaryKeyForColumnFiltering.GetHashCode();
                if (this.Filtered != null)
                    hashCode = hashCode * 59 + this.Filtered.GetHashCode();
                if (this.Additional != null)
                    hashCode = hashCode * 59 + this.Additional.GetHashCode();
                if (this.OperationType != null)
                    hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
