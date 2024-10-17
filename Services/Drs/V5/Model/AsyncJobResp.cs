using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 批量异步创建任务响应体。
    /// </summary>
    public class AsyncJobResp 
    {
        /// <summary>
        /// 批量异步创建的任务状态。取值： - ASYNC_JOB_VALIDATING：批量异步任务参数校验中。 - ASYNC_JOB_VALIDATE_FAILED：批量异步任务参数校验失败。 - AUTO_PARAM_VALIDATE_SUCCESS：批量异步任务参数校验成功。 - COMMIT_SUCCESS：批量异步任务提交成功。
        /// </summary>
        /// <value>批量异步创建的任务状态。取值： - ASYNC_JOB_VALIDATING：批量异步任务参数校验中。 - ASYNC_JOB_VALIDATE_FAILED：批量异步任务参数校验失败。 - AUTO_PARAM_VALIDATE_SUCCESS：批量异步任务参数校验成功。 - COMMIT_SUCCESS：批量异步任务提交成功。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ASYNC_JOB_VALIDATING for value: ASYNC_JOB_VALIDATING
            /// </summary>
            public static readonly StatusEnum ASYNC_JOB_VALIDATING = new StatusEnum("ASYNC_JOB_VALIDATING");

            /// <summary>
            /// Enum ASYNC_JOB_VALIDATE_FAILED for value: ASYNC_JOB_VALIDATE_FAILED
            /// </summary>
            public static readonly StatusEnum ASYNC_JOB_VALIDATE_FAILED = new StatusEnum("ASYNC_JOB_VALIDATE_FAILED");

            /// <summary>
            /// Enum AUTO_PARAM_VALIDATE_SUCCESS for value: AUTO_PARAM_VALIDATE_SUCCESS
            /// </summary>
            public static readonly StatusEnum AUTO_PARAM_VALIDATE_SUCCESS = new StatusEnum("AUTO_PARAM_VALIDATE_SUCCESS");

            /// <summary>
            /// Enum COMMIT_SUCCESS for value: COMMIT_SUCCESS
            /// </summary>
            public static readonly StatusEnum COMMIT_SUCCESS = new StatusEnum("COMMIT_SUCCESS");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ASYNC_JOB_VALIDATING", ASYNC_JOB_VALIDATING },
                { "ASYNC_JOB_VALIDATE_FAILED", ASYNC_JOB_VALIDATE_FAILED },
                { "AUTO_PARAM_VALIDATE_SUCCESS", AUTO_PARAM_VALIDATE_SUCCESS },
                { "COMMIT_SUCCESS", COMMIT_SUCCESS },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 批量异步创建的任务ID。
        /// </summary>
        [JsonProperty("async_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AsyncJobId { get; set; }

        /// <summary>
        /// 批量异步创建的任务状态。取值： - ASYNC_JOB_VALIDATING：批量异步任务参数校验中。 - ASYNC_JOB_VALIDATE_FAILED：批量异步任务参数校验失败。 - AUTO_PARAM_VALIDATE_SUCCESS：批量异步任务参数校验成功。 - COMMIT_SUCCESS：批量异步任务提交成功。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 批量异步创建的任务的租户名。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 批量异步创建的任务的用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 批量异步创建的任务的创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncJobResp {\n");
            sb.Append("  asyncJobId: ").Append(AsyncJobId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsyncJobResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsyncJobResp input)
        {
            if (input == null) return false;
            if (this.AsyncJobId != input.AsyncJobId || (this.AsyncJobId != null && !this.AsyncJobId.Equals(input.AsyncJobId))) return false;
            if (this.Status != input.Status) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.AsyncJobId != null) hashCode = hashCode * 59 + this.AsyncJobId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
