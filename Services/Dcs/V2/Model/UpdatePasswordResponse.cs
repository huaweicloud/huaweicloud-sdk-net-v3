using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdatePasswordResponse : SdkResponse
    {
        /// <summary>
        /// 密码修改结果： - 成功：success； - 密码验证失败：passwordFailed； - 已锁定：locked； - 失败：failed。 
        /// </summary>
        /// <value>密码修改结果： - 成功：success； - 密码验证失败：passwordFailed； - 已锁定：locked； - 失败：failed。 </value>
        [JsonConverter(typeof(EnumClassConverter<ResultEnum>))]
        public class ResultEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly ResultEnum SUCCESS = new ResultEnum("success");

            /// <summary>
            /// Enum PASSWORDFAILED for value: passwordFailed
            /// </summary>
            public static readonly ResultEnum PASSWORDFAILED = new ResultEnum("passwordFailed");

            /// <summary>
            /// Enum LOCKED for value: locked
            /// </summary>
            public static readonly ResultEnum LOCKED = new ResultEnum("locked");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly ResultEnum FAILED = new ResultEnum("failed");

            public static readonly Dictionary<string, ResultEnum> StaticFields =
            new Dictionary<string, ResultEnum>()
            {
                {"success", SUCCESS},
                {"passwordFailed", PASSWORDFAILED},
                {"locked", LOCKED},
                {"failed", FAILED},
            };

            private string Value;

            public ResultEnum(string Value)
            {
                this.Value = Value;
            }

            public static ResultEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ResultEnum a, ResultEnum b)
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

            public static bool operator !=(ResultEnum a, ResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 锁定时间。验证失败时和锁定时该参数返回不为null
        /// </summary>
        [JsonProperty("lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTime { get; set; }

        /// <summary>
        /// 密码修改结果： - 成功：success； - 密码验证失败：passwordFailed； - 已锁定：locked； - 失败：failed。 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// 锁定剩余时间。锁定时该参数返回不为null
        /// </summary>
        [JsonProperty("lock_time_left", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTimeLeft { get; set; }

        /// <summary>
        /// 密码验证剩余次数。验证失败时该参数返回不为null
        /// </summary>
        [JsonProperty("retry_times_left", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryTimesLeft { get; set; }

        /// <summary>
        /// 修改结果。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordResponse {\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  lockTimeLeft: ").Append(LockTimeLeft).Append("\n");
            sb.Append("  retryTimesLeft: ").Append(RetryTimesLeft).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePasswordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePasswordResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LockTime == input.LockTime ||
                    (this.LockTime != null &&
                    this.LockTime.Equals(input.LockTime))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.LockTimeLeft == input.LockTimeLeft ||
                    (this.LockTimeLeft != null &&
                    this.LockTimeLeft.Equals(input.LockTimeLeft))
                ) && 
                (
                    this.RetryTimesLeft == input.RetryTimesLeft ||
                    (this.RetryTimesLeft != null &&
                    this.RetryTimesLeft.Equals(input.RetryTimesLeft))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.LockTime != null)
                    hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.LockTimeLeft != null)
                    hashCode = hashCode * 59 + this.LockTimeLeft.GetHashCode();
                if (this.RetryTimesLeft != null)
                    hashCode = hashCode * 59 + this.RetryTimesLeft.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
