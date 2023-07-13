using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DecoupledLiveDomainInfo 
    {
        /// <summary>
        /// 域名类型
        /// </summary>
        /// <value>域名类型</value>
        [JsonConverter(typeof(EnumClassConverter<DomainTypeEnum>))]
        public class DomainTypeEnum
        {
            /// <summary>
            /// Enum PULL for value: pull
            /// </summary>
            public static readonly DomainTypeEnum PULL = new DomainTypeEnum("pull");

            /// <summary>
            /// Enum PUSH for value: push
            /// </summary>
            public static readonly DomainTypeEnum PUSH = new DomainTypeEnum("push");

            private static readonly Dictionary<string, DomainTypeEnum> StaticFields =
            new Dictionary<string, DomainTypeEnum>()
            {
                { "pull", PULL },
                { "push", PUSH },
            };

            private string _value;

            public DomainTypeEnum()
            {

            }

            public DomainTypeEnum(string value)
            {
                _value = value;
            }

            public static DomainTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DomainTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DomainTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DomainTypeEnum a, DomainTypeEnum b)
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

            public static bool operator !=(DomainTypeEnum a, DomainTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// CDN厂商
        /// </summary>
        /// <value>CDN厂商</value>
        [JsonConverter(typeof(EnumClassConverter<VendorEnum>))]
        public class VendorEnum
        {
            /// <summary>
            /// Enum CHINANETCENTER for value: ChinaNetCenter
            /// </summary>
            public static readonly VendorEnum CHINANETCENTER = new VendorEnum("ChinaNetCenter");

            /// <summary>
            /// Enum KINGSOFT for value: KingSoft
            /// </summary>
            public static readonly VendorEnum KINGSOFT = new VendorEnum("KingSoft");

            /// <summary>
            /// Enum TENCENT for value: Tencent
            /// </summary>
            public static readonly VendorEnum TENCENT = new VendorEnum("Tencent");

            /// <summary>
            /// Enum UCDN for value: uCDN
            /// </summary>
            public static readonly VendorEnum UCDN = new VendorEnum("uCDN");

            /// <summary>
            /// Enum TENCENTOUTSIDE for value: TencentOutside
            /// </summary>
            public static readonly VendorEnum TENCENTOUTSIDE = new VendorEnum("TencentOutside");

            /// <summary>
            /// Enum DNION for value: Dnion
            /// </summary>
            public static readonly VendorEnum DNION = new VendorEnum("Dnion");

            /// <summary>
            /// Enum BAISHAN for value: Baishan
            /// </summary>
            public static readonly VendorEnum BAISHAN = new VendorEnum("Baishan");

            /// <summary>
            /// Enum BAIDU for value: Baidu
            /// </summary>
            public static readonly VendorEnum BAIDU = new VendorEnum("Baidu");

            /// <summary>
            /// Enum ONETHING for value: Onething
            /// </summary>
            public static readonly VendorEnum ONETHING = new VendorEnum("Onething");

            private static readonly Dictionary<string, VendorEnum> StaticFields =
            new Dictionary<string, VendorEnum>()
            {
                { "ChinaNetCenter", CHINANETCENTER },
                { "KingSoft", KINGSOFT },
                { "Tencent", TENCENT },
                { "uCDN", UCDN },
                { "TencentOutside", TENCENTOUTSIDE },
                { "Dnion", DNION },
                { "Baishan", BAISHAN },
                { "Baidu", BAIDU },
                { "Onething", ONETHING },
            };

            private string _value;

            public VendorEnum()
            {

            }

            public VendorEnum(string value)
            {
                _value = value;
            }

            public static VendorEnum FromValue(string value)
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

                if (this.Equals(obj as VendorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VendorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VendorEnum a, VendorEnum b)
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

            public static bool operator !=(VendorEnum a, VendorEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 直播域名的状态
        /// </summary>
        /// <value>直播域名的状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly StatusEnum ON = new StatusEnum("on");

            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly StatusEnum OFF = new StatusEnum("off");

            /// <summary>
            /// Enum CONFIGURING for value: configuring
            /// </summary>
            public static readonly StatusEnum CONFIGURING = new StatusEnum("configuring");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "on", ON },
                { "off", OFF },
                { "configuring", CONFIGURING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 域名应用区域 - mainland_china表示中国大陆区域 - outside_mainland_china表示中国大陆以外区域 
        /// </summary>
        /// <value>域名应用区域 - mainland_china表示中国大陆区域 - outside_mainland_china表示中国大陆以外区域 </value>
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

            private static readonly Dictionary<string, ServiceAreaEnum> StaticFields =
            new Dictionary<string, ServiceAreaEnum>()
            {
                { "mainland_china", MAINLAND_CHINA },
                { "outside_mainland_china", OUTSIDE_MAINLAND_CHINA },
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
        /// 直播域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 域名类型
        /// </summary>
        [JsonProperty("domain_type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainTypeEnum DomainType { get; set; }
        /// <summary>
        /// CDN厂商
        /// </summary>
        [JsonProperty("vendor", NullValueHandling = NullValueHandling.Ignore)]
        public VendorEnum Vendor { get; set; }
        /// <summary>
        /// 直播所属直播中心
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 直播域名的CName
        /// </summary>
        [JsonProperty("domain_cname", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainCname { get; set; }

        /// <summary>
        /// 直播域名的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 播放域名关联的推流域名（只有domain_type为pull的时候有效）
        /// </summary>
        [JsonProperty("related_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedDomain { get; set; }

        /// <summary>
        /// 域名创建时间，格式：yyyy-mm-ddThh:mm:ssZ，UTC时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("status_describe", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusDescribe { get; set; }

        /// <summary>
        /// 域名应用区域 - mainland_china表示中国大陆区域 - outside_mainland_china表示中国大陆以外区域 
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// IPV6开关是否开启，默认关闭，true为开启；false或空为关闭
        /// </summary>
        [JsonProperty("is_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIpv6 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecoupledLiveDomainInfo {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  domainType: ").Append(DomainType).Append("\n");
            sb.Append("  vendor: ").Append(Vendor).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  domainCname: ").Append(DomainCname).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  relatedDomain: ").Append(RelatedDomain).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  statusDescribe: ").Append(StatusDescribe).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  isIpv6: ").Append(IsIpv6).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecoupledLiveDomainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecoupledLiveDomainInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.DomainType == input.DomainType ||
                    (this.DomainType != null &&
                    this.DomainType.Equals(input.DomainType))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.DomainCname == input.DomainCname ||
                    (this.DomainCname != null &&
                    this.DomainCname.Equals(input.DomainCname))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.RelatedDomain == input.RelatedDomain ||
                    (this.RelatedDomain != null &&
                    this.RelatedDomain.Equals(input.RelatedDomain))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.StatusDescribe == input.StatusDescribe ||
                    (this.StatusDescribe != null &&
                    this.StatusDescribe.Equals(input.StatusDescribe))
                ) && 
                (
                    this.ServiceArea == input.ServiceArea ||
                    (this.ServiceArea != null &&
                    this.ServiceArea.Equals(input.ServiceArea))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.IsIpv6 == input.IsIpv6 ||
                    (this.IsIpv6 != null &&
                    this.IsIpv6.Equals(input.IsIpv6))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.DomainType != null)
                    hashCode = hashCode * 59 + this.DomainType.GetHashCode();
                if (this.Vendor != null)
                    hashCode = hashCode * 59 + this.Vendor.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.DomainCname != null)
                    hashCode = hashCode * 59 + this.DomainCname.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RelatedDomain != null)
                    hashCode = hashCode * 59 + this.RelatedDomain.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.StatusDescribe != null)
                    hashCode = hashCode * 59 + this.StatusDescribe.GetHashCode();
                if (this.ServiceArea != null)
                    hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsIpv6 != null)
                    hashCode = hashCode * 59 + this.IsIpv6.GetHashCode();
                return hashCode;
            }
        }
    }
}
