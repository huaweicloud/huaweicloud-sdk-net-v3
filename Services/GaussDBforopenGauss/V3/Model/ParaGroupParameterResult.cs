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
    public class ParaGroupParameterResult 
    {
        /// <summary>
        /// 参数类型，取值为“string”、“integer”、“boolean”、“list”、\&quot;all\&quot;或“float”之一。
        /// </summary>
        /// <value>参数类型，取值为“string”、“integer”、“boolean”、“list”、\&quot;all\&quot;或“float”之一。</value>
        [JsonConverter(typeof(EnumClassConverter<DataTypeEnum>))]
        public class DataTypeEnum
        {
            /// <summary>
            /// Enum STRING for value: string
            /// </summary>
            public static readonly DataTypeEnum STRING = new DataTypeEnum("string");

            /// <summary>
            /// Enum INTEGER for value: integer
            /// </summary>
            public static readonly DataTypeEnum INTEGER = new DataTypeEnum("integer");

            /// <summary>
            /// Enum BOOLEAN for value: boolean
            /// </summary>
            public static readonly DataTypeEnum BOOLEAN = new DataTypeEnum("boolean");

            /// <summary>
            /// Enum LIST for value: list
            /// </summary>
            public static readonly DataTypeEnum LIST = new DataTypeEnum("list");

            /// <summary>
            /// Enum FLOAT for value: float
            /// </summary>
            public static readonly DataTypeEnum FLOAT = new DataTypeEnum("float");

            private static readonly Dictionary<string, DataTypeEnum> StaticFields =
            new Dictionary<string, DataTypeEnum>()
            {
                { "string", STRING },
                { "integer", INTEGER },
                { "boolean", BOOLEAN },
                { "list", LIST },
                { "float", FLOAT },
            };

            private string _value;

            public DataTypeEnum()
            {

            }

            public DataTypeEnum(string value)
            {
                _value = value;
            }

            public static DataTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DataTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DataTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DataTypeEnum a, DataTypeEnum b)
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

            public static bool operator !=(DataTypeEnum a, DataTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 特定参数名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 特定参数值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 参数是否需要重启。 - 取值为\&quot;true\&quot;，需要重启。 - 取值为\&quot;false\&quot;，不需要重启。
        /// </summary>
        [JsonProperty("need_restart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedRestart { get; set; }

        /// <summary>
        /// 该参数是否只读(true：只读；false：可编辑)。
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; }

        /// <summary>
        /// 参数取值范围。
        /// </summary>
        [JsonProperty("value_range", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueRange { get; set; }

        /// <summary>
        /// 参数类型，取值为“string”、“integer”、“boolean”、“list”、\&quot;all\&quot;或“float”之一。
        /// </summary>
        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public DataTypeEnum DataType { get; set; }
        /// <summary>
        /// 参数描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParaGroupParameterResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  needRestart: ").Append(NeedRestart).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("  valueRange: ").Append(ValueRange).Append("\n");
            sb.Append("  dataType: ").Append(DataType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParaGroupParameterResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParaGroupParameterResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.NeedRestart == input.NeedRestart ||
                    (this.NeedRestart != null &&
                    this.NeedRestart.Equals(input.NeedRestart))
                ) && 
                (
                    this.Readonly == input.Readonly ||
                    (this.Readonly != null &&
                    this.Readonly.Equals(input.Readonly))
                ) && 
                (
                    this.ValueRange == input.ValueRange ||
                    (this.ValueRange != null &&
                    this.ValueRange.Equals(input.ValueRange))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.NeedRestart != null)
                    hashCode = hashCode * 59 + this.NeedRestart.GetHashCode();
                if (this.Readonly != null)
                    hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                if (this.ValueRange != null)
                    hashCode = hashCode * 59 + this.ValueRange.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
