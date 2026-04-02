using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GcTask 
    {
        /// <summary>
        /// 任务类型，MANUAL：手动执行，SCHEDULE：定时执行。
        /// </summary>
        /// <value>任务类型，MANUAL：手动执行，SCHEDULE：定时执行。</value>
        [JsonConverter(typeof(EnumClassConverter<JobKindEnum>))]
        public class JobKindEnum
        {
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly JobKindEnum MANUAL = new JobKindEnum("MANUAL");

            /// <summary>
            /// Enum SCHEDULE for value: SCHEDULE
            /// </summary>
            public static readonly JobKindEnum SCHEDULE = new JobKindEnum("SCHEDULE");

            private static readonly Dictionary<string, JobKindEnum> StaticFields =
            new Dictionary<string, JobKindEnum>()
            {
                { "MANUAL", MANUAL },
                { "SCHEDULE", SCHEDULE },
            };

            private string _value;

            public JobKindEnum()
            {

            }

            public JobKindEnum(string value)
            {
                _value = value;
            }

            public static JobKindEnum FromValue(string value)
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

                if (this.Equals(obj as JobKindEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobKindEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobKindEnum a, JobKindEnum b)
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

            public static bool operator !=(JobKindEnum a, JobKindEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// gc任务的状态，Success：已完成，Stopped：已停止，Running：清理中，Pending：排队中，Error：失败。
        /// </summary>
        /// <value>gc任务的状态，Success：已完成，Stopped：已停止，Running：清理中，Pending：排队中，Error：失败。</value>
        [JsonConverter(typeof(EnumClassConverter<JobStatusEnum>))]
        public class JobStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: Success
            /// </summary>
            public static readonly JobStatusEnum SUCCESS = new JobStatusEnum("Success");

            /// <summary>
            /// Enum STOPPED for value: Stopped
            /// </summary>
            public static readonly JobStatusEnum STOPPED = new JobStatusEnum("Stopped");

            /// <summary>
            /// Enum RUNNING for value: Running
            /// </summary>
            public static readonly JobStatusEnum RUNNING = new JobStatusEnum("Running");

            /// <summary>
            /// Enum PENDING for value: Pending
            /// </summary>
            public static readonly JobStatusEnum PENDING = new JobStatusEnum("Pending");

            /// <summary>
            /// Enum ERROR for value: Error
            /// </summary>
            public static readonly JobStatusEnum ERROR = new JobStatusEnum("Error");

            private static readonly Dictionary<string, JobStatusEnum> StaticFields =
            new Dictionary<string, JobStatusEnum>()
            {
                { "Success", SUCCESS },
                { "Stopped", STOPPED },
                { "Running", RUNNING },
                { "Pending", PENDING },
                { "Error", ERROR },
            };

            private string _value;

            public JobStatusEnum()
            {

            }

            public JobStatusEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobStatusEnum a, JobStatusEnum b)
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

            public static bool operator !=(JobStatusEnum a, JobStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// gc任务的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// gc任务的名称。
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务类型，MANUAL：手动执行，SCHEDULE：定时执行。
        /// </summary>
        [JsonProperty("job_kind", NullValueHandling = NullValueHandling.Ignore)]
        public JobKindEnum JobKind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public JobParameters JobParameters { get; set; }

        /// <summary>
        /// gc任务的状态，Success：已完成，Stopped：已停止，Running：清理中，Pending：排队中，Error：失败。
        /// </summary>
        [JsonProperty("job_status", NullValueHandling = NullValueHandling.Ignore)]
        public JobStatusEnum JobStatus { get; set; }
        /// <summary>
        /// gc任务的创建时间。
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTime { get; set; }

        /// <summary>
        /// gc任务的更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcTask {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobKind: ").Append(JobKind).Append("\n");
            sb.Append("  jobParameters: ").Append(JobParameters).Append("\n");
            sb.Append("  jobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcTask input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.JobKind != input.JobKind) return false;
            if (this.JobParameters != input.JobParameters || (this.JobParameters != null && !this.JobParameters.Equals(input.JobParameters))) return false;
            if (this.JobStatus != input.JobStatus) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                hashCode = hashCode * 59 + this.JobKind.GetHashCode();
                if (this.JobParameters != null) hashCode = hashCode * 59 + this.JobParameters.GetHashCode();
                hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
