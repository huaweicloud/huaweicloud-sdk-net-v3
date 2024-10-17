using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMetricsDataRequest 
    {
        /// <summary>
        /// 用于对查询到的监控数据进行断点插值，默认值为-1。 -1：断点处使用-1进行表示。 0 ：断点处使用0进行表示。 null：断点处使用null进行表示。 average：断点处使用前后邻近的有效数据的平均值进行表示，如果不存在有效数据则使用null进行表示。
        /// </summary>
        /// <value>用于对查询到的监控数据进行断点插值，默认值为-1。 -1：断点处使用-1进行表示。 0 ：断点处使用0进行表示。 null：断点处使用null进行表示。 average：断点处使用前后邻近的有效数据的平均值进行表示，如果不存在有效数据则使用null进行表示。</value>
        [JsonConverter(typeof(EnumClassConverter<FillValueEnum>))]
        public class FillValueEnum
        {
            /// <summary>
            /// Enum _1 for value: -1
            /// </summary>
            public static readonly FillValueEnum _1 = new FillValueEnum("-1");

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly FillValueEnum _0 = new FillValueEnum("0");

            /// <summary>
            /// Enum NULL for value: null
            /// </summary>
            public static readonly FillValueEnum NULL = new FillValueEnum("null");

            /// <summary>
            /// Enum AVERAGE for value: average
            /// </summary>
            public static readonly FillValueEnum AVERAGE = new FillValueEnum("average");

            private static readonly Dictionary<string, FillValueEnum> StaticFields =
            new Dictionary<string, FillValueEnum>()
            {
                { "-1", _1 },
                { "0", _0 },
                { "null", NULL },
                { "average", AVERAGE },
            };

            private string _value;

            public FillValueEnum()
            {

            }

            public FillValueEnum(string value)
            {
                _value = value;
            }

            public static FillValueEnum FromValue(string value)
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

                if (this.Equals(obj as FillValueEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FillValueEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FillValueEnum a, FillValueEnum b)
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

            public static bool operator !=(FillValueEnum a, FillValueEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用于对查询到的监控数据进行断点插值，默认值为-1。 -1：断点处使用-1进行表示。 0 ：断点处使用0进行表示。 null：断点处使用null进行表示。 average：断点处使用前后邻近的有效数据的平均值进行表示，如果不存在有效数据则使用null进行表示。
        /// </summary>
        [SDKProperty("fillValue", IsQuery = true)]
        [JsonProperty("fillValue", NullValueHandling = NullValueHandling.Ignore)]
        public FillValueEnum FillValue { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public QueryMetricDataParam Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetricsDataRequest {\n");
            sb.Append("  fillValue: ").Append(FillValue).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetricsDataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetricsDataRequest input)
        {
            if (input == null) return false;
            if (this.FillValue != input.FillValue) return false;
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
                hashCode = hashCode * 59 + this.FillValue.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
