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
    /// **参数解释：** 创建域名请求体，包含创建域名所需参数 **约束限制：** 不涉及
    /// </summary>
    public class DomainBody 
    {
        /// <summary>
        /// **参数解释：** 域名业务类型 **约束限制：** 不涉及 **取值范围：** - web: 网页加速 - download: 文件下载加速 - video: 点播加速 - wholeSite: 全站加速  **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 域名业务类型 **约束限制：** 不涉及 **取值范围：** - web: 网页加速 - download: 文件下载加速 - video: 点播加速 - wholeSite: 全站加速  **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<BusinessTypeEnum>))]
        public class BusinessTypeEnum
        {
            /// <summary>
            /// Enum WEB for value: web
            /// </summary>
            public static readonly BusinessTypeEnum WEB = new BusinessTypeEnum("web");

            /// <summary>
            /// Enum DOWNLOAD for value: download
            /// </summary>
            public static readonly BusinessTypeEnum DOWNLOAD = new BusinessTypeEnum("download");

            /// <summary>
            /// Enum VIDEO for value: video
            /// </summary>
            public static readonly BusinessTypeEnum VIDEO = new BusinessTypeEnum("video");

            /// <summary>
            /// Enum WHOLESITE for value: wholeSite
            /// </summary>
            public static readonly BusinessTypeEnum WHOLESITE = new BusinessTypeEnum("wholeSite");

            private static readonly Dictionary<string, BusinessTypeEnum> StaticFields =
            new Dictionary<string, BusinessTypeEnum>()
            {
                { "web", WEB },
                { "download", DOWNLOAD },
                { "video", VIDEO },
                { "wholeSite", WHOLESITE },
            };

            private string _value;

            public BusinessTypeEnum()
            {

            }

            public BusinessTypeEnum(string value)
            {
                _value = value;
            }

            public static BusinessTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BusinessTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BusinessTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BusinessTypeEnum a, BusinessTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(BusinessTypeEnum a, BusinessTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 域名服务范围 **约束限制：** 服务范围为中国大陆或全球时，加速域名需要到工信部备案 **取值范围：** - mainland_china: 中国大陆 - outside_mainland_china: 中国大陆境外 - global: 全球  **默认取值：** mainland_china: 中国大陆
        /// </summary>
        /// <value>**参数解释：** 域名服务范围 **约束限制：** 服务范围为中国大陆或全球时，加速域名需要到工信部备案 **取值范围：** - mainland_china: 中国大陆 - outside_mainland_china: 中国大陆境外 - global: 全球  **默认取值：** mainland_china: 中国大陆</value>
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
                if (ReferenceEquals(a, b))
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
        /// **参数解释：** 加速域名 &gt; 添加泛域名后，该泛域名所有次级域名默认支持CDN加速  **约束限制：** 加速域名不允许重复添加 **取值范围：** - 域名长度不能超过200个字符 - 支持大小写字母、数字、\&quot;-\&quot;、\&quot;.\&quot;，首尾字符不能是\&quot;-\&quot;或\&quot;.\&quot; - 泛域名场景下支持\&quot;\\*\&quot;，且\&quot;\\*必须为首字符 - 域名单节点长度不超过63个字符，即：\\*\\*\\*.\\*\\*\\*.com中，\\*\\*\\*的字符数不超过63个字符  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数解释：** 域名业务类型 **约束限制：** 不涉及 **取值范围：** - web: 网页加速 - download: 文件下载加速 - video: 点播加速 - wholeSite: 全站加速  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessTypeEnum BusinessType { get; set; }
        /// <summary>
        /// **参数解释：** 源站配置 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourcesRequestBody> Sources { get; set; }

        /// <summary>
        /// **参数解释：** 域名服务范围 **约束限制：** 服务范围为中国大陆或全球时，加速域名需要到工信部备案 **取值范围：** - mainland_china: 中国大陆 - outside_mainland_china: 中国大陆境外 - global: 全球  **默认取值：** mainland_china: 中国大陆
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        /// <summary>
        /// **参数解释：** 企业项目id。您可以通过调用企业项目管理服务（EPS）的查询企业项目列表接口（ListEnterpriseProject）查询企业项目id **约束限制：** 当用户开启企业项目功能时，该参数生效，表示查询资源所属项目，\&quot;all\&quot;表示所有项目  **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 指定CDN回源时的请求协议 **约束限制：** 不涉及 **取值范围：** - follow: 协议跟随 - http: http协议 - https: https协议  **默认取值：** http: http协议
        /// </summary>
        [JsonProperty("origin_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginProtocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("configs", NullValueHandling = NullValueHandling.Ignore)]
        public CreateDomainConfigs Configs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainBody {\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  originProtocol: ").Append(OriginProtocol).Append("\n");
            sb.Append("  configs: ").Append(Configs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainBody input)
        {
            if (input == null) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.BusinessType != input.BusinessType) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.ServiceArea != input.ServiceArea) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.OriginProtocol != input.OriginProtocol || (this.OriginProtocol != null && !this.OriginProtocol.Equals(input.OriginProtocol))) return false;
            if (this.Configs != input.Configs || (this.Configs != null && !this.Configs.Equals(input.Configs))) return false;

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
                hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.OriginProtocol != null) hashCode = hashCode * 59 + this.OriginProtocol.GetHashCode();
                if (this.Configs != null) hashCode = hashCode * 59 + this.Configs.GetHashCode();
                return hashCode;
            }
        }
    }
}
