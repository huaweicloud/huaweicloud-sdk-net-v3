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
    /// 对比列表信息体。
    /// </summary>
    public class CompareJobInfo 
    {
        /// <summary>
        /// 对比任务的状态。取值： - RUNNING：运行中。 - WAITING_FOR_RUNNING：等待启动中。 - SUCCESSFUL：完成。 - FAILED：失败。 - CANCELLED：已取消。 - TIMEOUT_INTERRUPT：超时中断。 - FULL_DOING：全量校验中。 - INCRE_DOING：增量校验中。
        /// </summary>
        /// <value>对比任务的状态。取值： - RUNNING：运行中。 - WAITING_FOR_RUNNING：等待启动中。 - SUCCESSFUL：完成。 - FAILED：失败。 - CANCELLED：已取消。 - TIMEOUT_INTERRUPT：超时中断。 - FULL_DOING：全量校验中。 - INCRE_DOING：增量校验中。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("RUNNING");

            /// <summary>
            /// Enum WAITING_FOR_RUNNING for value: WAITING_FOR_RUNNING
            /// </summary>
            public static readonly StatusEnum WAITING_FOR_RUNNING = new StatusEnum("WAITING_FOR_RUNNING");

            /// <summary>
            /// Enum SUCCESSFUL for value: SUCCESSFUL
            /// </summary>
            public static readonly StatusEnum SUCCESSFUL = new StatusEnum("SUCCESSFUL");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            public static readonly StatusEnum CANCELLED = new StatusEnum("CANCELLED");

            /// <summary>
            /// Enum TIMEOUT_INTERRUPT for value: TIMEOUT_INTERRUPT
            /// </summary>
            public static readonly StatusEnum TIMEOUT_INTERRUPT = new StatusEnum("TIMEOUT_INTERRUPT");

            /// <summary>
            /// Enum FULL_DOING for value: FULL_DOING
            /// </summary>
            public static readonly StatusEnum FULL_DOING = new StatusEnum("FULL_DOING");

            /// <summary>
            /// Enum INCRE_DOING for value: INCRE_DOING
            /// </summary>
            public static readonly StatusEnum INCRE_DOING = new StatusEnum("INCRE_DOING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "RUNNING", RUNNING },
                { "WAITING_FOR_RUNNING", WAITING_FOR_RUNNING },
                { "SUCCESSFUL", SUCCESSFUL },
                { "FAILED", FAILED },
                { "CANCELLED", CANCELLED },
                { "TIMEOUT_INTERRUPT", TIMEOUT_INTERRUPT },
                { "FULL_DOING", FULL_DOING },
                { "INCRE_DOING", INCRE_DOING },
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
        /// 对比任务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 对比类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 对比任务的状态。取值： - RUNNING：运行中。 - WAITING_FOR_RUNNING：等待启动中。 - SUCCESSFUL：完成。 - FAILED：失败。 - CANCELLED：已取消。 - TIMEOUT_INTERRUPT：超时中断。 - FULL_DOING：全量校验中。 - INCRE_DOING：增量校验中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 对比计算资源。
        /// </summary>
        [JsonProperty("compute_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputeType { get; set; }

        /// <summary>
        /// 导出比对结果状态。
        /// </summary>
        [JsonProperty("export_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// 导出比对结果有效期剩余时间。
        /// </summary>
        [JsonProperty("report_remain_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReportRemainSeconds { get; set; }

        /// <summary>
        /// 对比任务的标签。
        /// </summary>
        [JsonProperty("compare_job_tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CompareJobTag { get; set; }

        /// <summary>
        /// 对比任务选项。
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareJobInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  computeType: ").Append(ComputeType).Append("\n");
            sb.Append("  exportStatus: ").Append(ExportStatus).Append("\n");
            sb.Append("  reportRemainSeconds: ").Append(ReportRemainSeconds).Append("\n");
            sb.Append("  compareJobTag: ").Append(CompareJobTag).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareJobInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareJobInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.ComputeType != input.ComputeType || (this.ComputeType != null && !this.ComputeType.Equals(input.ComputeType))) return false;
            if (this.ExportStatus != input.ExportStatus || (this.ExportStatus != null && !this.ExportStatus.Equals(input.ExportStatus))) return false;
            if (this.ReportRemainSeconds != input.ReportRemainSeconds || (this.ReportRemainSeconds != null && !this.ReportRemainSeconds.Equals(input.ReportRemainSeconds))) return false;
            if (this.CompareJobTag != input.CompareJobTag || (this.CompareJobTag != null && input.CompareJobTag != null && !this.CompareJobTag.SequenceEqual(input.CompareJobTag))) return false;
            if (this.Options != input.Options || (this.Options != null && input.Options != null && !this.Options.SequenceEqual(input.Options))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ComputeType != null) hashCode = hashCode * 59 + this.ComputeType.GetHashCode();
                if (this.ExportStatus != null) hashCode = hashCode * 59 + this.ExportStatus.GetHashCode();
                if (this.ReportRemainSeconds != null) hashCode = hashCode * 59 + this.ReportRemainSeconds.GetHashCode();
                if (this.CompareJobTag != null) hashCode = hashCode * 59 + this.CompareJobTag.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
