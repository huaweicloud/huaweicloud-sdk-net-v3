using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class BatchListStructDetailRequest 
    {
        /// <summary>
        /// 数据库支持迁移对象类型
        /// </summary>
        /// <value>数据库支持迁移对象类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum DATABASE for value: database
            /// </summary>
            public static readonly TypeEnum DATABASE = new TypeEnum("database");

            /// <summary>
            /// Enum SCHEMA for value: schema
            /// </summary>
            public static readonly TypeEnum SCHEMA = new TypeEnum("schema");

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

            /// <summary>
            /// Enum TRIGGER for value: trigger
            /// </summary>
            public static readonly TypeEnum TRIGGER = new TypeEnum("trigger");

            /// <summary>
            /// Enum INDEX for value: index
            /// </summary>
            public static readonly TypeEnum INDEX = new TypeEnum("index");

            /// <summary>
            /// Enum TABLE_INDEXS for value: table_indexs
            /// </summary>
            public static readonly TypeEnum TABLE_INDEXS = new TypeEnum("table_indexs");

            /// <summary>
            /// Enum TABLE_STRUCTURE for value: table_structure
            /// </summary>
            public static readonly TypeEnum TABLE_STRUCTURE = new TypeEnum("table_structure");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "database", DATABASE },
                { "schema", SCHEMA },
                { "table", TABLE },
                { "view", VIEW },
                { "procedure", PROCEDURE },
                { "trigger", TRIGGER },
                { "index", INDEX },
                { "table_indexs", TABLE_INDEXS },
                { "table_structure", TABLE_STRUCTURE },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 请求语言类型
        /// </summary>
        /// <value>请求语言类型</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "en-us", EN_US },
                { "zh-cn", ZH_CN },
            };

            private string _value;

            public XLanguageEnum()
            {

            }

            public XLanguageEnum(string value)
            {
                _value = value;
            }

            public static XLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as XLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XLanguageEnum a, XLanguageEnum b)
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库支持迁移对象类型
        /// </summary>
        [SDKProperty("type", IsPath = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 请求语言类型
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public BatchQueryJobReqPage Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchListStructDetailRequest {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchListStructDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchListStructDetailRequest input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.XLanguage != input.XLanguage) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
