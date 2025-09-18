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
    /// 数据库表级对象。
    /// </summary>
    public class TableObject 
    {
        /// <summary>
        /// 对象类型。取值： - table：表。 - view：视图。 - procedure：存储过程。
        /// </summary>
        /// <value>对象类型。取值： - table：表。 - view：视图。 - procedure：存储过程。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum TABLE for value: table
            /// </summary>
            public static readonly TypeEnum TABLE = new TypeEnum("table");

            /// <summary>
            /// Enum VIEW for value: view
            /// </summary>
            public static readonly TypeEnum VIEW = new TypeEnum("view");

            /// <summary>
            /// Enum PROCEDURE for value: procedure
            /// </summary>
            public static readonly TypeEnum PROCEDURE = new TypeEnum("procedure");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "table", TABLE },
                { "view", VIEW },
                { "procedure", PROCEDURE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 该表在实时同步场景下的类型。取值： - config：仅当该表作为数据过滤高级设置的关联表时，需要填写，此时该表以及该表下的columns“不会”被同步到目标库，name、all、filtered、filter_conditions属性不生效，columns需要填写被关联的相关对象，config_conditions需要填写数据过滤高级设置的配置条件。（注意：如果需要同步该表级对象，则在下级对象中填写sync_type值为config。）
        /// </summary>
        [JsonProperty("sync_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncType { get; set; }

        /// <summary>
        /// 对象类型。取值： - table：表。 - view：视图。 - procedure：存储过程。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 该表在目标库的名称（表名映射）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否整表迁移或同步。注意： 1.当该表不需要做列过滤、列映射时，填true，如果需要做列过滤、列映射则填false； 2.当该表需要做附加列时，需要填true，并且在columns里填写附加列信息； 3.当该表所包含的列作为数据过滤高级设置的关联列时，需要填true，并且在columns里填写关联列信息、config_conditions填写数据过滤高级设置的配置条件；
        /// </summary>
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? All { get; set; }

        /// <summary>
        /// 一对多情况下，表级上对库名的映射。
        /// </summary>
        [JsonProperty("db_alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbAliasName { get; set; }

        /// <summary>
        /// 一对多情况下，表级上对schema名的映射。
        /// </summary>
        [JsonProperty("schema_alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaAliasName { get; set; }

        /// <summary>
        /// 该表是否进行数据过滤。
        /// </summary>
        [JsonProperty("filtered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filtered { get; set; }

        /// <summary>
        /// 该表数据的过滤条件，生成加工规则值为SQL条件语句，长度限制512。
        /// </summary>
        [JsonProperty("filter_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FilterConditions { get; set; }

        /// <summary>
        /// 该表数据过滤高级设置的配置条件，当该表作为联表查询时填写，生成加工规则值为SQL条件语句，长度限制512。
        /// </summary>
        [JsonProperty("config_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConfigConditions { get; set; }

        /// <summary>
        /// 是否已经进行同步。
        /// </summary>
        [JsonProperty("is_synchronized", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSynchronized { get; set; }

        /// <summary>
        /// 需要同步/映射/过滤/新增的列，当需要列过滤、列映射、附加列功能时填写，仅在实时同步任务中生效，当整表同步为false时需要填写。
        /// </summary>
        [JsonProperty("columns", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ColumnObject> Columns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableObject {\n");
            sb.Append("  syncType: ").Append(SyncType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  all: ").Append(All).Append("\n");
            sb.Append("  dbAliasName: ").Append(DbAliasName).Append("\n");
            sb.Append("  schemaAliasName: ").Append(SchemaAliasName).Append("\n");
            sb.Append("  filtered: ").Append(Filtered).Append("\n");
            sb.Append("  filterConditions: ").Append(FilterConditions).Append("\n");
            sb.Append("  configConditions: ").Append(ConfigConditions).Append("\n");
            sb.Append("  isSynchronized: ").Append(IsSynchronized).Append("\n");
            sb.Append("  columns: ").Append(Columns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TableObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TableObject input)
        {
            if (input == null) return false;
            if (this.SyncType != input.SyncType || (this.SyncType != null && !this.SyncType.Equals(input.SyncType))) return false;
            if (this.Type != input.Type) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.All != input.All || (this.All != null && !this.All.Equals(input.All))) return false;
            if (this.DbAliasName != input.DbAliasName || (this.DbAliasName != null && !this.DbAliasName.Equals(input.DbAliasName))) return false;
            if (this.SchemaAliasName != input.SchemaAliasName || (this.SchemaAliasName != null && !this.SchemaAliasName.Equals(input.SchemaAliasName))) return false;
            if (this.Filtered != input.Filtered || (this.Filtered != null && !this.Filtered.Equals(input.Filtered))) return false;
            if (this.FilterConditions != input.FilterConditions || (this.FilterConditions != null && input.FilterConditions != null && !this.FilterConditions.SequenceEqual(input.FilterConditions))) return false;
            if (this.ConfigConditions != input.ConfigConditions || (this.ConfigConditions != null && input.ConfigConditions != null && !this.ConfigConditions.SequenceEqual(input.ConfigConditions))) return false;
            if (this.IsSynchronized != input.IsSynchronized || (this.IsSynchronized != null && !this.IsSynchronized.Equals(input.IsSynchronized))) return false;
            if (this.Columns != input.Columns || (this.Columns != null && input.Columns != null && !this.Columns.SequenceEqual(input.Columns))) return false;

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
                if (this.SyncType != null) hashCode = hashCode * 59 + this.SyncType.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.All != null) hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.DbAliasName != null) hashCode = hashCode * 59 + this.DbAliasName.GetHashCode();
                if (this.SchemaAliasName != null) hashCode = hashCode * 59 + this.SchemaAliasName.GetHashCode();
                if (this.Filtered != null) hashCode = hashCode * 59 + this.Filtered.GetHashCode();
                if (this.FilterConditions != null) hashCode = hashCode * 59 + this.FilterConditions.GetHashCode();
                if (this.ConfigConditions != null) hashCode = hashCode * 59 + this.ConfigConditions.GetHashCode();
                if (this.IsSynchronized != null) hashCode = hashCode * 59 + this.IsSynchronized.GetHashCode();
                if (this.Columns != null) hashCode = hashCode * 59 + this.Columns.GetHashCode();
                return hashCode;
            }
        }
    }
}
