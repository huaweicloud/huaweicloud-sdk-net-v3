using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 创建域名返回信息
    /// </summary>
    public class CreateDomainResponseBodyContent 
    {

        /// <summary>
        /// 加速域名ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 加速域名。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 域名业务类型： - web:网站加速； - download:文件下载加速； - video:点播加速； - wholeSite:全站加速。
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 域名服务范围，若为mainland_china，则表示服务范围为中国大陆；若为outside_mainland_china，则表示服务范围为中国大陆境外；若为global，则表示服务范围为全球。
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// 域名所属用户的domain_id。
        /// </summary>
        [JsonProperty("user_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDomainId { get; set; }

        /// <summary>
        /// 加速域名状态。取值意义： - online表示“已开启” - offline表示“已停用” - configuring表示“配置中” - configure_failed表示“配置失败” - checking表示“审核中” - check_failed表示“审核未通过” - deleting表示“删除中”。
        /// </summary>
        [JsonProperty("domain_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// 加速域名对应的CNAME。
        /// </summary>
        [JsonProperty("cname", NullValueHandling = NullValueHandling.Ignore)]
        public string Cname { get; set; }

        /// <summary>
        /// 源站信息
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Sources> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain_origin_host", NullValueHandling = NullValueHandling.Ignore)]
        public DomainOriginHost DomainOriginHost { get; set; }

        /// <summary>
        /// 是否开启HTTPS加速。
        /// </summary>
        [JsonProperty("https_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsStatus { get; set; }

        /// <summary>
        /// 域名创建时间，相对于UTC 1970-01-01到当前时间相隔的毫秒数。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 域名修改时间，相对于UTC 1970-01-01到当前时间相隔的毫秒数。
        /// </summary>
        [JsonProperty("modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// 封禁状态（0代表未禁用；1代表禁用）。
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? Disabled { get; set; }

        /// <summary>
        /// 锁定状态（0代表未锁定；1代表锁定）。
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public int? Locked { get; set; }

        /// <summary>
        /// range状态（\&quot;off\&quot;/\&quot;on\&quot;）。
        /// </summary>
        [JsonProperty("range_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RangeStatus { get; set; }

        /// <summary>
        /// follow302状态（\&quot;off\&quot;/\&quot;on\&quot;）。
        /// </summary>
        [JsonProperty("follow_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowStatus { get; set; }

        /// <summary>
        /// 是否暂停源站回源。
        /// </summary>
        [JsonProperty("origin_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginStatus { get; set; }

        /// <summary>
        /// 自动刷新预热（0代表关闭；1代表打开）
        /// </summary>
        [JsonProperty("auto_refresh_preheat", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoRefreshPreheat { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDomainResponseBodyContent {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  userDomainId: ").Append(UserDomainId).Append("\n");
            sb.Append("  domainStatus: ").Append(DomainStatus).Append("\n");
            sb.Append("  cname: ").Append(Cname).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  domainOriginHost: ").Append(DomainOriginHost).Append("\n");
            sb.Append("  httpsStatus: ").Append(HttpsStatus).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  modifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  rangeStatus: ").Append(RangeStatus).Append("\n");
            sb.Append("  followStatus: ").Append(FollowStatus).Append("\n");
            sb.Append("  originStatus: ").Append(OriginStatus).Append("\n");
            sb.Append("  autoRefreshPreheat: ").Append(AutoRefreshPreheat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDomainResponseBodyContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDomainResponseBodyContent input)
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
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                ) && 
                (
                    this.UserDomainId == input.UserDomainId ||
                    (this.UserDomainId != null &&
                    this.UserDomainId.Equals(input.UserDomainId))
                ) && 
                (
                    this.DomainStatus == input.DomainStatus ||
                    (this.DomainStatus != null &&
                    this.DomainStatus.Equals(input.DomainStatus))
                ) && 
                (
                    this.Cname == input.Cname ||
                    (this.Cname != null &&
                    this.Cname.Equals(input.Cname))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.DomainOriginHost == input.DomainOriginHost ||
                    (this.DomainOriginHost != null &&
                    this.DomainOriginHost.Equals(input.DomainOriginHost))
                ) && 
                (
                    this.HttpsStatus == input.HttpsStatus ||
                    (this.HttpsStatus != null &&
                    this.HttpsStatus.Equals(input.HttpsStatus))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.ModifyTime == input.ModifyTime ||
                    (this.ModifyTime != null &&
                    this.ModifyTime.Equals(input.ModifyTime))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.RangeStatus == input.RangeStatus ||
                    (this.RangeStatus != null &&
                    this.RangeStatus.Equals(input.RangeStatus))
                ) && 
                (
                    this.FollowStatus == input.FollowStatus ||
                    (this.FollowStatus != null &&
                    this.FollowStatus.Equals(input.FollowStatus))
                ) && 
                (
                    this.OriginStatus == input.OriginStatus ||
                    (this.OriginStatus != null &&
                    this.OriginStatus.Equals(input.OriginStatus))
                ) && 
                (
                    this.AutoRefreshPreheat == input.AutoRefreshPreheat ||
                    (this.AutoRefreshPreheat != null &&
                    this.AutoRefreshPreheat.Equals(input.AutoRefreshPreheat))
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
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.BusinessType != null)
                    hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.UserDomainId != null)
                    hashCode = hashCode * 59 + this.UserDomainId.GetHashCode();
                if (this.DomainStatus != null)
                    hashCode = hashCode * 59 + this.DomainStatus.GetHashCode();
                if (this.Cname != null)
                    hashCode = hashCode * 59 + this.Cname.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.DomainOriginHost != null)
                    hashCode = hashCode * 59 + this.DomainOriginHost.GetHashCode();
                if (this.HttpsStatus != null)
                    hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ModifyTime != null)
                    hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.RangeStatus != null)
                    hashCode = hashCode * 59 + this.RangeStatus.GetHashCode();
                if (this.FollowStatus != null)
                    hashCode = hashCode * 59 + this.FollowStatus.GetHashCode();
                if (this.OriginStatus != null)
                    hashCode = hashCode * 59 + this.OriginStatus.GetHashCode();
                if (this.AutoRefreshPreheat != null)
                    hashCode = hashCode * 59 + this.AutoRefreshPreheat.GetHashCode();
                return hashCode;
            }
        }
    }
}
