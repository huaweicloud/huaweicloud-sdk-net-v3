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
    /// 库配置校验检查结果。
    /// </summary>
    public class DbConfigCheckResult 
    {
        /// <summary>
        /// 校验结果。
        /// </summary>
        /// <value>校验结果。</value>
        [JsonConverter(typeof(EnumClassConverter<CheckResultEnum>))]
        public class CheckResultEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly CheckResultEnum SUCCESS = new CheckResultEnum("success");

            /// <summary>
            /// Enum FAIL for value: fail
            /// </summary>
            public static readonly CheckResultEnum FAIL = new CheckResultEnum("fail");

            private static readonly Dictionary<string, CheckResultEnum> StaticFields =
            new Dictionary<string, CheckResultEnum>()
            {
                { "success", SUCCESS },
                { "fail", FAIL },
            };

            private string _value;

            public CheckResultEnum()
            {

            }

            public CheckResultEnum(string value)
            {
                _value = value;
            }

            public static CheckResultEnum FromValue(string value)
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

                if (this.Equals(obj as CheckResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CheckResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CheckResultEnum a, CheckResultEnum b)
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

            public static bool operator !=(CheckResultEnum a, CheckResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数名。
        /// </summary>
        [JsonProperty("param_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamName { get; set; }

        /// <summary>
        /// 参数值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 校验结果。
        /// </summary>
        [JsonProperty("check_result", NullValueHandling = NullValueHandling.Ignore)]
        public CheckResultEnum CheckResult { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbConfigCheckResult {\n");
            sb.Append("  paramName: ").Append(ParamName).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  checkResult: ").Append(CheckResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbConfigCheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbConfigCheckResult input)
        {
            if (input == null) return false;
            if (this.ParamName != input.ParamName || (this.ParamName != null && !this.ParamName.Equals(input.ParamName))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.CheckResult != input.CheckResult) return false;

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
                if (this.ParamName != null) hashCode = hashCode * 59 + this.ParamName.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.CheckResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
