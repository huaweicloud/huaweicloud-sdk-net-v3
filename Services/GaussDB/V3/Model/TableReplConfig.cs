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
    /// 表同步配置。
    /// </summary>
    public class TableReplConfig 
    {
        /// <summary>
        /// 表同步类型。include_tables:白名单,exclude_tables:黑名单。
        /// </summary>
        /// <value>表同步类型。include_tables:白名单,exclude_tables:黑名单。</value>
        [JsonConverter(typeof(EnumClassConverter<ReplTypeEnum>))]
        public class ReplTypeEnum
        {
            /// <summary>
            /// Enum INCLUDE_TABLES for value: include_tables
            /// </summary>
            public static readonly ReplTypeEnum INCLUDE_TABLES = new ReplTypeEnum("include_tables");

            /// <summary>
            /// Enum EXCLUDE_TABLES for value: exclude_tables
            /// </summary>
            public static readonly ReplTypeEnum EXCLUDE_TABLES = new ReplTypeEnum("exclude_tables");

            private static readonly Dictionary<string, ReplTypeEnum> StaticFields =
            new Dictionary<string, ReplTypeEnum>()
            {
                { "include_tables", INCLUDE_TABLES },
                { "exclude_tables", EXCLUDE_TABLES },
            };

            private string _value;

            public ReplTypeEnum()
            {

            }

            public ReplTypeEnum(string value)
            {
                _value = value;
            }

            public static ReplTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ReplTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplTypeEnum a, ReplTypeEnum b)
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

            public static bool operator !=(ReplTypeEnum a, ReplTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表同步范围。all:全量同步，part:部分同步。
        /// </summary>
        /// <value>表同步范围。all:全量同步，part:部分同步。</value>
        [JsonConverter(typeof(EnumClassConverter<ReplScopeEnum>))]
        public class ReplScopeEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly ReplScopeEnum ALL = new ReplScopeEnum("all");

            /// <summary>
            /// Enum PART for value: part
            /// </summary>
            public static readonly ReplScopeEnum PART = new ReplScopeEnum("part");

            private static readonly Dictionary<string, ReplScopeEnum> StaticFields =
            new Dictionary<string, ReplScopeEnum>()
            {
                { "all", ALL },
                { "part", PART },
            };

            private string _value;

            public ReplScopeEnum()
            {

            }

            public ReplScopeEnum(string value)
            {
                _value = value;
            }

            public static ReplScopeEnum FromValue(string value)
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

                if (this.Equals(obj as ReplScopeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplScopeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplScopeEnum a, ReplScopeEnum b)
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

            public static bool operator !=(ReplScopeEnum a, ReplScopeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 表同步类型。include_tables:白名单,exclude_tables:黑名单。
        /// </summary>
        [JsonProperty("repl_type", NullValueHandling = NullValueHandling.Ignore)]
        public ReplTypeEnum ReplType { get; set; }
        /// <summary>
        /// 表同步范围。all:全量同步，part:部分同步。
        /// </summary>
        [JsonProperty("repl_scope", NullValueHandling = NullValueHandling.Ignore)]
        public ReplScopeEnum ReplScope { get; set; }
        /// <summary>
        /// 白名单或黑名单的表范围。
        /// </summary>
        [JsonProperty("tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableReplConfig {\n");
            sb.Append("  replType: ").Append(ReplType).Append("\n");
            sb.Append("  replScope: ").Append(ReplScope).Append("\n");
            sb.Append("  tables: ").Append(Tables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TableReplConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TableReplConfig input)
        {
            if (input == null) return false;
            if (this.ReplType != input.ReplType) return false;
            if (this.ReplScope != input.ReplScope) return false;
            if (this.Tables != input.Tables || (this.Tables != null && input.Tables != null && !this.Tables.SequenceEqual(input.Tables))) return false;

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
                hashCode = hashCode * 59 + this.ReplType.GetHashCode();
                hashCode = hashCode * 59 + this.ReplScope.GetHashCode();
                if (this.Tables != null) hashCode = hashCode * 59 + this.Tables.GetHashCode();
                return hashCode;
            }
        }
    }
}
