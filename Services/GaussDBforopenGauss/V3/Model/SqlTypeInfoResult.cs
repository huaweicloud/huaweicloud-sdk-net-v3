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
    /// **参数解释**: SQL采集类型列表。 **取值范围**: 不涉及。
    /// </summary>
    public class SqlTypeInfoResult 
    {
        /// <summary>
        /// **参数解释**: SQL类型的归类名称。 - 对常用SQL类型，简单归类为6个类别，每个类别对应一组固定的采集SQL语句类型列表，采用前缀进行匹配。 - 对于其他场景，可以使用自定义类别，允许按需自定义采集SQL的语句前缀。  **取值范围**: - all：不区分SQL类型，全部采集。 - ddl：只采集DDL语句类型。 - dml：只采集DML语句类型。 - dcl：只采集DCL语句类型。 - tcl：只采集TCL语句类型。 - dql：只采集DQL语句类型。 - custom：采集自定义语句类型。
        /// </summary>
        /// <value>**参数解释**: SQL类型的归类名称。 - 对常用SQL类型，简单归类为6个类别，每个类别对应一组固定的采集SQL语句类型列表，采用前缀进行匹配。 - 对于其他场景，可以使用自定义类别，允许按需自定义采集SQL的语句前缀。  **取值范围**: - all：不区分SQL类型，全部采集。 - ddl：只采集DDL语句类型。 - dml：只采集DML语句类型。 - dcl：只采集DCL语句类型。 - tcl：只采集TCL语句类型。 - dql：只采集DQL语句类型。 - custom：采集自定义语句类型。</value>
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
        /// **参数解释**: SQL类型的归类名称。 - 对常用SQL类型，简单归类为6个类别，每个类别对应一组固定的采集SQL语句类型列表，采用前缀进行匹配。 - 对于其他场景，可以使用自定义类别，允许按需自定义采集SQL的语句前缀。  **取值范围**: - all：不区分SQL类型，全部采集。 - ddl：只采集DDL语句类型。 - dml：只采集DML语句类型。 - dcl：只采集DCL语句类型。 - tcl：只采集TCL语句类型。 - dql：只采集DQL语句类型。 - custom：采集自定义语句类型。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**: 对应SQL类别中，采集的SQL语句类型列表，采用前缀方式进行匹配。 对应不同的SQL类别，取值有所不同，对应关系如下： - all：不区分SQL类型，全部采集。对应取值为： [\&quot;.*\&quot;]。 - ddl：只采集DDL语句类别，对于取值为： [\&quot;create\&quot;, \&quot;alter\&quot;, \&quot;drop\&quot;, \&quot;truncate\&quot;, \&quot;reindex\&quot;, \&quot;vacuum\&quot;, \&quot;analyze\&quot;, \&quot;declare\&quot;, \&quot;move\&quot;, \&quot;close\&quot;]。 - dml：只采集DML语句类型，对于取值为： [\&quot;insert\&quot;, \&quot;update\&quot;, \&quot;delete\&quot;, \&quot;merge\&quot;, \&quot;show\&quot;, \&quot;explain\&quot;, \&quot;prepare\&quot;, \&quot;lock\&quot;, \&quot;copy\&quot;, \&quot;execute\&quot;, \&quot;deallocate\&quot;]。 - dcl：只采集DCL语句类型，对于取值为： [\&quot;grant\&quot;, \&quot;revoke\&quot;, \&quot;reassign\&quot;, \&quot;set\&quot;]。 - tcl：只采集TCL语句类型，对于取值为： [\&quot;begin\&quot;, \&quot;commit\&quot;, \&quot;rollback\&quot;, \&quot;start\&quot;, \&quot;savepoint\&quot;, \&quot;checkpoint\&quot;, \&quot;release savepoint\&quot;]。 - dql：只采集DQL语句类型，对于取值为： [\&quot;select\&quot;]。 - custom：采集自定义语句类型。对应取值为： 开启全量SQL时，用户填写的自定义SQL语句类型列表。  **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("prefixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Prefixes { get; set; }

        /// <summary>
        /// **参数解释**: 对应SQL类别是否为预置类别。 **取值范围**: - true：对应category取值all、ddl 、dml 、dcl 、tcl 、dql 。 - false：对应category取值custom。
        /// </summary>
        [JsonProperty("is_preset", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPreset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlTypeInfoResult {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  prefixes: ").Append(Prefixes).Append("\n");
            sb.Append("  isPreset: ").Append(IsPreset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlTypeInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlTypeInfoResult input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.Prefixes != input.Prefixes || (this.Prefixes != null && input.Prefixes != null && !this.Prefixes.SequenceEqual(input.Prefixes))) return false;
            if (this.IsPreset != input.IsPreset || (this.IsPreset != null && !this.IsPreset.Equals(input.IsPreset))) return false;

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
                if (this.IsPreset != null) hashCode = hashCode * 59 + this.IsPreset.GetHashCode();
                return hashCode;
            }
        }
    }
}
