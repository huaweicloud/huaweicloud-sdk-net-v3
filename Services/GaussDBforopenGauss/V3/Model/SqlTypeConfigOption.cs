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
    /// **参数解释**: SQL采集类型列表。默认取值[]，表示采集所有SQL语句。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
    /// </summary>
    public class SqlTypeConfigOption 
    {
        /// <summary>
        /// **参数解释**: SQL类型的归类名称。 **约束限制**: - 对常用SQL类型，简单归类为6个类别，每个类别对应一组固定的采集SQL语句类型列表，采用前缀进行匹配。 - 对于其他场景，可以使用自定义类别，允许按需自定义采集SQL的语句前缀。  **取值范围**: - all：不区分SQL类型，全部采集。 - ddl：只采集DDL语句类别，包含如下SQL语句类型： create, alter, drop, truncate, reindex, vacuum, analyze, declare, move, close。 - dml：只采集DML语句类型，包含如下SQL语句类型： insert, update, delete, merge, show, explain, prepare, lock, copy, execute, deallocate。 - dcl：只采集DCL语句类型，包含如下SQL语句类型： grant, revoke, reassign, set。 - tcl：只采集TCL语句类型，包含如下SQL语句类型： begin, commit, rollback, start, savepoint, checkpoint, release savepoint。 - dql：只采集DQL语句类型，包含如下SQL语句类型： select。 - custom：采集自定义语句类型。需在prefixes字段中，填写要采集的SQL语句前缀片段。  **默认取值**: 不涉及。
        /// </summary>
        /// <value>**参数解释**: SQL类型的归类名称。 **约束限制**: - 对常用SQL类型，简单归类为6个类别，每个类别对应一组固定的采集SQL语句类型列表，采用前缀进行匹配。 - 对于其他场景，可以使用自定义类别，允许按需自定义采集SQL的语句前缀。  **取值范围**: - all：不区分SQL类型，全部采集。 - ddl：只采集DDL语句类别，包含如下SQL语句类型： create, alter, drop, truncate, reindex, vacuum, analyze, declare, move, close。 - dml：只采集DML语句类型，包含如下SQL语句类型： insert, update, delete, merge, show, explain, prepare, lock, copy, execute, deallocate。 - dcl：只采集DCL语句类型，包含如下SQL语句类型： grant, revoke, reassign, set。 - tcl：只采集TCL语句类型，包含如下SQL语句类型： begin, commit, rollback, start, savepoint, checkpoint, release savepoint。 - dql：只采集DQL语句类型，包含如下SQL语句类型： select。 - custom：采集自定义语句类型。需在prefixes字段中，填写要采集的SQL语句前缀片段。  **默认取值**: 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly CategoryEnum ALL = new CategoryEnum("all");

            /// <summary>
            /// Enum DDL for value: ddl
            /// </summary>
            public static readonly CategoryEnum DDL = new CategoryEnum("ddl");

            /// <summary>
            /// Enum DML for value: dml
            /// </summary>
            public static readonly CategoryEnum DML = new CategoryEnum("dml");

            /// <summary>
            /// Enum DCL for value: dcl
            /// </summary>
            public static readonly CategoryEnum DCL = new CategoryEnum("dcl");

            /// <summary>
            /// Enum TCL for value: tcl
            /// </summary>
            public static readonly CategoryEnum TCL = new CategoryEnum("tcl");

            /// <summary>
            /// Enum DQL for value: dql
            /// </summary>
            public static readonly CategoryEnum DQL = new CategoryEnum("dql");

            /// <summary>
            /// Enum CUSTOM for value: custom
            /// </summary>
            public static readonly CategoryEnum CUSTOM = new CategoryEnum("custom");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "all", ALL },
                { "ddl", DDL },
                { "dml", DML },
                { "dcl", DCL },
                { "tcl", TCL },
                { "dql", DQL },
                { "custom", CUSTOM },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: SQL类型的归类名称。 **约束限制**: - 对常用SQL类型，简单归类为6个类别，每个类别对应一组固定的采集SQL语句类型列表，采用前缀进行匹配。 - 对于其他场景，可以使用自定义类别，允许按需自定义采集SQL的语句前缀。  **取值范围**: - all：不区分SQL类型，全部采集。 - ddl：只采集DDL语句类别，包含如下SQL语句类型： create, alter, drop, truncate, reindex, vacuum, analyze, declare, move, close。 - dml：只采集DML语句类型，包含如下SQL语句类型： insert, update, delete, merge, show, explain, prepare, lock, copy, execute, deallocate。 - dcl：只采集DCL语句类型，包含如下SQL语句类型： grant, revoke, reassign, set。 - tcl：只采集TCL语句类型，包含如下SQL语句类型： begin, commit, rollback, start, savepoint, checkpoint, release savepoint。 - dql：只采集DQL语句类型，包含如下SQL语句类型： select。 - custom：采集自定义语句类型。需在prefixes字段中，填写要采集的SQL语句前缀片段。  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**: 针对custom自定义类别，指定要采集的SQL语句类型的列表，默认取值为[]。采集过程中，采用前缀方式对SQL文本进行匹配。 **约束限制**: - category取值custom时，此参数必填，不可为空。 - category取值其他类别时，此参数忽略。
        /// </summary>
        [JsonProperty("prefixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Prefixes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlTypeConfigOption {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  prefixes: ").Append(Prefixes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlTypeConfigOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlTypeConfigOption input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.Prefixes != input.Prefixes || (this.Prefixes != null && input.Prefixes != null && !this.Prefixes.SequenceEqual(input.Prefixes))) return false;

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
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Prefixes != null) hashCode = hashCode * 59 + this.Prefixes.GetHashCode();
                return hashCode;
            }
        }
    }
}
