using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlowExecutionBriefV2 
    {
        /// <summary>
        /// 函数流执行状态
        /// </summary>
        /// <value>函数流执行状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("success");

            /// <summary>
            /// Enum FAIL for value: fail
            /// </summary>
            public static readonly StatusEnum FAIL = new StatusEnum("fail");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("running");

            /// <summary>
            /// Enum TIMEOUT for value: timeout
            /// </summary>
            public static readonly StatusEnum TIMEOUT = new StatusEnum("timeout");

            /// <summary>
            /// Enum CANCEL for value: cancel
            /// </summary>
            public static readonly StatusEnum CANCEL = new StatusEnum("cancel");

            /// <summary>
            /// Enum SCHEDULED for value: scheduled
            /// </summary>
            public static readonly StatusEnum SCHEDULED = new StatusEnum("scheduled");

            /// <summary>
            /// Enum RECOVERED for value: recovered
            /// </summary>
            public static readonly StatusEnum RECOVERED = new StatusEnum("recovered");

            /// <summary>
            /// Enum RETRYING for value: retrying
            /// </summary>
            public static readonly StatusEnum RETRYING = new StatusEnum("retrying");

            /// <summary>
            /// Enum STOPPING for value: stopping
            /// </summary>
            public static readonly StatusEnum STOPPING = new StatusEnum("stopping");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "success", SUCCESS },
                { "fail", FAIL },
                { "running", RUNNING },
                { "timeout", TIMEOUT },
                { "cancel", CANCEL },
                { "scheduled", SCHEDULED },
                { "recovered", RECOVERED },
                { "retrying", RETRYING },
                { "stopping", STOPPING },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 函数流ID
        /// </summary>
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// 函数流执行ID
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 函数流执行状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 开始时间（格式为yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;,UTC时间）。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 结束时间（格式为yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;,UTC时间）。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 结束时间（格式为yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;,UTC时间）。
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 函数流执行urn
        /// </summary>
        [JsonProperty("workflow_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowUrn { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowExecutionBriefV2 {\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  createBy: ").Append(CreateBy).Append("\n");
            sb.Append("  workflowUrn: ").Append(WorkflowUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowExecutionBriefV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowExecutionBriefV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.ExecutionId == input.ExecutionId ||
                    (this.ExecutionId != null &&
                    this.ExecutionId.Equals(input.ExecutionId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.LastUpdateTime == input.LastUpdateTime ||
                    (this.LastUpdateTime != null &&
                    this.LastUpdateTime.Equals(input.LastUpdateTime))
                ) && 
                (
                    this.CreateBy == input.CreateBy ||
                    (this.CreateBy != null &&
                    this.CreateBy.Equals(input.CreateBy))
                ) && 
                (
                    this.WorkflowUrn == input.WorkflowUrn ||
                    (this.WorkflowUrn != null &&
                    this.WorkflowUrn.Equals(input.WorkflowUrn))
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
                if (this.WorkflowId != null)
                    hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.ExecutionId != null)
                    hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.LastUpdateTime != null)
                    hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.CreateBy != null)
                    hashCode = hashCode * 59 + this.CreateBy.GetHashCode();
                if (this.WorkflowUrn != null)
                    hashCode = hashCode * 59 + this.WorkflowUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
