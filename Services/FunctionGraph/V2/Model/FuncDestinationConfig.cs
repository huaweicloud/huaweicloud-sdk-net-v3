using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 函数通知目标参数配置。
    /// </summary>
    public class FuncDestinationConfig 
    {
        /// <summary>
        /// 目标类型。  - OBS：通知到OBS服务。 - SMN：通知到SMN服务。 - DIS：通知到DIS服务。 - FunctionGraph： 通知到函数服务。
        /// </summary>
        /// <value>目标类型。  - OBS：通知到OBS服务。 - SMN：通知到SMN服务。 - DIS：通知到DIS服务。 - FunctionGraph： 通知到函数服务。</value>
        [JsonConverter(typeof(EnumClassConverter<DestinationEnum>))]
        public class DestinationEnum
        {
            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly DestinationEnum OBS = new DestinationEnum("OBS");

            /// <summary>
            /// Enum SMN for value: SMN
            /// </summary>
            public static readonly DestinationEnum SMN = new DestinationEnum("SMN");

            /// <summary>
            /// Enum DIS for value: DIS
            /// </summary>
            public static readonly DestinationEnum DIS = new DestinationEnum("DIS");

            /// <summary>
            /// Enum FUNCTIONGRAPH for value: FunctionGraph
            /// </summary>
            public static readonly DestinationEnum FUNCTIONGRAPH = new DestinationEnum("FunctionGraph");

            private static readonly Dictionary<string, DestinationEnum> StaticFields =
            new Dictionary<string, DestinationEnum>()
            {
                { "OBS", OBS },
                { "SMN", SMN },
                { "DIS", DIS },
                { "FunctionGraph", FUNCTIONGRAPH },
            };

            private string _value;

            public DestinationEnum()
            {

            }

            public DestinationEnum(string value)
            {
                _value = value;
            }

            public static DestinationEnum FromValue(string value)
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

                if (this.Equals(obj as DestinationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DestinationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DestinationEnum a, DestinationEnum b)
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

            public static bool operator !=(DestinationEnum a, DestinationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 目标类型。  - OBS：通知到OBS服务。 - SMN：通知到SMN服务。 - DIS：通知到DIS服务。 - FunctionGraph： 通知到函数服务。
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public DestinationEnum Destination { get; set; }
        /// <summary>
        /// 通知目标服务对应参数,json字符串。  - OBS：包含bucket桶，对象目录前缀prefix，对象默认expires过期时间[0~365]天，0默认不过期。 - SMN：包含smn 主题topic_urn。 - DIS：包含DIS 通道名stream_name。 - FunctionGraph：包含func_urn，函数urn
        /// </summary>
        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuncDestinationConfig {\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  param: ").Append(Param).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FuncDestinationConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FuncDestinationConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Param == input.Param ||
                    (this.Param != null &&
                    this.Param.Equals(input.Param))
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
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Param != null)
                    hashCode = hashCode * 59 + this.Param.GetHashCode();
                return hashCode;
            }
        }
    }
}
