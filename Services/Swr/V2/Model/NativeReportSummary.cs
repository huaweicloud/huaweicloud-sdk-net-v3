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
    /// 云原生制品扫描报告摘要
    /// </summary>
    public class NativeReportSummary 
    {
        /// <summary>
        /// 制品扫描状态，Pending(扫描等待中)、Running(扫描中)、Error(扫描失败)、Success(扫描成功)
        /// </summary>
        /// <value>制品扫描状态，Pending(扫描等待中)、Running(扫描中)、Error(扫描失败)、Success(扫描成功)</value>
        [JsonConverter(typeof(EnumClassConverter<ScanStatusEnum>))]
        public class ScanStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: Success
            /// </summary>
            public static readonly ScanStatusEnum SUCCESS = new ScanStatusEnum("Success");

            /// <summary>
            /// Enum ERROR for value: Error
            /// </summary>
            public static readonly ScanStatusEnum ERROR = new ScanStatusEnum("Error");

            /// <summary>
            /// Enum RUNNING for value: Running
            /// </summary>
            public static readonly ScanStatusEnum RUNNING = new ScanStatusEnum("Running");

            /// <summary>
            /// Enum PENDING for value: Pending
            /// </summary>
            public static readonly ScanStatusEnum PENDING = new ScanStatusEnum("Pending");

            private static readonly Dictionary<string, ScanStatusEnum> StaticFields =
            new Dictionary<string, ScanStatusEnum>()
            {
                { "Success", SUCCESS },
                { "Error", ERROR },
                { "Running", RUNNING },
                { "Pending", PENDING },
            };

            private string _value;

            public ScanStatusEnum()
            {

            }

            public ScanStatusEnum(string value)
            {
                _value = value;
            }

            public static ScanStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ScanStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScanStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScanStatusEnum a, ScanStatusEnum b)
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

            public static bool operator !=(ScanStatusEnum a, ScanStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 制品扫描报告的总体严重程度，None(无评分), Low(低危), Medium(中危), High(高危), Critical(严重), Security(安全)
        /// </summary>
        /// <value>制品扫描报告的总体严重程度，None(无评分), Low(低危), Medium(中危), High(高危), Critical(严重), Security(安全)</value>
        [JsonConverter(typeof(EnumClassConverter<SeverityEnum>))]
        public class SeverityEnum
        {
            /// <summary>
            /// Enum NONE for value: None
            /// </summary>
            public static readonly SeverityEnum NONE = new SeverityEnum("None");

            /// <summary>
            /// Enum LOW for value: Low
            /// </summary>
            public static readonly SeverityEnum LOW = new SeverityEnum("Low");

            /// <summary>
            /// Enum MEDIUM for value: Medium
            /// </summary>
            public static readonly SeverityEnum MEDIUM = new SeverityEnum("Medium");

            /// <summary>
            /// Enum HIGH for value: High
            /// </summary>
            public static readonly SeverityEnum HIGH = new SeverityEnum("High");

            /// <summary>
            /// Enum CRITICAL for value: Critical
            /// </summary>
            public static readonly SeverityEnum CRITICAL = new SeverityEnum("Critical");

            /// <summary>
            /// Enum SECURITY for value: Security
            /// </summary>
            public static readonly SeverityEnum SECURITY = new SeverityEnum("Security");

            private static readonly Dictionary<string, SeverityEnum> StaticFields =
            new Dictionary<string, SeverityEnum>()
            {
                { "None", NONE },
                { "Low", LOW },
                { "Medium", MEDIUM },
                { "High", HIGH },
                { "Critical", CRITICAL },
                { "Security", SECURITY },
            };

            private string _value;

            public SeverityEnum()
            {

            }

            public SeverityEnum(string value)
            {
                _value = value;
            }

            public static SeverityEnum FromValue(string value)
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

                if (this.Equals(obj as SeverityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SeverityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SeverityEnum a, SeverityEnum b)
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

            public static bool operator !=(SeverityEnum a, SeverityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 报告ID
        /// </summary>
        [JsonProperty("report_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }

        /// <summary>
        /// 制品扫描状态，Pending(扫描等待中)、Running(扫描中)、Error(扫描失败)、Success(扫描成功)
        /// </summary>
        [JsonProperty("scan_status", NullValueHandling = NullValueHandling.Ignore)]
        public ScanStatusEnum ScanStatus { get; set; }
        /// <summary>
        /// 制品扫描报告的总体严重程度，None(无评分), Low(低危), Medium(中危), High(高危), Critical(严重), Security(安全)
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// 生成报告所花费的秒数时间
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public VulnerabilitySummary Summary { get; set; }

        /// <summary>
        /// 生成报告的扫描进程的开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 生成报告的扫描进程的结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 扫描的完成百分比，该值介于0和100之间
        /// </summary>
        [JsonProperty("complete_percent", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletePercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scanner", NullValueHandling = NullValueHandling.Ignore)]
        public Scanner Scanner { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NativeReportSummary {\n");
            sb.Append("  reportId: ").Append(ReportId).Append("\n");
            sb.Append("  scanStatus: ").Append(ScanStatus).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  completePercent: ").Append(CompletePercent).Append("\n");
            sb.Append("  scanner: ").Append(Scanner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NativeReportSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NativeReportSummary input)
        {
            if (input == null) return false;
            if (this.ReportId != input.ReportId || (this.ReportId != null && !this.ReportId.Equals(input.ReportId))) return false;
            if (this.ScanStatus != input.ScanStatus) return false;
            if (this.Severity != input.Severity) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Summary != input.Summary || (this.Summary != null && !this.Summary.Equals(input.Summary))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.CompletePercent != input.CompletePercent || (this.CompletePercent != null && !this.CompletePercent.Equals(input.CompletePercent))) return false;
            if (this.Scanner != input.Scanner || (this.Scanner != null && !this.Scanner.Equals(input.Scanner))) return false;

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
                if (this.ReportId != null) hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                hashCode = hashCode * 59 + this.ScanStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Summary != null) hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CompletePercent != null) hashCode = hashCode * 59 + this.CompletePercent.GetHashCode();
                if (this.Scanner != null) hashCode = hashCode * 59 + this.Scanner.GetHashCode();
                return hashCode;
            }
        }
    }
}
