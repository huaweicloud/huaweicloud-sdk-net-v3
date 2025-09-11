using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExportTableVolumeRequestBody 
    {
        /// <summary>
        /// **参数解释**: 排序字段。 **约束限制**: 不涉及。 **取值范围**: - table_size：表的大小。 - id：表ID。 - table_name：表名称。 - table_owner：表所属用户名称。 - database_name：数据库名称。 - schema_name：schema名称。 - is_part_type：表或者索引是否具有分区表的性质。 - is_hash_cluster_key：是否包含hash分区列信息。 - tuples：表中行的数目。 - create_time：创建时间。 - update_time：修改时间。 - average_size：表大小平均值(totalsize/DN个数，该值为平均分布的理想情况下，表在各DN占用空间大小)。 - max_ratio：单DN表大小最大值占比（表在各DN占用空间的最大值/totalsize）。 - min_ratio：单DN表大小最小值占比（表在各DN占用空间的最小值/totalsize）。 - skew_size：表分布倾斜值（单DN表大小最大值 - 单DN表大小最小值）。 - skew_ratio：表分布倾斜率（skewsize/totalsize）。 - skew_stddev：表分布标准方差（在表大小一定的情况下，该值越大表明表的整体分布情况越倾斜）。  **默认取值** 不涉及。 
        /// </summary>
        /// <value>**参数解释**: 排序字段。 **约束限制**: 不涉及。 **取值范围**: - table_size：表的大小。 - id：表ID。 - table_name：表名称。 - table_owner：表所属用户名称。 - database_name：数据库名称。 - schema_name：schema名称。 - is_part_type：表或者索引是否具有分区表的性质。 - is_hash_cluster_key：是否包含hash分区列信息。 - tuples：表中行的数目。 - create_time：创建时间。 - update_time：修改时间。 - average_size：表大小平均值(totalsize/DN个数，该值为平均分布的理想情况下，表在各DN占用空间大小)。 - max_ratio：单DN表大小最大值占比（表在各DN占用空间的最大值/totalsize）。 - min_ratio：单DN表大小最小值占比（表在各DN占用空间的最小值/totalsize）。 - skew_size：表分布倾斜值（单DN表大小最大值 - 单DN表大小最小值）。 - skew_ratio：表分布倾斜率（skewsize/totalsize）。 - skew_stddev：表分布标准方差（在表大小一定的情况下，该值越大表明表的整体分布情况越倾斜）。  **默认取值** 不涉及。 </value>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum TABLE_SIZE for value: table_size
            /// </summary>
            public static readonly SortKeyEnum TABLE_SIZE = new SortKeyEnum("table_size");

            /// <summary>
            /// Enum ID for value: id
            /// </summary>
            public static readonly SortKeyEnum ID = new SortKeyEnum("id");

            /// <summary>
            /// Enum TABLE_NAME for value: table_name
            /// </summary>
            public static readonly SortKeyEnum TABLE_NAME = new SortKeyEnum("table_name");

            /// <summary>
            /// Enum TABLE_OWNER for value: table_owner
            /// </summary>
            public static readonly SortKeyEnum TABLE_OWNER = new SortKeyEnum("table_owner");

            /// <summary>
            /// Enum DATABASE_NAME for value: database_name
            /// </summary>
            public static readonly SortKeyEnum DATABASE_NAME = new SortKeyEnum("database_name");

            /// <summary>
            /// Enum SCHEMA_NAME for value: schema_name
            /// </summary>
            public static readonly SortKeyEnum SCHEMA_NAME = new SortKeyEnum("schema_name");

            /// <summary>
            /// Enum IS_PART_TYPE for value: is_part_type
            /// </summary>
            public static readonly SortKeyEnum IS_PART_TYPE = new SortKeyEnum("is_part_type");

            /// <summary>
            /// Enum IS_HASH_CLUSTER_KEY for value: is_hash_cluster_key
            /// </summary>
            public static readonly SortKeyEnum IS_HASH_CLUSTER_KEY = new SortKeyEnum("is_hash_cluster_key");

            /// <summary>
            /// Enum TUPLES for value: tuples
            /// </summary>
            public static readonly SortKeyEnum TUPLES = new SortKeyEnum("tuples");

            /// <summary>
            /// Enum CREATE_TIME for value: create_time
            /// </summary>
            public static readonly SortKeyEnum CREATE_TIME = new SortKeyEnum("create_time");

            /// <summary>
            /// Enum UPDATE_TIME for value: update_time
            /// </summary>
            public static readonly SortKeyEnum UPDATE_TIME = new SortKeyEnum("update_time");

            /// <summary>
            /// Enum AVERAGE_SIZE for value: average_size
            /// </summary>
            public static readonly SortKeyEnum AVERAGE_SIZE = new SortKeyEnum("average_size");

            /// <summary>
            /// Enum MAX_RATIO for value: max_ratio
            /// </summary>
            public static readonly SortKeyEnum MAX_RATIO = new SortKeyEnum("max_ratio");

            /// <summary>
            /// Enum MIN_RATIO for value: min_ratio
            /// </summary>
            public static readonly SortKeyEnum MIN_RATIO = new SortKeyEnum("min_ratio");

            /// <summary>
            /// Enum SKEW_SIZE for value: skew_size
            /// </summary>
            public static readonly SortKeyEnum SKEW_SIZE = new SortKeyEnum("skew_size");

            /// <summary>
            /// Enum SKEW_RATIO for value: skew_ratio
            /// </summary>
            public static readonly SortKeyEnum SKEW_RATIO = new SortKeyEnum("skew_ratio");

            /// <summary>
            /// Enum SKEW_STDDEV for value: skew_stddev
            /// </summary>
            public static readonly SortKeyEnum SKEW_STDDEV = new SortKeyEnum("skew_stddev");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "table_size", TABLE_SIZE },
                { "id", ID },
                { "table_name", TABLE_NAME },
                { "table_owner", TABLE_OWNER },
                { "database_name", DATABASE_NAME },
                { "schema_name", SCHEMA_NAME },
                { "is_part_type", IS_PART_TYPE },
                { "is_hash_cluster_key", IS_HASH_CLUSTER_KEY },
                { "tuples", TUPLES },
                { "create_time", CREATE_TIME },
                { "update_time", UPDATE_TIME },
                { "average_size", AVERAGE_SIZE },
                { "max_ratio", MAX_RATIO },
                { "min_ratio", MIN_RATIO },
                { "skew_size", SKEW_SIZE },
                { "skew_ratio", SKEW_RATIO },
                { "skew_stddev", SKEW_STDDEV },
            };

            private string _value;

            public SortKeyEnum()
            {

            }

            public SortKeyEnum(string value)
            {
                _value = value;
            }

            public static SortKeyEnum FromValue(string value)
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释** 实时会话统计排序方式。 **约束限制**: 不涉及。 **取值范围** - ASC：根据sort_key值升序。 - DESC：根据sort_key值降序。  **默认取值** ASC 
        /// </summary>
        /// <value>**参数解释** 实时会话统计排序方式。 **约束限制**: 不涉及。 **取值范围** - ASC：根据sort_key值升序。 - DESC：根据sort_key值降序。  **默认取值** ASC </value>
        [JsonConverter(typeof(EnumClassConverter<SortOrderEnum>))]
        public class SortOrderEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortOrderEnum ASC = new SortOrderEnum("ASC");

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortOrderEnum DESC = new SortOrderEnum("DESC");

            private static readonly Dictionary<string, SortOrderEnum> StaticFields =
            new Dictionary<string, SortOrderEnum>()
            {
                { "ASC", ASC },
                { "DESC", DESC },
            };

            private string _value;

            public SortOrderEnum()
            {

            }

            public SortOrderEnum(string value)
            {
                _value = value;
            }

            public static SortOrderEnum FromValue(string value)
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

                if (this.Equals(obj as SortOrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortOrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortOrderEnum a, SortOrderEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SortOrderEnum a, SortOrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 数据库名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**: schema名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("schema_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SchemaNames { get; set; }

        /// <summary>
        /// **参数解释**: 表名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**: 表所属用户名称。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**: 排序字段。 **约束限制**: 不涉及。 **取值范围**: - table_size：表的大小。 - id：表ID。 - table_name：表名称。 - table_owner：表所属用户名称。 - database_name：数据库名称。 - schema_name：schema名称。 - is_part_type：表或者索引是否具有分区表的性质。 - is_hash_cluster_key：是否包含hash分区列信息。 - tuples：表中行的数目。 - create_time：创建时间。 - update_time：修改时间。 - average_size：表大小平均值(totalsize/DN个数，该值为平均分布的理想情况下，表在各DN占用空间大小)。 - max_ratio：单DN表大小最大值占比（表在各DN占用空间的最大值/totalsize）。 - min_ratio：单DN表大小最小值占比（表在各DN占用空间的最小值/totalsize）。 - skew_size：表分布倾斜值（单DN表大小最大值 - 单DN表大小最小值）。 - skew_ratio：表分布倾斜率（skewsize/totalsize）。 - skew_stddev：表分布标准方差（在表大小一定的情况下，该值越大表明表的整体分布情况越倾斜）。  **默认取值** 不涉及。 
        /// </summary>
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public SortKeyEnum SortKey { get; set; }
        /// <summary>
        /// **参数解释** 实时会话统计排序方式。 **约束限制**: 不涉及。 **取值范围** - ASC：根据sort_key值升序。 - DESC：根据sort_key值降序。  **默认取值** ASC 
        /// </summary>
        [JsonProperty("sort_order", NullValueHandling = NullValueHandling.Ignore)]
        public SortOrderEnum SortOrder { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportTableVolumeRequestBody {\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  schemaNames: ").Append(SchemaNames).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportTableVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportTableVolumeRequestBody input)
        {
            if (input == null) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.SchemaNames != input.SchemaNames || (this.SchemaNames != null && input.SchemaNames != null && !this.SchemaNames.SequenceEqual(input.SchemaNames))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.SortKey != input.SortKey) return false;
            if (this.SortOrder != input.SortOrder) return false;

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
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.SchemaNames != null) hashCode = hashCode * 59 + this.SchemaNames.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                return hashCode;
            }
        }
    }
}
