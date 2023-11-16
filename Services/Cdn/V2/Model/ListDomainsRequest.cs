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
    public class ListDomainsRequest 
    {

        /// <summary>
        /// 加速域名，采用模糊匹配的方式。（长度限制为1-255字符）。
        /// </summary>
        [SDKProperty("domain_name", IsQuery = true)]
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 加速域名的业务类型。取值： - web（网站加速） - download（文件下载加速） - video（点播加速） - wholeSite（全站加速）
        /// </summary>
        [SDKProperty("business_type", IsQuery = true)]
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 加速域名状态。取值意义： - online表示“已开启” - offline表示“已停用” - configuring表示“配置中” - configure_failed表示“配置失败” - checking表示“审核中” - check_failed表示“审核未通过” - deleting表示“删除中”。
        /// </summary>
        [SDKProperty("domain_status", IsQuery = true)]
        [JsonProperty("domain_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// 华为云CDN提供的加速服务范围，包含： - mainland_china 中国大陆 - outside_mainland_china 中国大陆境外 - global 全球。
        /// </summary>
        [SDKProperty("service_area", IsQuery = true)]
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// 每页加速域名的数量，取值范围1-10000，默认值为30。
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 查询的页码，即：从哪一页开始查询，取值范围1-65535，默认值为1。
        /// </summary>
        [SDKProperty("page_number", IsQuery = true)]
        [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 展示标签标识 true：不展示 false：展示。
        /// </summary>
        [SDKProperty("show_tags", IsQuery = true)]
        [JsonProperty("show_tags", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTags { get; set; }

        /// <summary>
        /// 精准匹配 true：开启 false：关闭。
        /// </summary>
        [SDKProperty("exact_match", IsQuery = true)]
        [JsonProperty("exact_match", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExactMatch { get; set; }

        /// <summary>
        /// 当用户开启企业项目功能时，该参数生效，表示查询资源所属项目，\&quot;all\&quot;表示所有项目。注意：当使用子帐号调用接口时，该参数必传。  您可以通过调用企业项目管理服务（EPS）的查询企业项目列表接口（ListEnterpriseProject）查询企业项目id。
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
            sb.Append("class ListDomainsRequest {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  domainStatus: ").Append(DomainStatus).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  showTags: ").Append(ShowTags).Append("\n");
            sb.Append("  exactMatch: ").Append(ExactMatch).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
                ) && 
                (
                    this.DomainStatus == input.DomainStatus ||
                    (this.DomainStatus != null &&
                    this.DomainStatus.Equals(input.DomainStatus))
                ) && 
                (
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.ShowTags == input.ShowTags ||
                    (this.ShowTags != null &&
                    this.ShowTags.Equals(input.ShowTags))
                ) && 
                (
                    this.ExactMatch == input.ExactMatch ||
                    (this.ExactMatch != null &&
                    this.ExactMatch.Equals(input.ExactMatch))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.BusinessType != null)
                    hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.DomainStatus != null)
                    hashCode = hashCode * 59 + this.DomainStatus.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.ShowTags != null)
                    hashCode = hashCode * 59 + this.ShowTags.GetHashCode();
                if (this.ExactMatch != null)
                    hashCode = hashCode * 59 + this.ExactMatch.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
