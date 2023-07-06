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
    /// Response Object
    /// </summary>
    public class UpdateParamsResponse : SdkResponse
    {
        /// <summary>
        /// 是否需要重启
        /// </summary>
        /// <value>是否需要重启</value>
        [JsonConverter(typeof(EnumClassConverter<ShouldRestartEnum>))]
        public class ShouldRestartEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly ShouldRestartEnum TRUE = new ShouldRestartEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly ShouldRestartEnum FALSE = new ShouldRestartEnum("false");

            private static readonly Dictionary<string, ShouldRestartEnum> StaticFields =
            new Dictionary<string, ShouldRestartEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public ShouldRestartEnum()
            {

            }

            public ShouldRestartEnum(string value)
            {
                _value = value;
            }

            public static ShouldRestartEnum FromValue(string value)
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

                if (this.Equals(obj as ShouldRestartEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ShouldRestartEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ShouldRestartEnum a, ShouldRestartEnum b)
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

            public static bool operator !=(ShouldRestartEnum a, ShouldRestartEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 修改参数是否成功
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// 是否需要重启
        /// </summary>
        [JsonProperty("should_restart", NullValueHandling = NullValueHandling.Ignore)]
        public ShouldRestartEnum ShouldRestart { get; set; }
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateParamsResponse {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  shouldRestart: ").Append(ShouldRestart).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateParamsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateParamsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.ShouldRestart == input.ShouldRestart ||
                    (this.ShouldRestart != null &&
                    this.ShouldRestart.Equals(input.ShouldRestart))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.ShouldRestart != null)
                    hashCode = hashCode * 59 + this.ShouldRestart.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
