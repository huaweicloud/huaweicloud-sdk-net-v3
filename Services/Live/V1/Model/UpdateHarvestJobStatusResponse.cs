using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateHarvestJobStatusResponse : SdkResponse
    {
        /// <summary>
        /// 任务状态，取值为 [ UNSTART、IN_PROGRESS、SUCCEEDED、FAILED ]
        /// </summary>
        /// <value>任务状态，取值为 [ UNSTART、IN_PROGRESS、SUCCEEDED、FAILED ]</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum UNSTART for value: UNSTART
            /// </summary>
            public static readonly StatusEnum UNSTART = new StatusEnum("UNSTART");

            /// <summary>
            /// Enum IN_PROGRESS for value: IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum IN_PROGRESS = new StatusEnum("IN_PROGRESS");

            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly StatusEnum SUCCEEDED = new StatusEnum("SUCCEEDED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "UNSTART", UNSTART },
                { "IN_PROGRESS", IN_PROGRESS },
                { "SUCCEEDED", SUCCEEDED },
                { "FAILED", FAILED },
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
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 频道推流域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 组名或应用名
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 频道ID。频道唯一标识，为必填项。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 开始时间。Unix时间错，单位为秒
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTime { get; set; }

        /// <summary>
        /// 结束时间。Unix时间错，单位为秒
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndTime { get; set; }

        /// <summary>
        /// 任务创建时间。Unix时间错，单位为秒
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("task_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务状态，取值为 [ UNSTART、IN_PROGRESS、SUCCEEDED、FAILED ]
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 任务状态为FAILED时，最大允许重试的次数
        /// </summary>
        [JsonProperty("max_retry_cnt", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetryCnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package_info", NullValueHandling = NullValueHandling.Ignore)]
        public VodPackageInfo PackageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHarvestJobStatusResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  taskDesc: ").Append(TaskDesc).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  maxRetryCnt: ").Append(MaxRetryCnt).Append("\n");
            sb.Append("  packageInfo: ").Append(PackageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHarvestJobStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHarvestJobStatusResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.TaskDesc != input.TaskDesc || (this.TaskDesc != null && !this.TaskDesc.Equals(input.TaskDesc))) return false;
            if (this.Status != input.Status) return false;
            if (this.MaxRetryCnt != input.MaxRetryCnt || (this.MaxRetryCnt != null && !this.MaxRetryCnt.Equals(input.MaxRetryCnt))) return false;
            if (this.PackageInfo != input.PackageInfo || (this.PackageInfo != null && !this.PackageInfo.Equals(input.PackageInfo))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EventName != null) hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.TaskDesc != null) hashCode = hashCode * 59 + this.TaskDesc.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MaxRetryCnt != null) hashCode = hashCode * 59 + this.MaxRetryCnt.GetHashCode();
                if (this.PackageInfo != null) hashCode = hashCode * 59 + this.PackageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
