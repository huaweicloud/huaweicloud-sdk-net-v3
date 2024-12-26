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
    public class UpdatePrivateModuleMetadataRequestBody 
    {

        /// <summary>
        /// 私有模块（private-module）的描述。可用于客户识别被管理的私有模块。如果想要更新私有模块的描述，可以通过UpdatePrivateModuleMetadata API。
        /// </summary>
        [JsonProperty("module_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleDescription { get; set; }

        /// <summary>
        /// 私有模块（private-module）的唯一Id。  此Id由资源编排服务在生成模块的时候生成，为UUID。  由于私有模块名仅在同一时间下唯一，即允许用户先生成一个叫HelloWorld的私有模块，删除，再重新创建一个同名私有模块。  对于团队并行开发，用户可能希望确保，当前我操作的私有模块就是我以为的那个，而不是其他队友删除后创建的同名私有模块。因此，使用Id就可以做到强匹配。  资源编排服务保证每次创建的私有模块所对应的Id都不相同，更新不会影响Id。如果给予的module_id和当前模块的Id不一致，则返回400
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePrivateModuleMetadataRequestBody {\n");
            sb.Append("  moduleDescription: ").Append(ModuleDescription).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePrivateModuleMetadataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePrivateModuleMetadataRequestBody input)
        {
            if (input == null) return false;
            if (this.ModuleDescription != input.ModuleDescription || (this.ModuleDescription != null && !this.ModuleDescription.Equals(input.ModuleDescription))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;

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
                if (this.ModuleDescription != null) hashCode = hashCode * 59 + this.ModuleDescription.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
