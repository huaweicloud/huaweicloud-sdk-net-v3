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
    /// 任务详情
    /// </summary>
    public class StepDetail 
    {
        /// <summary>
        /// 任务状态
        /// </summary>
        /// <value>任务状态</value>
        [JsonConverter(typeof(EnumClassConverter<StepStatusEnum>))]
        public class StepStatusEnum
        {
            /// <summary>
            /// Enum FINISH for value: FINISH
            /// </summary>
            public static readonly StepStatusEnum FINISH = new StepStatusEnum("FINISH");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StepStatusEnum FAILED = new StepStatusEnum("FAILED");

            /// <summary>
            /// Enum EXECUTING for value: EXECUTING
            /// </summary>
            public static readonly StepStatusEnum EXECUTING = new StepStatusEnum("EXECUTING");

            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly StepStatusEnum WAITING = new StepStatusEnum("WAITING");

            private static readonly Dictionary<string, StepStatusEnum> StaticFields =
            new Dictionary<string, StepStatusEnum>()
            {
                { "FINISH", FINISH },
                { "FAILED", FAILED },
                { "EXECUTING", EXECUTING },
                { "WAITING", WAITING },
            };

            private string _value;

            public StepStatusEnum()
            {

            }

            public StepStatusEnum(string value)
            {
                _value = value;
            }

            public static StepStatusEnum FromValue(string value)
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

                if (this.Equals(obj as StepStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StepStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StepStatusEnum a, StepStatusEnum b)
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

            public static bool operator !=(StepStatusEnum a, StepStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("step_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StepId { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("step_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StepName { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("step_status", NullValueHandling = NullValueHandling.Ignore)]
        public StepStatusEnum StepStatus { get; set; }
        /// <summary>
        /// 任务启动时间，格式为2020-06-17T07:38:42.503Z
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 任务结束时间，格式为2020-06-17T07:38:42.503Z
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 子任务详情列表
        /// </summary>
        [JsonProperty("sub_step_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubStepDetail> SubStepDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepDetail {\n");
            sb.Append("  stepId: ").Append(StepId).Append("\n");
            sb.Append("  stepName: ").Append(StepName).Append("\n");
            sb.Append("  stepStatus: ").Append(StepStatus).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  subStepDetails: ").Append(SubStepDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StepDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StepDetail input)
        {
            if (input == null) return false;
            if (this.StepId != input.StepId || (this.StepId != null && !this.StepId.Equals(input.StepId))) return false;
            if (this.StepName != input.StepName || (this.StepName != null && !this.StepName.Equals(input.StepName))) return false;
            if (this.StepStatus != input.StepStatus) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.SubStepDetails != input.SubStepDetails || (this.SubStepDetails != null && input.SubStepDetails != null && !this.SubStepDetails.SequenceEqual(input.SubStepDetails))) return false;

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
                if (this.StepId != null) hashCode = hashCode * 59 + this.StepId.GetHashCode();
                if (this.StepName != null) hashCode = hashCode * 59 + this.StepName.GetHashCode();
                hashCode = hashCode * 59 + this.StepStatus.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.SubStepDetails != null) hashCode = hashCode * 59 + this.SubStepDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
