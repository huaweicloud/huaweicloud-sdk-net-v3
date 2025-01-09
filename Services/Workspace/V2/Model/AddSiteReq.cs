using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 初始化站点请求。
    /// </summary>
    public class AddSiteReq 
    {

        /// <summary>
        /// 站点配置信息。
        /// </summary>
        [JsonProperty("site_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteConfigsRequest> SiteConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddSiteReq {\n");
            sb.Append("  siteConfigs: ").Append(SiteConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddSiteReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddSiteReq input)
        {
            if (input == null) return false;
            if (this.SiteConfigs != input.SiteConfigs || (this.SiteConfigs != null && input.SiteConfigs != null && !this.SiteConfigs.SequenceEqual(input.SiteConfigs))) return false;

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
                if (this.SiteConfigs != null) hashCode = hashCode * 59 + this.SiteConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
