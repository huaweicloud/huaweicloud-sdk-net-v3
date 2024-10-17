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
    /// 对象级对比任务信息体。
    /// </summary>
    public class ObjectsCompareTaskInfo 
    {
        /// <summary>
        /// 对比任务状态。取值： - RUNNING：运行中。 - WAITING_FOR_RUNNING：等待启动中。 - SUCCESSFUL：完成。 - FAILED：失败。 - CANCELLED：已取消。
        /// </summary>
        /// <value>对比任务状态。取值： - RUNNING：运行中。 - WAITING_FOR_RUNNING：等待启动中。 - SUCCESSFUL：完成。 - FAILED：失败。 - CANCELLED：已取消。</value>
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

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "RUNNING", RUNNING },
                { "WAITING_FOR_RUNNING", WAITING_FOR_RUNNING },
                { "SUCCESSFUL", SUCCESSFUL },
                { "FAILED", FAILED },
                { "CANCELLED", CANCELLED },
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
        /// 对比任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 对比结果。
        /// </summary>
        [JsonProperty("compare_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectsCompareOverviewInfo> CompareResults { get; set; }

        /// <summary>
        /// 对比任务开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 对比任务状态。取值： - RUNNING：运行中。 - WAITING_FOR_RUNNING：等待启动中。 - SUCCESSFUL：完成。 - FAILED：失败。 - CANCELLED：已取消。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
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
        /// 对比任务ID。
        /// </summary>
        [JsonProperty("compare_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareJobId { get; set; }

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
            sb.Append("class ObjectsCompareTaskInfo {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  compareResults: ").Append(CompareResults).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  exportStatus: ").Append(ExportStatus).Append("\n");
            sb.Append("  reportRemainSeconds: ").Append(ReportRemainSeconds).Append("\n");
            sb.Append("  compareJobId: ").Append(CompareJobId).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectsCompareTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectsCompareTaskInfo input)
        {
            if (input == null) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CompareResults != input.CompareResults || (this.CompareResults != null && input.CompareResults != null && !this.CompareResults.SequenceEqual(input.CompareResults))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.ExportStatus != input.ExportStatus || (this.ExportStatus != null && !this.ExportStatus.Equals(input.ExportStatus))) return false;
            if (this.ReportRemainSeconds != input.ReportRemainSeconds || (this.ReportRemainSeconds != null && !this.ReportRemainSeconds.Equals(input.ReportRemainSeconds))) return false;
            if (this.CompareJobId != input.CompareJobId || (this.CompareJobId != null && !this.CompareJobId.Equals(input.CompareJobId))) return false;
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
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CompareResults != null) hashCode = hashCode * 59 + this.CompareResults.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExportStatus != null) hashCode = hashCode * 59 + this.ExportStatus.GetHashCode();
                if (this.ReportRemainSeconds != null) hashCode = hashCode * 59 + this.ReportRemainSeconds.GetHashCode();
                if (this.CompareJobId != null) hashCode = hashCode * 59 + this.CompareJobId.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
