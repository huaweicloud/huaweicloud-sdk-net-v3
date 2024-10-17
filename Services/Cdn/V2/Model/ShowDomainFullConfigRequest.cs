using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDomainFullConfigRequest 
    {

        /// <summary>
        /// 加速域名。
        /// </summary>
        [SDKProperty("domain_name", IsPath = true)]
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 企业项目ID， all：所有项目。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 取值为auth_key，用来查询鉴权KEY和鉴权备KEY的值。
        /// </summary>
        [SDKProperty("show_special_configs", IsQuery = true)]
        [JsonProperty("show_special_configs", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowSpecialConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainFullConfigRequest {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  showSpecialConfigs: ").Append(ShowSpecialConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainFullConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainFullConfigRequest input)
        {
            if (input == null) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ShowSpecialConfigs != input.ShowSpecialConfigs || (this.ShowSpecialConfigs != null && !this.ShowSpecialConfigs.Equals(input.ShowSpecialConfigs))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ShowSpecialConfigs != null) hashCode = hashCode * 59 + this.ShowSpecialConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
