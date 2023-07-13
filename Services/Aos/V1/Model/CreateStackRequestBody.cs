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
    public class CreateStackRequestBody 
    {

        /// <summary>
        /// 资源栈的名称。此名字在domain_id+区域+project_id下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 委托授权的信息。  RFS仅在创建资源栈（触发部署）、创建执行计划、部署资源栈、删除资源栈等涉及资源操作的请求中使用委托，且该委托仅作用于与之绑定的Provider对资源的操作中。若委托中提供的权限不足，有可能导致相关资源操作失败。
        /// </summary>
        [JsonProperty("agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Agency> Agencies { get; set; }

        /// <summary>
        /// 资源栈的描述。可用于客户识别自己的资源栈。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 删除保护的标识位，如果不传默认为false，即默认不开启资源栈删除保护（删除保护开启后资源栈不允许被删除）  *在UpdateStack API中，若该参数未在RequestBody中给予，则不会对资源栈的删除保护属性进行更新*
        /// </summary>
        [JsonProperty("enable_deletion_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDeletionProtection { get; set; }

        /// <summary>
        /// 自动回滚的标识位，如果不传默认为false，即默认不开启资源栈自动回滚（自动回滚开启后，如果部署失败，则会自动回滚，并返回上一个稳定状态）  *在UpdateStack API中，若该参数未在RequestBody中给予，则不会对资源栈的自动回滚属性进行更新*
        /// </summary>
        [JsonProperty("enable_auto_rollback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoRollback { get; set; }

        /// <summary>
        /// HCL模板，描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别。  template_body和template_uri 必须有且只有一个存在  *在CreateStack API中，template_body和template_uri可以都不给予*  **注意：**   * template_body中默认不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的template_body。如为敏感信息，建议将敏感信息通过vars_structure参数化，并设置encryption字段开启加密
        /// </summary>
        [JsonProperty("template_body", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// HCL模板的OBS地址，该模板描述了资源的目标状态。资源编排服务将比较此模板与当前远程资源的状态之间的区别。  OBS地址支持同类型Region之间进行互相访问（Region分为通用Region和专属Region，通用Region指面向公共租户提供通用云服务的Region；专属Region指只承载同一类业务或只面向特定租户提供业务服务的专用Region）  对应的文件应该是纯tf文件或zip压缩包  纯tf文件需要以&#x60;.tf&#x60;或者&#x60;.tf.json&#x60;结尾，并遵守HCL语法  压缩包目前只支持zip格式，文件需要以&#x60;.zip&#x60;结尾。解压后的文件不得包含\&quot;.tfvars\&quot;文件且必须是UTF8编码（其中.tf.json不能包含BOM头），zip压缩包当前支持的子文件数量最大为100  template_body和template_uri 必须有且只有一个存在  *在CreateStack API中，template_body和template_uri可以都不给予*  **注意：**   * template_uri对应的模板文件中默认不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的模板文件内容。如为敏感信息，建议将敏感信息通过vars_structure参数化，并设置encryption字段开启加密   * template_uri对应的文件（或文件夹、zip包）名的长度不得超过255个字节，文件大小不得超过1MB
        /// </summary>
        [JsonProperty("template_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateUri { get; set; }

        /// <summary>
        /// HCL参数文件的内容。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * vars_body使用HCL的tfvars格式，用户可以将“.tfvars”中的内容提交到vars_body中。  * 资源编排服务支持vars_structure，vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  * 如果vars_body过大，可以使用vars_uri  * 如果vars中都是简单的字符串格式，可以使用var_structure  * 注意：vars_body中不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的vars。如为敏感信息，建议通过vars_structure并设置encryption字段传递
        /// </summary>
        [JsonProperty("vars_body", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsBody { get; set; }

        /// <summary>
        /// HCL参数结构。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  * var_structure可以允许客户提交最简单的字符串类型的参数  * 资源编排服务支持vars_structure，vars_body和vars_uri，如果他们中声名了同一个变量，将报错400  * vars_structure中的值只支持简单的字符串类型，如果需要使用其他类型，需要用户自己在HCL引用时转换， 或者用户可以使用vars_uri、vars_body，vars_uri和vars_body中支持HCL支持的各种类型以及复杂结构  * 如果vars_structure过大，可以使用vars_uri  * 注意：vars_structure中默认不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的vars。如为敏感信息，建议设置encryption字段开启加密
        /// </summary>
        [JsonProperty("vars_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<VarsStructure> VarsStructure { get; set; }

        /// <summary>
        /// HCL参数文件的OBS地址。HCL模板支持参数传入，即，同一个模板可以给予不同的参数而达到不同的效果。  OBS地址支持同类型Region之间进行互相访问（Region分为通用Region和专属Region，通用Region指面向公共租户提供通用云服务的Region；专属Region指只承载同一类业务或只面向特定租户提供业务服务的专用Region）  * 资源编排服务支持vars_structure，vars_body和vars_uri，如果他们中声名了同一个变量，将报错400 * vars_uri中的内容使用HCL的tfvars格式，用户可以将“.tfvars”中的内容保存到文件并上传到OBS中，并将OBS pre-signed URL传递给vars_uri。 * 注意：vars_uri的内容不应该含有任何敏感信息，资源编排服务会直接明文使用、log、展示、存储对应的vars。如为敏感信息，建议通过vars_structure并设置encryption字段传递
        /// </summary>
        [JsonProperty("vars_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VarsUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateStackRequestBody {\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  agencies: ").Append(Agencies).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enableDeletionProtection: ").Append(EnableDeletionProtection).Append("\n");
            sb.Append("  enableAutoRollback: ").Append(EnableAutoRollback).Append("\n");
            sb.Append("  templateBody: ").Append(TemplateBody).Append("\n");
            sb.Append("  templateUri: ").Append(TemplateUri).Append("\n");
            sb.Append("  varsBody: ").Append(VarsBody).Append("\n");
            sb.Append("  varsStructure: ").Append(VarsStructure).Append("\n");
            sb.Append("  varsUri: ").Append(VarsUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateStackRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateStackRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackName == input.StackName ||
                    (this.StackName != null &&
                    this.StackName.Equals(input.StackName))
                ) && 
                (
                    this.Agencies == input.Agencies ||
                    this.Agencies != null &&
                    input.Agencies != null &&
                    this.Agencies.SequenceEqual(input.Agencies)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnableDeletionProtection == input.EnableDeletionProtection ||
                    (this.EnableDeletionProtection != null &&
                    this.EnableDeletionProtection.Equals(input.EnableDeletionProtection))
                ) && 
                (
                    this.EnableAutoRollback == input.EnableAutoRollback ||
                    (this.EnableAutoRollback != null &&
                    this.EnableAutoRollback.Equals(input.EnableAutoRollback))
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
                    this.VarsBody == input.VarsBody ||
                    (this.VarsBody != null &&
                    this.VarsBody.Equals(input.VarsBody))
                ) && 
                (
                    this.VarsStructure == input.VarsStructure ||
                    this.VarsStructure != null &&
                    input.VarsStructure != null &&
                    this.VarsStructure.SequenceEqual(input.VarsStructure)
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
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.Agencies != null)
                    hashCode = hashCode * 59 + this.Agencies.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnableDeletionProtection != null)
                    hashCode = hashCode * 59 + this.EnableDeletionProtection.GetHashCode();
                if (this.EnableAutoRollback != null)
                    hashCode = hashCode * 59 + this.EnableAutoRollback.GetHashCode();
                if (this.TemplateBody != null)
                    hashCode = hashCode * 59 + this.TemplateBody.GetHashCode();
                if (this.TemplateUri != null)
                    hashCode = hashCode * 59 + this.TemplateUri.GetHashCode();
                if (this.VarsBody != null)
                    hashCode = hashCode * 59 + this.VarsBody.GetHashCode();
                if (this.VarsStructure != null)
                    hashCode = hashCode * 59 + this.VarsStructure.GetHashCode();
                if (this.VarsUri != null)
                    hashCode = hashCode * 59 + this.VarsUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
