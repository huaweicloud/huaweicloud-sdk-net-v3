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
    public class PrivateProviderSummary 
    {

        /// <summary>
        /// 私有provider（private-provider）的唯一Id。  此Id由资源编排服务在生成provider的时候生成，为UUID。  由于私有provider名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的私有provider，删除，再重新创建一个同名私有provider。  对于团队并行开发，用户可能希望确保，当前我操作的私有provider就是我以为的那个，而不是其他队友删除后创建的同名私有provider。因此，使用Id就可以做到强匹配。  资源编排服务保证每次创建的私有provider所对应的Id都不相同，更新不会影响Id。如果给予的provider_id和当前provider的Id不一致，则返回400
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

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
        /// 用户使用私有provider，在Terraform模板中定义required_providers信息时，需要指明的source参数。  该参数按照“huawei.com/private-provider/{provider_name}”的形式拼接。关于provider_name和provider_source字段在模板中的使用细节，详见创建私有Provider的API描述。
        /// </summary>
        [JsonProperty("provider_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderSource { get; set; }

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
        /// 私有provider（private-provider）的生成时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 私有provider（private-provider）的更新时间，格式为YYYY-MM-DDTHH:mm:ss.SSSZ，精确到毫秒，UTC时区，即，如1970-01-01T00:00:00.000Z。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateProviderSummary {\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  providerDescription: ").Append(ProviderDescription).Append("\n");
            sb.Append("  providerSource: ").Append(ProviderSource).Append("\n");
            sb.Append("  providerAgencyUrn: ").Append(ProviderAgencyUrn).Append("\n");
            sb.Append("  providerAgencyName: ").Append(ProviderAgencyName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateProviderSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateProviderSummary input)
        {
            if (input == null) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.ProviderName != input.ProviderName || (this.ProviderName != null && !this.ProviderName.Equals(input.ProviderName))) return false;
            if (this.ProviderDescription != input.ProviderDescription || (this.ProviderDescription != null && !this.ProviderDescription.Equals(input.ProviderDescription))) return false;
            if (this.ProviderSource != input.ProviderSource || (this.ProviderSource != null && !this.ProviderSource.Equals(input.ProviderSource))) return false;
            if (this.ProviderAgencyUrn != input.ProviderAgencyUrn || (this.ProviderAgencyUrn != null && !this.ProviderAgencyUrn.Equals(input.ProviderAgencyUrn))) return false;
            if (this.ProviderAgencyName != input.ProviderAgencyName || (this.ProviderAgencyName != null && !this.ProviderAgencyName.Equals(input.ProviderAgencyName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.ProviderName != null) hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.ProviderDescription != null) hashCode = hashCode * 59 + this.ProviderDescription.GetHashCode();
                if (this.ProviderSource != null) hashCode = hashCode * 59 + this.ProviderSource.GetHashCode();
                if (this.ProviderAgencyUrn != null) hashCode = hashCode * 59 + this.ProviderAgencyUrn.GetHashCode();
                if (this.ProviderAgencyName != null) hashCode = hashCode * 59 + this.ProviderAgencyName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
