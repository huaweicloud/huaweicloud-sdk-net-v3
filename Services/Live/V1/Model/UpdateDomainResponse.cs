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
    /// Response Object
    /// </summary>
    public class UpdateDomainResponse : SdkResponse
    {
        /// <summary>
        /// 域名类型 - pull表示播放域名 - push表示推流域名 
        /// </summary>
        /// <value>域名类型 - pull表示播放域名 - push表示推流域名 </value>
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

            /// <summary>
            /// Enum DISABLE for value: disable
            /// </summary>
            public static readonly StatusEnum DISABLE = new StatusEnum("disable");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "on", ON },
                { "off", OFF },
                { "configuring", CONFIGURING },
                { "disable", DISABLE },
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
        /// 域名应用区域 - mainland_china表示中国大陆区域 - outside_mainland_china表示中国大陆以外区域 - global表示全球加速区域 
        /// </summary>
        /// <value>域名应用区域 - mainland_china表示中国大陆区域 - outside_mainland_china表示中国大陆以外区域 - global表示全球加速区域 </value>
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
        /// 域名支持的拉流协议；仅domain_type为pull时生效。若不填写此字段，视为默认支持FLV、RTMP拉流协议 - flv_rtmp表示支持FLV、RTMP协议 - hls表示支持HLS协议 
        /// </summary>
        /// <value>域名支持的拉流协议；仅domain_type为pull时生效。若不填写此字段，视为默认支持FLV、RTMP拉流协议 - flv_rtmp表示支持FLV、RTMP协议 - hls表示支持HLS协议 </value>
        [JsonConverter(typeof(EnumClassConverter<PullProtocolEnum>))]
        public class PullProtocolEnum
        {
            /// <summary>
            /// Enum FLV_RTMP for value: flv_rtmp
            /// </summary>
            public static readonly PullProtocolEnum FLV_RTMP = new PullProtocolEnum("flv_rtmp");

            /// <summary>
            /// Enum HLS for value: hls
            /// </summary>
            public static readonly PullProtocolEnum HLS = new PullProtocolEnum("hls");

            private static readonly Dictionary<string, PullProtocolEnum> StaticFields =
            new Dictionary<string, PullProtocolEnum>()
            {
                { "flv_rtmp", FLV_RTMP },
                { "hls", HLS },
            };

            private string _value;

            public PullProtocolEnum()
            {

            }

            public PullProtocolEnum(string value)
            {
                _value = value;
            }

            public static PullProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as PullProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PullProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PullProtocolEnum a, PullProtocolEnum b)
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

            public static bool operator !=(PullProtocolEnum a, PullProtocolEnum b)
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
        /// 域名类型 - pull表示播放域名 - push表示推流域名 
        /// </summary>
        [JsonProperty("domain_type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainTypeEnum DomainType { get; set; }
        /// <summary>
        /// 直播域名的CNAME
        /// </summary>
        [JsonProperty("domain_cname", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainCname { get; set; }

        /// <summary>
        /// 直播所属直播中心
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 直播域名的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
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
        /// 域名应用区域 - mainland_china表示中国大陆区域 - outside_mainland_china表示中国大陆以外区域 - global表示全球加速区域 
        /// </summary>
        [JsonProperty("service_area", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceAreaEnum ServiceArea { get; set; }
        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 域名支持的拉流协议；仅domain_type为pull时生效。若不填写此字段，视为默认支持FLV、RTMP拉流协议 - flv_rtmp表示支持FLV、RTMP协议 - hls表示支持HLS协议 
        /// </summary>
        [JsonProperty("pull_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public PullProtocolEnum PullProtocol { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainResponse {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  domainType: ").Append(DomainType).Append("\n");
            sb.Append("  domainCname: ").Append(DomainCname).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  statusDescribe: ").Append(StatusDescribe).Append("\n");
            sb.Append("  serviceArea: ").Append(ServiceArea).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  pullProtocol: ").Append(PullProtocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainResponse input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.DomainType != input.DomainType) return false;
            if (this.DomainCname != input.DomainCname || (this.DomainCname != null && !this.DomainCname.Equals(input.DomainCname))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Status != input.Status) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.StatusDescribe != input.StatusDescribe || (this.StatusDescribe != null && !this.StatusDescribe.Equals(input.StatusDescribe))) return false;
            if (this.ServiceArea != input.ServiceArea) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.PullProtocol != input.PullProtocol) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                hashCode = hashCode * 59 + this.DomainType.GetHashCode();
                if (this.DomainCname != null) hashCode = hashCode * 59 + this.DomainCname.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.StatusDescribe != null) hashCode = hashCode * 59 + this.StatusDescribe.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceArea.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.PullProtocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
