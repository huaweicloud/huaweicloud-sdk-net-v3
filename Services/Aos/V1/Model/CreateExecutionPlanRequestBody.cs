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
    /// 
    /// </summary>
    public class CreateExecutionPlanRequestBody 
    {

        /// <summary>
        /// 资源栈（stack）的唯一ID。  此ID由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈，删除，再重新创建一个同名资源栈。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈就是我认为的那个，而不是其他队友删除后创建的同名资源栈。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈所对应的ID都不相同，更新不会影响ID。如果给予的stack_id和当前资源栈的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// HCL模板，描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别。  template_body和template_uri 必须有且只有一个存在  **注意：**   * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的template_body
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// HCL模板的OBS地址，该模板描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别  请确保OBS地址所在局点与使用RFS服务局点一致。  对应的文件应该是纯tf文件或zip压缩包  纯tf文件需要以“.tf”或者“.tf.json”结尾，并遵守HCL语法，且文件的编码格式须为UTF-8  压缩包目前只支持zip格式，文件需要以\&quot;.zip\&quot;结尾。解压后的文件不得包含\&quot;.tfvars\&quot;文件。解压前最大支持1MB，解压后最大支持1MB。zip压缩包文件数量不能超过100个  template_body和template_uri 必须有且只有一个存在  **注意：**   * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储template_uri对应的模板文件内容。   * template_uri对应的模板文件如果为zip类型，则内部的文件或文件夹名称长度不得超过255个字节，最深路径长度不得超过2048字节，zip包大小不得超过1MB
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }

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
        /// HCL参数结构。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * var_structure可以允许客户提交最简单的字符串类型的参数  * 资源编排服务支持vars_structure，vars_body和vars_uri，如果以上三种方式中声明了同一个变量，将报错400  * vars_structure中的值只支持简单的字符串类型，如果需要使用其他类型，需要用户自己在HCL引用时转换， 或者用户可以使用vars_uri、vars_body，vars_uri和vars_body中支持HCL支持的各种类型以及复杂结构  * 如果vars_structure过大，可以使用vars_uri  * 注意：vars_structure中默认不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示和存储对应的vars。如为敏感信息，建议设置encryption字段开启加密
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// HCL参数文件的内容。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * vars_body使用HCL的tfvars格式，用户可以将“.tfvars”中的内容提交到vars_body中  * 资源编排服务支持vars_body和vars_uri，如果以上两种方式中声明了同一个变量，将报错400  * 如果vars_body过大，可以使用vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储对应的vars_body。
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// HCL参数文件的OBS地址。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  请确保OBS地址所在局点与使用RFS服务局点一致。  * vars_uri需要指向一个OBS的pre-signed URL地址，其他地址暂不支持  * 资源编排服务支持vars_body和vars_uri，如果以上两种方式中声明了同一个变量，将报错400  * vars_uri中的内容使用HCL的tfvars格式，用户可以将“.tfvars”中的内容保存到文件并上传到OBS中，并将OBS pre-signed URL传递给vars_uri  * 资源栈集不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储vars_uri对应的参数文件内容
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
            if (input == null) return false;
            if (this.StackId != input.StackId || (this.StackId != null && !this.StackId.Equals(input.StackId))) return false;
            if (this.TemplateBody != input.TemplateBody || (this.TemplateBody != null && !this.TemplateBody.Equals(input.TemplateBody))) return false;
            if (this.TemplateUri != input.TemplateUri || (this.TemplateUri != null && !this.TemplateUri.Equals(input.TemplateUri))) return false;
            if (this.ExecutionPlanName != input.ExecutionPlanName || (this.ExecutionPlanName != null && !this.ExecutionPlanName.Equals(input.ExecutionPlanName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.VarsStructure != input.VarsStructure || (this.VarsStructure != null && input.VarsStructure != null && !this.VarsStructure.SequenceEqual(input.VarsStructure))) return false;
            if (this.VarsBody != input.VarsBody || (this.VarsBody != null && !this.VarsBody.Equals(input.VarsBody))) return false;
            if (this.VarsUri != input.VarsUri || (this.VarsUri != null && !this.VarsUri.Equals(input.VarsUri))) return false;

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
                if (this.StackId != null) hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.TemplateBody != null) hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.TemplateUri != null) hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                if (this.ExecutionPlanName != null) hashCode = hashCode * 59 + this.ExecutionPlanName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VarsStructure != null) hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.VarsBody != null) hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.VarsUri != null) hashCode = hashCode * 59 + this.VarsUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
