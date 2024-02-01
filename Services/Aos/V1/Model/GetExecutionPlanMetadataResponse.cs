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
    public class GetExecutionPlanMetadataResponse : SdkResponse
    {
        /// <summary>
        /// 执行计划的状态    * &#x60;CREATION_IN_PROGRESS&#x60; - 正在创建，请等待    * &#x60;CREATION_FAILED&#x60; - 创建失败，请从status_message获取错误信息汇总    * &#x60;AVAILABLE&#x60; - 创建完成，可以调用ApplyExecutionPlan API进行执行    * &#x60;APPLY_IN_PROGRESS&#x60; - 执行中，可通过GetStackMetadata查询资源栈状态，通过ListStackEvents获取执行过程中产生的资源栈事件    * &#x60;APPLIED&#x60; - 已执行
        /// </summary>
        /// <value>执行计划的状态    * &#x60;CREATION_IN_PROGRESS&#x60; - 正在创建，请等待    * &#x60;CREATION_FAILED&#x60; - 创建失败，请从status_message获取错误信息汇总    * &#x60;AVAILABLE&#x60; - 创建完成，可以调用ApplyExecutionPlan API进行执行    * &#x60;APPLY_IN_PROGRESS&#x60; - 执行中，可通过GetStackMetadata查询资源栈状态，通过ListStackEvents获取执行过程中产生的资源栈事件    * &#x60;APPLIED&#x60; - 已执行</value>
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
        /// 资源栈（stack）的唯一ID。  此ID由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈，删除，再重新创建一个同名资源栈。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈就是我认为的那个，而不是其他队友删除后创建的同名资源栈。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈所对应的ID都不相同，更新不会影响ID。如果给予的stack_id和当前资源栈的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 资源栈的名称。此名字在domain_id+区域+project_id下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 执行计划（execution_plan）的唯一Id。  此Id由资源编排服务在生成执行计划的时候生成，为UUID。  由于执行计划名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的执行计划，删除，再重新创建一个同名执行计划。  对于团队并行开发，用户可能希望确保，当前我操作的执行计划就是我认为的那个，而不是其他队友删除后创建的同名执行计划。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的执行计划所对应的ID都不相同，更新不会影响ID。如果给予的execution_plan_id和当前执行计划的ID不一致，则返回400
        /// </summary>
        [JsonProperty("execution_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanId { get; set; }

        /// <summary>
        /// 执行计划的名称。此名字在domain_id+区域+project_id+stack_id下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("execution_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanName { get; set; }

        /// <summary>
        /// 执行计划的描述。可用于客户识别自己的执行计划。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// HCL参数结构。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * var_structure可以允许客户提交最简单的字符串类型的参数  * 资源编排服务支持vars_structure，vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  * vars_structure中的值只支持简单的字符串类型，如果需要使用其他类型，需要用户自己在HCL引用时转换， 或者用户可以使用vars_uri、vars_body，vars_uri和vars_body中支持HCL支持的各种类型以及复杂结构  * 如果vars_structure过大，可以使用vars_uri  * 注意：vars_structure中默认不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的vars。如为敏感信息，建议设置encryption字段开启加密
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// vars_uri对应的文件内容
        /// </summary>
        [JsonProperty("vars_uri_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUriContent { get; set; }

        /// <summary>
        /// HCL参数文件的内容。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * vars_body使用HCL的tfvars格式，用户可以将“.tfvars”中的内容提交到vars_body中  * 资源编排服务支持vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  * 如果vars_body过大，可以使用vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的vars_body。
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// 执行计划的状态    * &#x60;CREATION_IN_PROGRESS&#x60; - 正在创建，请等待    * &#x60;CREATION_FAILED&#x60; - 创建失败，请从status_message获取错误信息汇总    * &#x60;AVAILABLE&#x60; - 创建完成，可以调用ApplyExecutionPlan API进行执行    * &#x60;APPLY_IN_PROGRESS&#x60; - 执行中，可通过GetStackMetadata查询资源栈状态，通过ListStackEvents获取执行过程中产生的资源栈事件    * &#x60;APPLIED&#x60; - 已执行
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 当执行计划的状态为创建失败状态（即为 &#x60;CREATION_FAILED&#x60; 时），将会展示简要的错误信息总结以供debug
        /// </summary>
        [JsonProperty("status_message", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 执行计划的生成时间 格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 执行计划的执行时间 格式遵循RFC3339，即yyyy-mm-ddTHH:MM:SSZ，如1970-01-01T00:00:00Z
        /// </summary>
        [JsonProperty("apply_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyTime { get; set; }

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
            sb.Append("class GetExecutionPlanMetadataResponse {\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  executionPlanId: ").Append(ExecutionPlanId).Append("\n");
            sb.Append("  executionPlanName: ").Append(ExecutionPlanName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("  varsUriContent: ").Append(VarsUriContent).Append("\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusMessage: ").Append(StatusMessage).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  applyTime: ").Append(ApplyTime).Append("\n");
            sb.Append("  summary: ").Append(Summary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetExecutionPlanMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetExecutionPlanMetadataResponse input)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusMessage != null)
                    hashCode = hashCode * 59 + this.StatusMessage.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ApplyTime != null)
                    hashCode = hashCode * 59 + this.ApplyTime.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                return hashCode;
            }
        }
    }
}
