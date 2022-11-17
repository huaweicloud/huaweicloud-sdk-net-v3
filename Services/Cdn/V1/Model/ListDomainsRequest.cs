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
    /// Request Object
    /// </summary>
    public class ListDomainsRequest 
    {
        /// <summary>
        /// 加速域名的业务类型。取值： - web（网站加速） - download（文件下载加速） - video（点播加速） - wholeSite（全站加速）
        /// </summary>
        /// <value>加速域名的业务类型。取值： - web（网站加速） - download（文件下载加速） - video（点播加速） - wholeSite（全站加速）</value>
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

            private string Value;

            public BusinessTypeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(BusinessTypeEnum a, BusinessTypeEnum b)
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

            public static bool operator !=(BusinessTypeEnum a, BusinessTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 加速域名状态。取值意义： - online表示“已开启” - offline表示“已停用” - configuring表示“配置中” - configure_failed表示“配置失败” - checking表示“审核中” - check_failed表示“审核未通过” - deleting表示“删除中”。
        /// </summary>
        /// <value>加速域名状态。取值意义： - online表示“已开启” - offline表示“已停用” - configuring表示“配置中” - configure_failed表示“配置失败” - checking表示“审核中” - check_failed表示“审核未通过” - deleting表示“删除中”。</value>
        [JsonConverter(typeof(EnumClassConverter<DomainStatusEnum>))]
        public class DomainStatusEnum
        {
            /// <summary>
            /// Enum ONLINE for value: online
            /// </summary>
            public static readonly DomainStatusEnum ONLINE = new DomainStatusEnum("online");

            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly DomainStatusEnum OFFLINE = new DomainStatusEnum("offline");

            /// <summary>
            /// Enum CONFIGURING for value: configuring
            /// </summary>
            public static readonly DomainStatusEnum CONFIGURING = new DomainStatusEnum("configuring");

            /// <summary>
            /// Enum CONFIGURE_FAILED for value: configure_failed
            /// </summary>
            public static readonly DomainStatusEnum CONFIGURE_FAILED = new DomainStatusEnum("configure_failed");

            /// <summary>
            /// Enum CHECKING for value: checking
            /// </summary>
            public static readonly DomainStatusEnum CHECKING = new DomainStatusEnum("checking");

            /// <summary>
            /// Enum CHECK_FAILED for value: check_failed
            /// </summary>
            public static readonly DomainStatusEnum CHECK_FAILED = new DomainStatusEnum("check_failed");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly DomainStatusEnum DELETING = new DomainStatusEnum("deleting");

            private static readonly Dictionary<string, DomainStatusEnum> StaticFields =
            new Dictionary<string, DomainStatusEnum>()
            {
                { "online", ONLINE },
                { "offline", OFFLINE },
                { "configuring", CONFIGURING },
                { "configure_failed", CONFIGURE_FAILED },
                { "checking", CHECKING },
                { "check_failed", CHECK_FAILED },
                { "deleting", DELETING },
            };

            private string Value;

            public DomainStatusEnum(string value)
            {
                Value = value;
            }

            public static DomainStatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as DomainStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DomainStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DomainStatusEnum a, DomainStatusEnum b)
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

            public static bool operator !=(DomainStatusEnum a, DomainStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 华为云CDN提供的加速服务范围，包含： - mainland_china 中国大陆 - outside_mainland_china 中国大陆境外 - global 全球。
        /// </summary>
        /// <value>华为云CDN提供的加速服务范围，包含： - mainland_china 中国大陆 - outside_mainland_china 中国大陆境外 - global 全球。</value>
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

            private string Value;

            public ServiceAreaEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        public BusinessTypeEnum BusinessType { get; set; }
        /// <summary>
        /// 加速域名状态。取值意义： - online表示“已开启” - offline表示“已停用” - configuring表示“配置中” - configure_failed表示“配置失败” - checking表示“审核中” - check_failed表示“审核未通过” - deleting表示“删除中”。
        /// </summary>
        [SDKProperty("domain_status", IsQuery = true)]
        [JsonProperty("domain_status", NullValueHandling = NullValueHandling.Ignore)]
        public DomainStatusEnum DomainStatus { get; set; }
        /// <summary>
        /// 华为云CDN提供的加速服务范围，包含： - mainland_china 中国大陆 - outside_mainland_china 中国大陆境外 - global 全球。
        /// </summary>
        [SDKProperty("service_area", IsQuery = true)]
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        /// <summary>
        /// 每页的数量，取值范围1-10000，不设值时默认值为30。
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 查询的页码。取值范围1-65535，不设值时默认值为1。
        /// </summary>
        [SDKProperty("page_number", IsQuery = true)]
        [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

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
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
