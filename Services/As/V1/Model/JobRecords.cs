using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 策略执行动作包含的具体任务
    /// </summary>
    public class JobRecords 
    {
        /// <summary>
        /// 记录类型。API：接口调用类型。MEG：消息类型。
        /// </summary>
        /// <value>记录类型。API：接口调用类型。MEG：消息类型。</value>
        [JsonConverter(typeof(EnumClassConverter<RecordTypeEnum>))]
        public class RecordTypeEnum
        {
            /// <summary>
            /// Enum API for value: API
            /// </summary>
            public static readonly RecordTypeEnum API = new RecordTypeEnum("API");

            /// <summary>
            /// Enum MEG for value: MEG
            /// </summary>
            public static readonly RecordTypeEnum MEG = new RecordTypeEnum("MEG");

            private static readonly Dictionary<string, RecordTypeEnum> StaticFields =
            new Dictionary<string, RecordTypeEnum>()
            {
                { "API", API },
                { "MEG", MEG },
            };

            private string Value;

            public RecordTypeEnum(string value)
            {
                Value = value;
            }

            public static RecordTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as RecordTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecordTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(RecordTypeEnum a, RecordTypeEnum b)
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

            public static bool operator !=(RecordTypeEnum a, RecordTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// job执行状态：SUCCESS：成功。FAIL：失败。
        /// </summary>
        /// <value>job执行状态：SUCCESS：成功。FAIL：失败。</value>
        [JsonConverter(typeof(EnumClassConverter<JobStatusEnum>))]
        public class JobStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly JobStatusEnum SUCCESS = new JobStatusEnum("SUCCESS");

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly JobStatusEnum FAIL = new JobStatusEnum("FAIL");

            private static readonly Dictionary<string, JobStatusEnum> StaticFields =
            new Dictionary<string, JobStatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAIL", FAIL },
            };

            private string Value;

            public JobStatusEnum(string value)
            {
                Value = value;
            }

            public static JobStatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as JobStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(JobStatusEnum a, JobStatusEnum b)
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

            public static bool operator !=(JobStatusEnum a, JobStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 记录类型。API：接口调用类型。MEG：消息类型。
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public RecordTypeEnum RecordType { get; set; }
        /// <summary>
        /// 记录时间。
        /// </summary>
        [JsonProperty("record_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordTime { get; set; }

        /// <summary>
        /// 请求体，仅当record_type为API时有效
        /// </summary>
        [JsonProperty("request", NullValueHandling = NullValueHandling.Ignore)]
        public string Request { get; set; }

        /// <summary>
        /// 返回体，仅当record_type为API时有效
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public string Response { get; set; }

        /// <summary>
        /// 返回码，仅当record_type为API时有效
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// 消息，仅当record_type为MEG时有效
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// job执行状态：SUCCESS：成功。FAIL：失败。
        /// </summary>
        [JsonProperty("job_status", NullValueHandling = NullValueHandling.Ignore)]
        public JobStatusEnum JobStatus { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobRecords {\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  recordTime: ").Append(RecordTime).Append("\n");
            sb.Append("  request: ").Append(Request).Append("\n");
            sb.Append("  response: ").Append(Response).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  jobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobRecords input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.RecordType == input.RecordType ||
                    (this.RecordType != null &&
                    this.RecordType.Equals(input.RecordType))
                ) && 
                (
                    this.RecordTime == input.RecordTime ||
                    (this.RecordTime != null &&
                    this.RecordTime.Equals(input.RecordTime))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
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
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.RecordType != null)
                    hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.RecordTime != null)
                    hashCode = hashCode * 59 + this.RecordTime.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
