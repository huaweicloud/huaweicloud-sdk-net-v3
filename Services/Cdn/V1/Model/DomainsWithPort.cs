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
    /// 域名信息。
    /// </summary>
    public class DomainsWithPort 
    {
        /// <summary>
        /// 华为云CDN提供的加速服务范围，包含：mainland_china中国大陆、outside_mainland_china中国大陆境外、global全球。
        /// </summary>
        /// <value>华为云CDN提供的加速服务范围，包含：mainland_china中国大陆、outside_mainland_china中国大陆境外、global全球。</value>
        [JsonConverter(typeof(EnumClassConverter<ServiceAreaEnum>))]
        public class ServiceAreaEnum
        {
            /// <summary>
            /// Enum MAINLAND_CHINA for value: mainland_china
            /// </summary>
            public static readonly ServiceAreaEnum MAINLAND_CHINA = new ServiceAreaEnum("mainland_china");

            /// <summary>
            /// Enum OUTSIDE_MAINLAND_CHINA for value: outside_mainland_china
            /// </summary>
            public static readonly ServiceAreaEnum OUTSIDE_MAINLAND_CHINA = new ServiceAreaEnum("outside_mainland_china");

            /// <summary>
            /// Enum GLOBAL for value: global
            /// </summary>
            public static readonly ServiceAreaEnum GLOBAL = new ServiceAreaEnum("global");

            private static readonly Dictionary<string, ServiceAreaEnum> StaticFields =
            new Dictionary<string, ServiceAreaEnum>()
            {
                { "mainland_china", MAINLAND_CHINA },
                { "outside_mainland_china", OUTSIDE_MAINLAND_CHINA },
                { "global", GLOBAL },
            };

            private string _value;

            public ServiceAreaEnum()
            {

            }

            public ServiceAreaEnum(string value)
            {
                _value = value;
            }

            public static ServiceAreaEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ServiceAreaEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServiceAreaEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServiceAreaEnum a, ServiceAreaEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ServiceAreaEnum a, ServiceAreaEnum b)
            {
                return !(a == b);
            }
        }


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
        /// 域名业务类型，若为web，则表示类型为网站加速；若为download，则表示业务类型为文件下载加速；若为video，则表示业务类型为点播加速；若为wholeSite，则表示类型为全站加速。
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

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
        /// 源站配置。
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourceWithPort> Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain_origin_host", NullValueHandling = NullValueHandling.Ignore)]
        public DomainOriginHost DomainOriginHost { get; set; }

        /// <summary>
        /// 是否开启HTTPS加速。 0：代表未开启HTTPS加速； 1：代表开启HTTPS加速，且回源方式为协议跟随； 2：代表开启HTTPS加速，且回源方式为HTTP； 3：代表开启HTTPS加速，且回源方式为HTTPS。
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
        /// 自动刷新预热（0代表关闭；1代表打开）。
        /// </summary>
        [JsonProperty("auto_refresh_preheat", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoRefreshPreheat { get; set; }

        /// <summary>
        /// 华为云CDN提供的加速服务范围，包含：mainland_china中国大陆、outside_mainland_china中国大陆境外、global全球。
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        /// <summary>
        /// Range回源状态（off代表关闭 on代表开启）。
        /// </summary>
        [JsonProperty("range_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RangeStatus { get; set; }

        /// <summary>
        /// 回源跟随状态（off代表关闭 on代表开启）。
        /// </summary>
        [JsonProperty("follow_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowStatus { get; set; }

        /// <summary>
        /// 是否暂停源站回源（off代表关闭 on代表开启）。
        /// </summary>
        [JsonProperty("origin_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginStatus { get; set; }

        /// <summary>
        /// 域名禁用原因。 1：该域名涉嫌违规内容（涉黄/涉赌/涉毒/涉政）已被禁用； 2：该域名因备案失效已被禁用； 3：该域名遭受攻击，已被禁用； 150：该域名涉嫌违规内容涉黄已被禁用； 151：该域名涉嫌违规内容涉政已被禁用； 152：该域名涉嫌违规内容涉暴已被禁用； 153：该域名涉嫌违规内容涉赌已被禁用。
        /// </summary>
        [JsonProperty("banned_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string BannedReason { get; set; }

        /// <summary>
        /// 域名锁定原因（Changing the config, please wait）。
        /// </summary>
        [JsonProperty("locked_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string LockedReason { get; set; }

        /// <summary>
        /// 当用户开启企业项目功能时，该参数生效，表示查询资源所属项目，不传表示查询默认项目。注意：当使用子帐号调用接口时，该参数必传。  您可以通过调用企业项目管理服务（EPS）的查询企业项目列表接口（ListEnterpriseProject）查询企业项目id。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainsWithPort {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
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
            sb.Append("  autoRefreshPreheat: ").Append(AutoRefreshPreheat).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  rangeStatus: ").Append(RangeStatus).Append("\n");
            sb.Append("  followStatus: ").Append(FollowStatus).Append("\n");
            sb.Append("  originStatus: ").Append(OriginStatus).Append("\n");
            sb.Append("  bannedReason: ").Append(BannedReason).Append("\n");
            sb.Append("  lockedReason: ").Append(LockedReason).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainsWithPort);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainsWithPort input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.UserDomainId != input.UserDomainId || (this.UserDomainId != null && !this.UserDomainId.Equals(input.UserDomainId))) return false;
            if (this.DomainStatus != input.DomainStatus || (this.DomainStatus != null && !this.DomainStatus.Equals(input.DomainStatus))) return false;
            if (this.Cname != input.Cname || (this.Cname != null && !this.Cname.Equals(input.Cname))) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.DomainOriginHost != input.DomainOriginHost || (this.DomainOriginHost != null && !this.DomainOriginHost.Equals(input.DomainOriginHost))) return false;
            if (this.HttpsStatus != input.HttpsStatus || (this.HttpsStatus != null && !this.HttpsStatus.Equals(input.HttpsStatus))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ModifyTime != input.ModifyTime || (this.ModifyTime != null && !this.ModifyTime.Equals(input.ModifyTime))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.Locked != input.Locked || (this.Locked != null && !this.Locked.Equals(input.Locked))) return false;
            if (this.AutoRefreshPreheat != input.AutoRefreshPreheat || (this.AutoRefreshPreheat != null && !this.AutoRefreshPreheat.Equals(input.AutoRefreshPreheat))) return false;
            if (this.ServiceArea != input.ServiceArea) return false;
            if (this.RangeStatus != input.RangeStatus || (this.RangeStatus != null && !this.RangeStatus.Equals(input.RangeStatus))) return false;
            if (this.FollowStatus != input.FollowStatus || (this.FollowStatus != null && !this.FollowStatus.Equals(input.FollowStatus))) return false;
            if (this.OriginStatus != input.OriginStatus || (this.OriginStatus != null && !this.OriginStatus.Equals(input.OriginStatus))) return false;
            if (this.BannedReason != input.BannedReason || (this.BannedReason != null && !this.BannedReason.Equals(input.BannedReason))) return false;
            if (this.LockedReason != input.LockedReason || (this.LockedReason != null && !this.LockedReason.Equals(input.LockedReason))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.UserDomainId != null) hashCode = hashCode * 59 + this.UserDomainId.GetHashCode();
                if (this.DomainStatus != null) hashCode = hashCode * 59 + this.DomainStatus.GetHashCode();
                if (this.Cname != null) hashCode = hashCode * 59 + this.Cname.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.DomainOriginHost != null) hashCode = hashCode * 59 + this.DomainOriginHost.GetHashCode();
                if (this.HttpsStatus != null) hashCode = hashCode * 59 + this.HttpsStatus.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ModifyTime != null) hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Locked != null) hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.AutoRefreshPreheat != null) hashCode = hashCode * 59 + this.AutoRefreshPreheat.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.RangeStatus != null) hashCode = hashCode * 59 + this.RangeStatus.GetHashCode();
                if (this.FollowStatus != null) hashCode = hashCode * 59 + this.FollowStatus.GetHashCode();
                if (this.OriginStatus != null) hashCode = hashCode * 59 + this.OriginStatus.GetHashCode();
                if (this.BannedReason != null) hashCode = hashCode * 59 + this.BannedReason.GetHashCode();
                if (this.LockedReason != null) hashCode = hashCode * 59 + this.LockedReason.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
