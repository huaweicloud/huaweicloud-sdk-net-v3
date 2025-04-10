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
    public class CreatePrivateProviderRequestBody 
    {

        /// <summary>
        /// 私有provider（private-provider）的名称。此名字在domain_id+region下应唯一，可以使用小写英文、数字、中划线。仅支持以小写英文、数字开头结尾。  按照HCL最佳实践，该名称推荐为在模板中定义的provider的本地名称（local_name）。  创建私有Provider（CreatePrivateProvider）API 还会以 “huawei.com/private-provider”为固定前缀，并以“huawei.com/private-provider/{provider_name}”的形式返回provider_source字段。关于provider_name和provider_source字段在模板中的使用细节，详见创建私有Provider的API描述。
        /// </summary>
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 私有provider（private-provider）的描述。可用于客户识别被管理的私有provider。
        /// </summary>
        [JsonProperty("provider_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderDescription { get; set; }

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
        /// FunctionGraph方法的统一资源标识，用于唯一标识的FunctionGraph方法。当前只支持和RFS同region的function_graph_urn，如果给予了关于其他region的，会报错400。  关于该参数的详细解释，请参考官方文档：https://support.huaweicloud.com/api-functiongraph/functiongraph_06_0102.html
        /// </summary>
        [JsonProperty("function_graph_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionGraphUrn { get; set; }

        /// <summary>
        /// 自定义provider所绑定的IAM委托URN，provider_agency_name和provider_agency_urn最多只能提供一个。
        /// </summary>
        [JsonProperty("provider_agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderAgencyUrn { get; set; }

        /// <summary>
        /// 自定义provider所绑定的IAM委托名称，provider_agency_name和provider_agency_urn最多只能提供一个。
        /// </summary>
        [JsonProperty("provider_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderAgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateProviderRequestBody {\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  providerDescription: ").Append(ProviderDescription).Append("\n");
            sb.Append("  providerVersion: ").Append(ProviderVersion).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  functionGraphUrn: ").Append(FunctionGraphUrn).Append("\n");
            sb.Append("  providerAgencyUrn: ").Append(ProviderAgencyUrn).Append("\n");
            sb.Append("  providerAgencyName: ").Append(ProviderAgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateProviderRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateProviderRequestBody input)
        {
            if (input == null) return false;
            if (this.ProviderName != input.ProviderName || (this.ProviderName != null && !this.ProviderName.Equals(input.ProviderName))) return false;
            if (this.ProviderDescription != input.ProviderDescription || (this.ProviderDescription != null && !this.ProviderDescription.Equals(input.ProviderDescription))) return false;
            if (this.ProviderVersion != input.ProviderVersion || (this.ProviderVersion != null && !this.ProviderVersion.Equals(input.ProviderVersion))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.FunctionGraphUrn != input.FunctionGraphUrn || (this.FunctionGraphUrn != null && !this.FunctionGraphUrn.Equals(input.FunctionGraphUrn))) return false;
            if (this.ProviderAgencyUrn != input.ProviderAgencyUrn || (this.ProviderAgencyUrn != null && !this.ProviderAgencyUrn.Equals(input.ProviderAgencyUrn))) return false;
            if (this.ProviderAgencyName != input.ProviderAgencyName || (this.ProviderAgencyName != null && !this.ProviderAgencyName.Equals(input.ProviderAgencyName))) return false;

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
                if (this.ProviderName != null) hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.ProviderDescription != null) hashCode = hashCode * 59 + this.ProviderDescription.GetHashCode();
                if (this.ProviderVersion != null) hashCode = hashCode * 59 + this.ProviderVersion.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.FunctionGraphUrn != null) hashCode = hashCode * 59 + this.FunctionGraphUrn.GetHashCode();
                if (this.ProviderAgencyUrn != null) hashCode = hashCode * 59 + this.ProviderAgencyUrn.GetHashCode();
                if (this.ProviderAgencyName != null) hashCode = hashCode * 59 + this.ProviderAgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
