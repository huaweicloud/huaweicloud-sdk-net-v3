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
    /// 委托授权的信息
    /// </summary>
    public class Agency 
    {

        /// <summary>
        /// 用户使用的provider的名字。如果用户给予的provider_name含有重复的值，则返回400
        /// </summary>
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 对应provider所使用的IAM委托名称，资源编排服务会使用此委托的权限去访问、创建对应provider的资源。agency_name和agency_urn必须有且只有一个存在
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 委托URN  当用户定义Agency时，agency_name和agency_urn 必须有且只有一个存在。  推荐用户在使用信任委托时给予agency_urn，agency_name只支持接收普通委托名称，如果给予了信任委托名称，则会在部署模板时失败。
        /// </summary>
        [JsonProperty("agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Agency {\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  agencyUrn: ").Append(AgencyUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Agency);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Agency input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.AgencyName == input.AgencyName ||
                    (this.AgencyName != null &&
                    this.AgencyName.Equals(input.AgencyName))
                ) && 
                (
                    this.AgencyUrn == input.AgencyUrn ||
                    (this.AgencyUrn != null &&
                    this.AgencyUrn.Equals(input.AgencyUrn))
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
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.AgencyName != null)
                    hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.AgencyUrn != null)
                    hashCode = hashCode * 59 + this.AgencyUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
