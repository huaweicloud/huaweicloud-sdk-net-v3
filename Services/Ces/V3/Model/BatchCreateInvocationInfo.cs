using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchCreateInvocationInfo 
    {
        /// <summary>
        /// **参数解释**: 任务结果, successful成功，error失败 **取值范围**: - successful: 成功 - error: 失败 
        /// </summary>
        /// <value>**参数解释**: 任务结果, successful成功，error失败 **取值范围**: - successful: 成功 - error: 失败 </value>
        [JsonConverter(typeof(EnumClassConverter<RetStatusEnum>))]
        public class RetStatusEnum
        {
            /// <summary>
            /// Enum SUCCESSFUL for value: successful
            /// </summary>
            public static readonly RetStatusEnum SUCCESSFUL = new RetStatusEnum("successful");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly RetStatusEnum ERROR = new RetStatusEnum("error");

            private static readonly Dictionary<string, RetStatusEnum> StaticFields =
            new Dictionary<string, RetStatusEnum>()
            {
                { "successful", SUCCESSFUL },
                { "error", ERROR },
            };

            private string _value;

            public RetStatusEnum()
            {

            }

            public RetStatusEnum(string value)
            {
                _value = value;
            }

            public static RetStatusEnum FromValue(string value)
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

                if (this.Equals(obj as RetStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RetStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RetStatusEnum a, RetStatusEnum b)
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

            public static bool operator !=(RetStatusEnum a, RetStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 机器id **取值范围**: 1到64个字符的字符串，且只包含字母、数字和连字符 
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**: 任务id **取值范围**: 1到64个字符的字符串，且只包含字母、数字和连字符 
        /// </summary>
        [JsonProperty("invocation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvocationId { get; set; }

        /// <summary>
        /// **参数解释**: 任务结果, successful成功，error失败 **取值范围**: - successful: 成功 - error: 失败 
        /// </summary>
        [JsonProperty("ret_status", NullValueHandling = NullValueHandling.Ignore)]
        public RetStatusEnum RetStatus { get; set; }
        /// <summary>
        /// **参数解释**: 错误码 **取值范围**: 以\&quot;invocationmgr.\&quot;开头且后跟4位数字的完整字符串 
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// **参数解释**: 错误信息 **取值范围**: 数组长度范围为[1,128] 
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateInvocationInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  invocationId: ").Append(InvocationId).Append("\n");
            sb.Append("  retStatus: ").Append(RetStatus).Append("\n");
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
            return this.Equals(input as BatchCreateInvocationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateInvocationInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InvocationId != input.InvocationId || (this.InvocationId != null && !this.InvocationId.Equals(input.InvocationId))) return false;
            if (this.RetStatus != input.RetStatus) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InvocationId != null) hashCode = hashCode * 59 + this.InvocationId.GetHashCode();
                hashCode = hashCode * 59 + this.RetStatus.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
