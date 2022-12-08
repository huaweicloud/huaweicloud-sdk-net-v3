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
    /// create-execution-plan request parameters
    /// </summary>
    public class CreateExecutionPlanRequestBody 
    {

        /// <summary>
        /// 用户希望生成执行计划的栈（stack）的Id。此Id由资源编排服务在生成栈的时候生成，为UUID。
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// HCL模板，描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别 template_body 和 template_uri 有且仅有一个存在
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// HCL模板的OBS地址，描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别。目前接受纯tf文件或zip压缩包。 纯tf文件需要以“.tf”结尾，并遵守tf模板格式。压缩包目前只支持zip格式，文件需要以\&quot;.zip\&quot;结尾，压缩包解压后应该只包含文件，且文件均以“.tf”结尾，不支持nested结构 template_body 和 template_uri 有且仅有一个存在
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }

        /// <summary>
        /// 执行计划的名字，在domain_id+region+project_id+stack_id下应唯一。
        /// </summary>
        [JsonProperty("execution_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanName { get; set; }

        /// <summary>
        /// 执行计划的描述。可用于客户识别自己的执行计划
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// terraform支持参数，即，同一个模板可以给予不同的参数而达到不同的效果。var是一系列terraform所需要的参数。 注：资源编排服务支持vars、vars_body和vars_uri，如果vars、vars_body和vars_uri中声名了同一个变量，将报错400。 注：vars中的值只支持简单的字符串类型，如果其他类型，需要用户自己在HCL引用时转换，或者用户可以使用vars_body或vars_uri， vars_body和vars_uri中支持HCL支持的各种类型以及复杂结构。
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// terraform支持参数，即，同一个模板可以给予不同的参数而达到不同的效果。vars_body用于接收用户直接提交的tfvars文件内容
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// 参数文件的OBS地址，如果客户偏向使用文件维护参数，可以将参数上传OBS，并将OBS地址提交。 注：如果用户同时使用了vars_body、vars_uri和vars，且他们的内容中定义了同一个参数，资源编排服务将报错并返回400。 vars_uri和vars_body中的vars按照HCL的语义，可以支持各种类型、复杂结构等
        /// </summary>
        [JsonProperty("vars_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUri { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExecutionPlanRequestBody {\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("  executionPlanName: ").Append(ExecutionPlanName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  varsUri: ").Append(VarsUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateExecutionPlanRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateExecutionPlanRequestBody input)
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
                    this.TemplateBody == input.TemplateBody ||
                    (this.TemplateBody != null &&
                    this.TemplateBody.Equals(input.TemplateBody))
                ) && 
                (
                    this.TemplateUri == input.TemplateUri ||
                    (this.TemplateUri != null &&
                    this.TemplateUri.Equals(input.TemplateUri))
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
                    this.VarsBody == input.VarsBody ||
                    (this.VarsBody != null &&
                    this.VarsBody.Equals(input.VarsBody))
                ) && 
                (
                    this.VarsUri == input.VarsUri ||
                    (this.VarsUri != null &&
                    this.VarsUri.Equals(input.VarsUri))
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
                if (this.TemplateBody != null)
                    hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.TemplateUri != null)
                    hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                if (this.ExecutionPlanName != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VarsStructure != null)
                    hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.VarsBody != null)
                    hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.VarsUri != null)
                    hashCode = hashCode * 59 + this.VarsUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
