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
    public class UpdatePrivateHookMetadataRequestBody 
    {

        /// <summary>
        /// 私有hook的描述。可用于客户识别创建的私有hook。可通过UpdatePrivateHook API更新私有hook的描述。
        /// </summary>
        [JsonProperty("hook_description", NullValueHandling = NullValueHandling.Ignore)]
        public string HookDescription { get; set; }

        /// <summary>
        /// 私有hook（private-hook）的唯一Id。  此Id由资源编排服务在生成私有hook的时候生成，为UUID。  由于私有hook名称仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的私有hook，删除，再重新创建一个同名私有hook。  对于团队并行开发，用户可能希望确保，当前我操作的私有hook就是我认为的那个，而不是其他队友删除后创建的同名私有hook。因此，使用Id就可以做到强匹配。  资源编排服务保证每次创建的私有hook所对应的Id都不相同，更新不会影响Id。如果给予的hook_id和当前hook的Id不一致，则返回400。
        /// </summary>
        [JsonProperty("hook_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HookId { get; set; }

        /// <summary>
        /// 私有hook的默认版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义。
        /// </summary>
        [JsonProperty("default_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigurationPrimitiveTypeHolderConfiguration Configuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePrivateHookMetadataRequestBody {\n");
            sb.Append("  hookDescription: ").Append(HookDescription).Append("\n");
            sb.Append("  hookId: ").Append(HookId).Append("\n");
            sb.Append("  defaultVersion: ").Append(DefaultVersion).Append("\n");
            sb.Append("  configuration: ").Append(Configuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePrivateHookMetadataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePrivateHookMetadataRequestBody input)
        {
            if (input == null) return false;
            if (this.HookDescription != input.HookDescription || (this.HookDescription != null && !this.HookDescription.Equals(input.HookDescription))) return false;
            if (this.HookId != input.HookId || (this.HookId != null && !this.HookId.Equals(input.HookId))) return false;
            if (this.DefaultVersion != input.DefaultVersion || (this.DefaultVersion != null && !this.DefaultVersion.Equals(input.DefaultVersion))) return false;
            if (this.Configuration != input.Configuration || (this.Configuration != null && !this.Configuration.Equals(input.Configuration))) return false;

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
                if (this.HookDescription != null) hashCode = hashCode * 59 + this.HookDescription.GetHashCode();
                if (this.HookId != null) hashCode = hashCode * 59 + this.HookId.GetHashCode();
                if (this.DefaultVersion != null) hashCode = hashCode * 59 + this.DefaultVersion.GetHashCode();
                if (this.Configuration != null) hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
