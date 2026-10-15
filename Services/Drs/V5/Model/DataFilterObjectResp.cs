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
    /// 数据过滤对象信息
    /// </summary>
    public class DataFilterObjectResp 
    {
        /// <summary>
        /// 标记该对象是否启用数据过滤。
        /// </summary>
        /// <value>标记该对象是否启用数据过滤。</value>
        [JsonConverter(typeof(EnumClassConverter<IsDataFilterEnum>))]
        public class IsDataFilterEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsDataFilterEnum TRUE = new IsDataFilterEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsDataFilterEnum FALSE = new IsDataFilterEnum("false");

            private static readonly Dictionary<string, IsDataFilterEnum> StaticFields =
            new Dictionary<string, IsDataFilterEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsDataFilterEnum()
            {

            }

            public IsDataFilterEnum(string value)
            {
                _value = value;
            }

            public static IsDataFilterEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as IsDataFilterEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsDataFilterEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsDataFilterEnum a, IsDataFilterEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(IsDataFilterEnum a, IsDataFilterEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据过滤对象信息批次ID，与父级DataFilterRuleResp的batch_id关联，用于追溯对象归属的批次
        /// </summary>
        [JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BatchId { get; set; }

        /// <summary>
        /// 数据过滤对象的唯一标识符，由对象层级结构（库名、表名、对象类型等）组合生成
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 父级过滤对象的标识符，用于表示对象之间的层级归属关系（如列归属于表、表归属于库）。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 数据过滤对象的名称，按object_type不同可为库名、表名或列名。
        /// </summary>
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        /// <summary>
        /// 数据过滤对象的映射名称（别名），在目标端数据库对象名与源端不一致时使用。
        /// </summary>
        [JsonProperty("object_alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectAliasName { get; set; }

        /// <summary>
        /// 数据过滤对象的层级类型，标识当前过滤规则粒度级别。
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 数据过滤对象所属的数据库名称。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 数据过滤对象所属的schema名。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 数据过滤对象所属的表名。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 标记该对象是否启用数据过滤。
        /// </summary>
        [JsonProperty("is_data_filter", NullValueHandling = NullValueHandling.Ignore)]
        public IsDataFilterEnum IsDataFilter { get; set; }
        /// <summary>
        /// 数据过滤的类型，标识使用的过滤策略。
        /// </summary>
        [JsonProperty("data_filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataFilterType { get; set; }

        /// <summary>
        /// 数据过滤条件
        /// </summary>
        [JsonProperty("filter_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterCondition { get; set; }

        /// <summary>
        /// 数据过滤条件是否已同步
        /// </summary>
        [JsonProperty("is_synchronized", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSynchronized { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataFilterObjectResp {\n");
            sb.Append("  batchId: ").Append(BatchId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  objectName: ").Append(ObjectName).Append("\n");
            sb.Append("  objectAliasName: ").Append(ObjectAliasName).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  isDataFilter: ").Append(IsDataFilter).Append("\n");
            sb.Append("  dataFilterType: ").Append(DataFilterType).Append("\n");
            sb.Append("  filterCondition: ").Append(FilterCondition).Append("\n");
            sb.Append("  isSynchronized: ").Append(IsSynchronized).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataFilterObjectResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataFilterObjectResp input)
        {
            if (input == null) return false;
            if (this.BatchId != input.BatchId || (this.BatchId != null && !this.BatchId.Equals(input.BatchId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.ObjectName != input.ObjectName || (this.ObjectName != null && !this.ObjectName.Equals(input.ObjectName))) return false;
            if (this.ObjectAliasName != input.ObjectAliasName || (this.ObjectAliasName != null && !this.ObjectAliasName.Equals(input.ObjectAliasName))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.IsDataFilter != input.IsDataFilter) return false;
            if (this.DataFilterType != input.DataFilterType || (this.DataFilterType != null && !this.DataFilterType.Equals(input.DataFilterType))) return false;
            if (this.FilterCondition != input.FilterCondition || (this.FilterCondition != null && !this.FilterCondition.Equals(input.FilterCondition))) return false;
            if (this.IsSynchronized != input.IsSynchronized || (this.IsSynchronized != null && !this.IsSynchronized.Equals(input.IsSynchronized))) return false;

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
                if (this.BatchId != null) hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ObjectName != null) hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.ObjectAliasName != null) hashCode = hashCode * 59 + this.ObjectAliasName.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                hashCode = hashCode * 59 + this.IsDataFilter.GetHashCode();
                if (this.DataFilterType != null) hashCode = hashCode * 59 + this.DataFilterType.GetHashCode();
                if (this.FilterCondition != null) hashCode = hashCode * 59 + this.FilterCondition.GetHashCode();
                if (this.IsSynchronized != null) hashCode = hashCode * 59 + this.IsSynchronized.GetHashCode();
                return hashCode;
            }
        }
    }
}
