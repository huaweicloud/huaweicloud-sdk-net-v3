using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CompareTaskList 
    {
        /// <summary>
        /// 对比任务的状态。 - RUNNING-运行中 - WAITING_FOR_RUNNING-等待启动中 - SUCCESSFUL-完成 - FAILED-失败 - CANCELLED-已取消 - TIMEOUT_INTERRUPT-超时中断 - FULL_DOING-全量校验中 - INCRE_DOING-增量校验中
        /// </summary>
        /// <value>对比任务的状态。 - RUNNING-运行中 - WAITING_FOR_RUNNING-等待启动中 - SUCCESSFUL-完成 - FAILED-失败 - CANCELLED-已取消 - TIMEOUT_INTERRUPT-超时中断 - FULL_DOING-全量校验中 - INCRE_DOING-增量校验中</value>
        [JsonConverter(typeof(EnumClassConverter<CompareTaskStatusEnum>))]
        public class CompareTaskStatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly CompareTaskStatusEnum RUNNING = new CompareTaskStatusEnum("RUNNING");

            /// <summary>
            /// Enum WAITING_FOR_RUNNING for value: WAITING_FOR_RUNNING
            /// </summary>
            public static readonly CompareTaskStatusEnum WAITING_FOR_RUNNING = new CompareTaskStatusEnum("WAITING_FOR_RUNNING");

            /// <summary>
            /// Enum SUCCESSFUL for value: SUCCESSFUL
            /// </summary>
            public static readonly CompareTaskStatusEnum SUCCESSFUL = new CompareTaskStatusEnum("SUCCESSFUL");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly CompareTaskStatusEnum FAILED = new CompareTaskStatusEnum("FAILED");

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            public static readonly CompareTaskStatusEnum CANCELLED = new CompareTaskStatusEnum("CANCELLED");

            /// <summary>
            /// Enum TIMEOUT_INTERRUPT for value: TIMEOUT_INTERRUPT
            /// </summary>
            public static readonly CompareTaskStatusEnum TIMEOUT_INTERRUPT = new CompareTaskStatusEnum("TIMEOUT_INTERRUPT");

            /// <summary>
            /// Enum FULL_DOING for value: FULL_DOING
            /// </summary>
            public static readonly CompareTaskStatusEnum FULL_DOING = new CompareTaskStatusEnum("FULL_DOING");

            /// <summary>
            /// Enum INCRE_DOING for value: INCRE_DOING
            /// </summary>
            public static readonly CompareTaskStatusEnum INCRE_DOING = new CompareTaskStatusEnum("INCRE_DOING");

            private static readonly Dictionary<string, CompareTaskStatusEnum> StaticFields =
            new Dictionary<string, CompareTaskStatusEnum>()
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

            public CompareTaskStatusEnum()
            {

            }

            public CompareTaskStatusEnum(string value)
            {
                _value = value;
            }

            public static CompareTaskStatusEnum FromValue(string value)
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

                if (this.Equals(obj as CompareTaskStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompareTaskStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompareTaskStatusEnum a, CompareTaskStatusEnum b)
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

            public static bool operator !=(CompareTaskStatusEnum a, CompareTaskStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 对比任务的id。
        /// </summary>
        [JsonProperty("compare_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareTaskId { get; set; }

        /// <summary>
        /// 对比任务的类型。 lines：行对比，contents：值对比，object_comparison：对象级对比落库，object：对象级对比落库，account：账户对比，random：抽样比对，node：内核计算对比结果，mgr：管控计算对比结果
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareType { get; set; }

        /// <summary>
        /// 对比任务的状态。 - RUNNING-运行中 - WAITING_FOR_RUNNING-等待启动中 - SUCCESSFUL-完成 - FAILED-失败 - CANCELLED-已取消 - TIMEOUT_INTERRUPT-超时中断 - FULL_DOING-全量校验中 - INCRE_DOING-增量校验中
        /// </summary>
        [JsonProperty("compare_task_status", NullValueHandling = NullValueHandling.Ignore)]
        public CompareTaskStatusEnum CompareTaskStatus { get; set; }
        /// <summary>
        /// 对比开始时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 对比结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareTaskList {\n");
            sb.Append("  compareTaskId: ").Append(CompareTaskId).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  compareTaskStatus: ").Append(CompareTaskStatus).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareTaskList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareTaskList input)
        {
            if (input == null) return false;
            if (this.CompareTaskId != input.CompareTaskId || (this.CompareTaskId != null && !this.CompareTaskId.Equals(input.CompareTaskId))) return false;
            if (this.CompareType != input.CompareType || (this.CompareType != null && !this.CompareType.Equals(input.CompareType))) return false;
            if (this.CompareTaskStatus != input.CompareTaskStatus) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.CompareTaskId != null) hashCode = hashCode * 59 + this.CompareTaskId.GetHashCode();
                if (this.CompareType != null) hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                hashCode = hashCode * 59 + this.CompareTaskStatus.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
