using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreatePrivateModuleVersionRequestBody 
    {

        /// <summary>
        /// 私有模块（private-module）的唯一Id。  此Id由资源编排服务在生成模块的时候生成，为UUID。  由于私有模块名仅在同一时间下唯一，即允许用户先生成一个叫HelloWorld的私有模块，删除，再重新创建一个同名私有模块。  对于团队并行开发，用户可能希望确保，当前我操作的私有模块就是我以为的那个，而不是其他队友删除后创建的同名私有模块。因此，使用Id就可以做到强匹配。  资源编排服务保证每次创建的私有模块所对应的Id都不相同，更新不会影响Id。如果给予的module_id和当前模块的Id不一致，则返回400
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 模块的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义
        /// </summary>
        [JsonProperty("module_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// 模块版本（module version）的描述。可用于客户识别并管理模块的版本。注意：模块版本为不可更新（immutable），即描述不可更新，如果需要更新，请删除后重建
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 模块（module）包的OBS地址。模块允许用户将可复用的代码编辑在一起供模块使用。  OBS地址支持同类型Region之间进行互相访问（Region分为通用Region和专属Region，通用Region指面向公共租户提供通用云服务的Region；专属Region指只承载同一类业务或只面向特定租户提供业务服务的专用Region）  模块包只支持zip压缩包，文件需要以\&quot;.zip\&quot;结尾。关于模块包的校验要求如下：   * 模块包中不得包含以\&quot;.tfvars\&quot;结尾的文件   * 模块包解压前后的大小均应控制在1MB以内   * 模块包内的文件数量不能超过100个   * 模块包内的文件路径不允许以正斜线（/）开头   * 模块包内的文件路径分隔符之间不允许为空格、\&quot;.\&quot;和\&quot;..\&quot;   * 模块包内的文件路径最长为2048   * 模块包内的文件名最长为255   * 模块包内应至少有一份模板文件（以\&quot;.tf\&quot;或\&quot;.tf.json\&quot;结尾的文件）  **注意：**   * 模块中的内容不支持敏感数据加密，资源编排服务会直接明文使用、log、展示、存储module_uri对应的模块包。
        /// </summary>
        [JsonProperty("module_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateModuleVersionRequestBody {\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  moduleVersion: ").Append(ModuleVersion).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  moduleUri: ").Append(ModuleUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateModuleVersionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateModuleVersionRequestBody input)
        {
            if (input == null) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.ModuleVersion != input.ModuleVersion || (this.ModuleVersion != null && !this.ModuleVersion.Equals(input.ModuleVersion))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.ModuleUri != input.ModuleUri || (this.ModuleUri != null && !this.ModuleUri.Equals(input.ModuleUri))) return false;

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
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.ModuleVersion != null) hashCode = hashCode * 59 + this.ModuleVersion.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.ModuleUri != null) hashCode = hashCode * 59 + this.ModuleUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
