using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteInstanceRespResults 
    {
        /// <summary>
        /// **参数解释**： 操作结果。 **约束限制**： 不涉及。 **取值范围**： - success - failed **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 操作结果。 **约束限制**： 不涉及。 **取值范围**： - success - failed **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ResultEnum>))]
        public class ResultEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly ResultEnum SUCCESS = new ResultEnum("success");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly ResultEnum FAILED = new ResultEnum("failed");

            private static readonly Dictionary<string, ResultEnum> StaticFields =
            new Dictionary<string, ResultEnum>()
            {
                { "success", SUCCESS },
                { "failed", FAILED },
            };

            private string _value;

            public ResultEnum()
            {

            }

            public ResultEnum(string value)
            {
                _value = value;
            }

            public static ResultEnum FromValue(string value)
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

                if (this.Equals(obj as ResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResultEnum a, ResultEnum b)
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

            public static bool operator !=(ResultEnum a, ResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 操作结果。 **约束限制**： 不涉及。 **取值范围**： - success - failed **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public string Instance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteInstanceRespResults {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  instance: ").Append(Instance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteInstanceRespResults);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteInstanceRespResults input)
        {
            if (input == null) return false;
            if (this.Result != input.Result) return false;
            if (this.Instance != input.Instance || (this.Instance != null && !this.Instance.Equals(input.Instance))) return false;

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
                hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Instance != null) hashCode = hashCode * 59 + this.Instance.GetHashCode();
                return hashCode;
            }
        }
    }
}
