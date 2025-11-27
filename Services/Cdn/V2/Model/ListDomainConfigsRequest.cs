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
    public class ListDomainConfigsRequest 
    {

        /// <summary>
        /// **参数解释：** 加速域名  - 多个域名使用英文半角逗号分隔  - 当查询cname状态时，该参数必传  **约束限制：** 仅支持查询已经在CDN添加成功的域名 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("domain_names", IsQuery = true)]
        [JsonProperty("domain_names", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainNames { get; set; }

        /// <summary>
        /// **参数解释：** 查询数据类型 **约束限制：** 不涉及 **取值范围：** - cname_status: 域名cname状态 - copy: 查询账号下哪些加速域名支持复制配置  **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("item", IsQuery = true)]
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>
        /// **参数解释：** 企业项目id。您可以通过调用企业项目管理服务（EPS）的查询企业项目列表接口（ListEnterpriseProject）查询企业项目id **约束限制：** 当用户开启企业项目功能时，该参数生效，表示查询资源所属项目，\&quot;all\&quot;表示所有项目 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainConfigsRequest {\n");
            sb.Append("  domainNames: ").Append(DomainNames).Append("\n");
            sb.Append("  item: ").Append(Item).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainConfigsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainConfigsRequest input)
        {
            if (input == null) return false;
            if (this.DomainNames != input.DomainNames || (this.DomainNames != null && !this.DomainNames.Equals(input.DomainNames))) return false;
            if (this.Item != input.Item || (this.Item != null && !this.Item.Equals(input.Item))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.DomainNames != null) hashCode = hashCode * 59 + this.DomainNames.GetHashCode();
                if (this.Item != null) hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
