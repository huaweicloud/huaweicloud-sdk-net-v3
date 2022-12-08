using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DescribeExecutionPlanResponse : SdkResponse
    {
        /// <summary>
        /// 执行计划的执行状态，只有当AVAILABLE的时候才可以使用apply执行     * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成     * &#x60;CREATION_FAILED&#x60; - 生成失败     * &#x60;AVAILABLE&#x60; - 执行计划已经生成完成。可以使用apply进行执行     * &#x60;APPLY_IN_PROGRESS&#x60; - 执行计划正在执行     * &#x60;APPLIED&#x60; - 执行完成
        /// </summary>
        /// <value>执行计划的执行状态，只有当AVAILABLE的时候才可以使用apply执行     * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成     * &#x60;CREATION_FAILED&#x60; - 生成失败     * &#x60;AVAILABLE&#x60; - 执行计划已经生成完成。可以使用apply进行执行     * &#x60;APPLY_IN_PROGRESS&#x60; - 执行计划正在执行     * &#x60;APPLIED&#x60; - 执行完成</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATION_IN_PROGRESS for value: CREATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum CREATION_IN_PROGRESS = new StatusEnum("CREATION_IN_PROGRESS");

            /// <summary>
            /// Enum CREATION_FAILED for value: CREATION_FAILED
            /// </summary>
            public static readonly StatusEnum CREATION_FAILED = new StatusEnum("CREATION_FAILED");

            /// <summary>
            /// Enum AVAILABLE for value: AVAILABLE
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("AVAILABLE");

            /// <summary>
            /// Enum APPLY_IN_PROGRESS for value: APPLY_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum APPLY_IN_PROGRESS = new StatusEnum("APPLY_IN_PROGRESS");

            /// <summary>
            /// Enum APPLIED for value: APPLIED
            /// </summary>
            public static readonly StatusEnum APPLIED = new StatusEnum("APPLIED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATION_IN_PROGRESS", CREATION_IN_PROGRESS },
                { "CREATION_FAILED", CREATION_FAILED },
                { "AVAILABLE", AVAILABLE },
                { "APPLY_IN_PROGRESS", APPLY_IN_PROGRESS },
                { "APPLIED", APPLIED },
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
        /// 栈的唯一Id,为uuid
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 栈的名字
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 执行计划的唯一Id，由资源编排服务随机生成,为uuid
        /// </summary>
        [JsonProperty("execution_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanId { get; set; }

        /// <summary>
        /// 执行计划的名字
        /// </summary>
        [JsonProperty("execution_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanName { get; set; }

        /// <summary>
        /// 执行计划的描述，此描述为用户在创建执行计划时指定
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// 创建该执行计划时，给出的vars文件中的内容
        /// </summary>
        [JsonProperty("vars_uri_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUriContent { get; set; }

        /// <summary>
        /// 创建该执行计划时，请求Body体中的tfvars文件内容
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// 执行计划的生成时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("apply_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 执行计划的执行状态，只有当AVAILABLE的时候才可以使用apply执行     * &#x60;CREATION_IN_PROGRESS&#x60; - 正在生成     * &#x60;CREATION_FAILED&#x60; - 生成失败     * &#x60;AVAILABLE&#x60; - 执行计划已经生成完成。可以使用apply进行执行     * &#x60;APPLY_IN_PROGRESS&#x60; - 执行计划正在执行     * &#x60;APPLIED&#x60; - 执行完成
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 展示执行计划状态更多细节的信息
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public ExecutionPlanSummary Summary { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeExecutionPlanResponse {\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  executionPlanId: ").Append(ExecutionPlanId).Append("\n");
            sb.Append("  executionPlanName: ").Append(ExecutionPlanName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("  varsUriContent: ").Append(VarsUriContent).Append("\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  applyTime: ").Append(ApplyTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeExecutionPlanResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeExecutionPlanResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackId == input.StackId ||
                    (this.StackId != null &&
                    this.StackId.Equals(input.StackId))
                ) && 
                (
                    this.StackName == input.StackName ||
                    (this.StackName != null &&
                    this.StackName.Equals(input.StackName))
                ) && 
                (
                    this.ExecutionPlanId == input.ExecutionPlanId ||
                    (this.ExecutionPlanId != null &&
                    this.ExecutionPlanId.Equals(input.ExecutionPlanId))
                ) && 
                (
                    this.ExecutionPlanName == input.ExecutionPlanName ||
                    (this.ExecutionPlanName != null &&
                    this.ExecutionPlanName.Equals(input.ExecutionPlanName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.VarsStructure == input.VarsStructure ||
                    this.VarsStructure != null &&
                    input.VarsStructure != null &&
                    this.VarsStructure.SequenceEqual(input.VarsStructure)
                ) && 
                (
                    this.VarsUriContent == input.VarsUriContent ||
                    (this.VarsUriContent != null &&
                    this.VarsUriContent.Equals(input.VarsUriContent))
                ) && 
                (
                    this.VarsBody == input.VarsBody ||
                    (this.VarsBody != null &&
                    this.VarsBody.Equals(input.VarsBody))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ApplyTime == input.ApplyTime ||
                    (this.ApplyTime != null &&
                    this.ApplyTime.Equals(input.ApplyTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusMessage == input.StatusMessage ||
                    (this.StatusMessage != null &&
                    this.StatusMessage.Equals(input.StatusMessage))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
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
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.ExecutionPlanId != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanId.GetHashCode();
                if (this.ExecutionPlanName != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VarsStructure != null)
                    hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.VarsUriContent != null)
                    hashCode = hashCode * 59 + this.VarsUriContent.GetHashCode();
                if (this.VarsBody != null)
                    hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ApplyTime != null)
                    hashCode = hashCode * 59 + this.ApplyTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                return hashCode;
            }
        }
    }
}
