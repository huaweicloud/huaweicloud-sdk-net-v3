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
    public class CreatePrivateProviderVersionRequestBody 
    {

        /// <summary>
        /// 私有provider（private-provider）的唯一Id。  此Id由资源编排服务在生成provider的时候生成，为UUID。  由于私有provider名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的私有provider，删除，再重新创建一个同名私有provider。  对于团队并行开发，用户可能希望确保，当前我操作的私有provider就是我以为的那个，而不是其他队友删除后创建的同名私有provider。因此，使用Id就可以做到强匹配。  资源编排服务保证每次创建的私有provider所对应的Id都不相同，更新不会影响Id。如果给予的provider_id和当前provider的Id不一致，则返回400
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// provider的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义
        /// </summary>
        [JsonProperty("provider_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderVersion { get; set; }

        /// <summary>
        /// 私有provider版本（provider version）的描述。可用于客户识别并管理私有provider的版本。注意：provider版本为不可更新（immutable），所以该字段不可更新，如果需要更新，请删除后重建
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// FunctionGraph方法的统一资源标识，用于标识唯一的FunctionGraph方法。当前只支持和RFS同region的function_graph_urn，如果给予了关于其他region的，会报错400。  关于该参数的详细解释，请参考官方文档：https://support.huaweicloud.com/api-functiongraph/functiongraph_06_0102.html
        /// </summary>
        [JsonProperty("function_graph_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionGraphUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateProviderVersionRequestBody {\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  providerVersion: ").Append(ProviderVersion).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  functionGraphUrn: ").Append(FunctionGraphUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateProviderVersionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateProviderVersionRequestBody input)
        {
            if (input == null) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.ProviderVersion != input.ProviderVersion || (this.ProviderVersion != null && !this.ProviderVersion.Equals(input.ProviderVersion))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.FunctionGraphUrn != input.FunctionGraphUrn || (this.FunctionGraphUrn != null && !this.FunctionGraphUrn.Equals(input.FunctionGraphUrn))) return false;

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
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.ProviderVersion != null) hashCode = hashCode * 59 + this.ProviderVersion.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.FunctionGraphUrn != null) hashCode = hashCode * 59 + this.FunctionGraphUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
