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
    /// APIG触发器函数工作流后端详情（APIG触发器参数）。APIG触发器此参数必填。
    /// </summary>
    public class ApigTriggerFuncInfo 
    {
        /// <summary>
        /// 调用函数执行方式。 - sync：同步执行 - async：异步执行
        /// </summary>
        /// <value>调用函数执行方式。 - sync：同步执行 - async：异步执行</value>
        [JsonConverter(typeof(EnumClassConverter<InvocationTypeEnum>))]
        public class InvocationTypeEnum
        {
            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly InvocationTypeEnum SYNC = new InvocationTypeEnum("sync");

            /// <summary>
            /// Enum ASYNC for value: async
            /// </summary>
            public static readonly InvocationTypeEnum ASYNC = new InvocationTypeEnum("async");

            private static readonly Dictionary<string, InvocationTypeEnum> StaticFields =
            new Dictionary<string, InvocationTypeEnum>()
            {
                { "sync", SYNC },
                { "async", ASYNC },
            };

            private string _value;

            public InvocationTypeEnum()
            {

            }

            public InvocationTypeEnum(string value)
            {
                _value = value;
            }

            public static InvocationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InvocationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InvocationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InvocationTypeEnum a, InvocationTypeEnum b)
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

            public static bool operator !=(InvocationTypeEnum a, InvocationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 函数的URN，详细解释见FunctionGraph函数模型的描述。
        /// </summary>
        [JsonProperty("function_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrn { get; set; }

        /// <summary>
        /// 调用函数执行方式。 - sync：同步执行 - async：异步执行
        /// </summary>
        [JsonProperty("invocation_type", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTypeEnum InvocationType { get; set; }
        /// <summary>
        /// API网关请求函数服务的超时时间（毫秒）。APIG触发器此参数必填。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 函数版本信息。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApigTriggerFuncInfo {\n");
            sb.Append("  functionUrn: ").Append(FunctionUrn).Append("\n");
            sb.Append("  invocationType: ").Append(InvocationType).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApigTriggerFuncInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApigTriggerFuncInfo input)
        {
            if (input == null) return false;
            if (this.FunctionUrn != input.FunctionUrn || (this.FunctionUrn != null && !this.FunctionUrn.Equals(input.FunctionUrn))) return false;
            if (this.InvocationType != input.InvocationType) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.FunctionUrn != null) hashCode = hashCode * 59 + this.FunctionUrn.GetHashCode();
                hashCode = hashCode * 59 + this.InvocationType.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
