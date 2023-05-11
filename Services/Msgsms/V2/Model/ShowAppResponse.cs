using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAppResponse : SdkResponse
    {

        /// <summary>
        /// 应用主键ID，用于获取、修改应用的唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 创建时间[yyyy-MM-dd HH:mm:ss]
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间[yyyy-MM-dd HH:mm:ss]
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 租户customer id
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 租户resource id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 租户开发者账号
        /// </summary>
        [JsonProperty("developer_account", NullValueHandling = NullValueHandling.Ignore)]
        public string DeveloperAccount { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// omp应用名称
        /// </summary>
        [JsonProperty("omp_app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OmpAppName { get; set; }

        /// <summary>
        /// 应用key
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 上行短信地址
        /// </summary>
        [JsonProperty("up_link_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string UpLinkAddr { get; set; }

        /// <summary>
        /// 应用状态   CREATED：待上线。应用暂未创建成功，请稍候。   SUSPENDED：暂停。无法发起业务请求。当客户所发短信内容触发业务违规，或客户申请退订短信业务时，运营经理会将客户短信应用暂停。   LAUNCHED：正常。应用添加成功，可以正常使用。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 行业类型
        /// </summary>
        [JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)]
        public int? Industry { get; set; }

        /// <summary>
        /// 地域 1. cn：国内 2. intl：国际
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 国际/港澳台短信通道号
        /// </summary>
        [JsonProperty("intl_channel_num", NullValueHandling = NullValueHandling.Ignore)]
        public string IntlChannelNum { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目名称
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// IP白名单
        /// </summary>
        [JsonProperty("ip_white_list", NullValueHandling = NullValueHandling.Ignore)]
        public string IpWhiteList { get; set; }

        /// <summary>
        /// 接入地址
        /// </summary>
        [JsonProperty("app_access_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string AppAccessAddr { get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 平台
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 是否支持多OMP
        /// </summary>
        [JsonProperty("is_support_multiomp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportMultiomp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tenant", NullValueHandling = NullValueHandling.Ignore)]
        public TenantBasic Tenant { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAppResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  developerAccount: ").Append(DeveloperAccount).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  ompAppName: ").Append(OmpAppName).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  upLinkAddr: ").Append(UpLinkAddr).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  industry: ").Append(Industry).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  intlChannelNum: ").Append(IntlChannelNum).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  ipWhiteList: ").Append(IpWhiteList).Append("\n");
            sb.Append("  appAccessAddr: ").Append(AppAccessAddr).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  isSupportMultiomp: ").Append(IsSupportMultiomp).Append("\n");
            sb.Append("  tenant: ").Append(Tenant).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAppResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAppResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.DeveloperAccount == input.DeveloperAccount ||
                    (this.DeveloperAccount != null &&
                    this.DeveloperAccount.Equals(input.DeveloperAccount))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.OmpAppName == input.OmpAppName ||
                    (this.OmpAppName != null &&
                    this.OmpAppName.Equals(input.OmpAppName))
                ) && 
                (
                    this.AppKey == input.AppKey ||
                    (this.AppKey != null &&
                    this.AppKey.Equals(input.AppKey))
                ) && 
                (
                    this.UpLinkAddr == input.UpLinkAddr ||
                    (this.UpLinkAddr != null &&
                    this.UpLinkAddr.Equals(input.UpLinkAddr))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.IntlChannelNum == input.IntlChannelNum ||
                    (this.IntlChannelNum != null &&
                    this.IntlChannelNum.Equals(input.IntlChannelNum))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.EnterpriseProjectName == input.EnterpriseProjectName ||
                    (this.EnterpriseProjectName != null &&
                    this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))
                ) && 
                (
                    this.IpWhiteList == input.IpWhiteList ||
                    (this.IpWhiteList != null &&
                    this.IpWhiteList.Equals(input.IpWhiteList))
                ) && 
                (
                    this.AppAccessAddr == input.AppAccessAddr ||
                    (this.AppAccessAddr != null &&
                    this.AppAccessAddr.Equals(input.AppAccessAddr))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.IsSupportMultiomp == input.IsSupportMultiomp ||
                    (this.IsSupportMultiomp != null &&
                    this.IsSupportMultiomp.Equals(input.IsSupportMultiomp))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.DeveloperAccount != null)
                    hashCode = hashCode * 59 + this.DeveloperAccount.GetHashCode();
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.OmpAppName != null)
                    hashCode = hashCode * 59 + this.OmpAppName.GetHashCode();
                if (this.AppKey != null)
                    hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.UpLinkAddr != null)
                    hashCode = hashCode * 59 + this.UpLinkAddr.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.IntlChannelNum != null)
                    hashCode = hashCode * 59 + this.IntlChannelNum.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.IpWhiteList != null)
                    hashCode = hashCode * 59 + this.IpWhiteList.GetHashCode();
                if (this.AppAccessAddr != null)
                    hashCode = hashCode * 59 + this.AppAccessAddr.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.IsSupportMultiomp != null)
                    hashCode = hashCode * 59 + this.IsSupportMultiomp.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                return hashCode;
            }
        }
    }
}
