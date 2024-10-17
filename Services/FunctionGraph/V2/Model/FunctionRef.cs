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
    /// 函数调用信息
    /// </summary>
    public class FunctionRef 
    {
        /// <summary>
        /// 函数调用模式，目前只支持同步调用
        /// </summary>
        /// <value>函数调用模式，目前只支持同步调用</value>
        [JsonConverter(typeof(EnumClassConverter<InvokeModeEnum>))]
        public class InvokeModeEnum
        {
            /// <summary>
            /// Enum SYNCHRONIZE for value: synchronize
            /// </summary>
            public static readonly InvokeModeEnum SYNCHRONIZE = new InvokeModeEnum("synchronize");

            private static readonly Dictionary<string, InvokeModeEnum> StaticFields =
            new Dictionary<string, InvokeModeEnum>()
            {
                { "synchronize", SYNCHRONIZE },
            };

            private string _value;

            public InvokeModeEnum()
            {

            }

            public InvokeModeEnum(string value)
            {
                _value = value;
            }

            public static InvokeModeEnum FromValue(string value)
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

                if (this.Equals(obj as InvokeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InvokeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InvokeModeEnum a, InvokeModeEnum b)
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

            public static bool operator !=(InvokeModeEnum a, InvokeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 函数引用名称，需要和外层functions中的name对应
        /// </summary>
        [JsonProperty("ref_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RefName { get; set; }

        /// <summary>
        /// 函数调用模式，目前只支持同步调用
        /// </summary>
        [JsonProperty("invoke_mode", NullValueHandling = NullValueHandling.Ignore)]
        public InvokeModeEnum InvokeMode { get; set; }
        /// <summary>
        /// 函数执行时的入参，支持引用constants中的常量 定义方式：参数路径 | 常量值/常量路径 参数路径指输入参数的JsonPath路径，如$.a.b[0].c 常量值可以为数字类型，字符串类型(需要用单引号括起来)，布尔类型 常量路径为常量的JsonPath路径，但是根节点需要用$CONST表示，示例：$CONST.a.b
        /// </summary>
        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public Object Arguments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FunctionRef {\n");
            sb.Append("  refName: ").Append(RefName).Append("\n");
            sb.Append("  invokeMode: ").Append(InvokeMode).Append("\n");
            sb.Append("  arguments: ").Append(Arguments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FunctionRef);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FunctionRef input)
        {
            if (input == null) return false;
            if (this.RefName != input.RefName || (this.RefName != null && !this.RefName.Equals(input.RefName))) return false;
            if (this.InvokeMode != input.InvokeMode) return false;
            if (this.Arguments != input.Arguments || (this.Arguments != null && !this.Arguments.Equals(input.Arguments))) return false;

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
                if (this.RefName != null) hashCode = hashCode * 59 + this.RefName.GetHashCode();
                hashCode = hashCode * 59 + this.InvokeMode.GetHashCode();
                if (this.Arguments != null) hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                return hashCode;
            }
        }
    }
}
