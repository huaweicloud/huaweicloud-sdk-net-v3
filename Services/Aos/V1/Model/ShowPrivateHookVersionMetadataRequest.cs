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
    /// Request Object
    /// </summary>
    public class ShowPrivateHookVersionMetadataRequest 
    {

        /// <summary>
        /// 用户指定的，对于此请求的唯一Id，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 私有hook的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [SDKProperty("hook_name", IsPath = true)]
        [JsonProperty("hook_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HookName { get; set; }

        /// <summary>
        /// 私有hook的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义。
        /// </summary>
        [SDKProperty("hook_version", IsPath = true)]
        [JsonProperty("hook_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HookVersion { get; set; }

        /// <summary>
        /// 私有hook（private-hook）的唯一Id。  此Id由资源编排服务在生成私有hook的时候生成，为UUID。  由于私有hook名称仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的私有hook，删除，再重新创建一个同名私有hook。  对于团队并行开发，用户可能希望确保，当前我操作的私有hook就是我认为的那个，而不是其他队友删除后创建的同名私有hook。因此，使用Id就可以做到强匹配。  资源编排服务保证每次创建的私有hook所对应的Id都不相同，更新不会影响Id。如果给予的hook_id和当前hook的Id不一致，则返回400。
        /// </summary>
        [SDKProperty("hook_id", IsQuery = true)]
        [JsonProperty("hook_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HookId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPrivateHookVersionMetadataRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  hookName: ").Append(HookName).Append("\n");
            sb.Append("  hookVersion: ").Append(HookVersion).Append("\n");
            sb.Append("  hookId: ").Append(HookId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPrivateHookVersionMetadataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPrivateHookVersionMetadataRequest input)
        {
            if (input == null) return false;
            if (this.ClientRequestId != input.ClientRequestId || (this.ClientRequestId != null && !this.ClientRequestId.Equals(input.ClientRequestId))) return false;
            if (this.HookName != input.HookName || (this.HookName != null && !this.HookName.Equals(input.HookName))) return false;
            if (this.HookVersion != input.HookVersion || (this.HookVersion != null && !this.HookVersion.Equals(input.HookVersion))) return false;
            if (this.HookId != input.HookId || (this.HookId != null && !this.HookId.Equals(input.HookId))) return false;

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
                if (this.ClientRequestId != null) hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.HookName != null) hashCode = hashCode * 59 + this.HookName.GetHashCode();
                if (this.HookVersion != null) hashCode = hashCode * 59 + this.HookVersion.GetHashCode();
                if (this.HookId != null) hashCode = hashCode * 59 + this.HookId.GetHashCode();
                return hashCode;
            }
        }
    }
}
