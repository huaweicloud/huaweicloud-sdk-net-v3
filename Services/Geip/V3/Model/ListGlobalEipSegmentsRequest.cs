using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListGlobalEipSegmentsRequest 
    {
        /// <summary>
        /// Defines fields
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<FieldsEnum>))]
        public class FieldsEnum
        {
            /// <summary>
            /// Enum ID for value: id
            /// </summary>
            public static readonly FieldsEnum ID = new FieldsEnum("id");

            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly FieldsEnum NAME = new FieldsEnum("name");

            /// <summary>
            /// Enum DESCRIPTION for value: description
            /// </summary>
            public static readonly FieldsEnum DESCRIPTION = new FieldsEnum("description");

            /// <summary>
            /// Enum DOMAIN_ID for value: domain_id
            /// </summary>
            public static readonly FieldsEnum DOMAIN_ID = new FieldsEnum("domain_id");

            /// <summary>
            /// Enum ACCESS_SITE for value: access_site
            /// </summary>
            public static readonly FieldsEnum ACCESS_SITE = new FieldsEnum("access_site");

            /// <summary>
            /// Enum GEIP_POOL_NAME for value: geip_pool_name
            /// </summary>
            public static readonly FieldsEnum GEIP_POOL_NAME = new FieldsEnum("geip_pool_name");

            /// <summary>
            /// Enum ISP for value: isp
            /// </summary>
            public static readonly FieldsEnum ISP = new FieldsEnum("isp");

            /// <summary>
            /// Enum IP_VERSION for value: ip_version
            /// </summary>
            public static readonly FieldsEnum IP_VERSION = new FieldsEnum("ip_version");

            /// <summary>
            /// Enum CIDR for value: cidr
            /// </summary>
            public static readonly FieldsEnum CIDR = new FieldsEnum("cidr");

            /// <summary>
            /// Enum CIDR_V6 for value: cidr_v6
            /// </summary>
            public static readonly FieldsEnum CIDR_V6 = new FieldsEnum("cidr_v6");

            /// <summary>
            /// Enum FREEZEN for value: freezen
            /// </summary>
            public static readonly FieldsEnum FREEZEN = new FieldsEnum("freezen");

            /// <summary>
            /// Enum FREEZEN_INFO for value: freezen_info
            /// </summary>
            public static readonly FieldsEnum FREEZEN_INFO = new FieldsEnum("freezen_info");

            /// <summary>
            /// Enum STATUS for value: status
            /// </summary>
            public static readonly FieldsEnum STATUS = new FieldsEnum("status");

            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly FieldsEnum CREATED_AT = new FieldsEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly FieldsEnum UPDATED_AT = new FieldsEnum("updated_at");

            /// <summary>
            /// Enum INTERNET_BANDWIDTH for value: internet_bandwidth
            /// </summary>
            public static readonly FieldsEnum INTERNET_BANDWIDTH = new FieldsEnum("internet_bandwidth");

            /// <summary>
            /// Enum ASSOCIATE_INSTANCE for value: associate_instance
            /// </summary>
            public static readonly FieldsEnum ASSOCIATE_INSTANCE = new FieldsEnum("associate_instance");

            /// <summary>
            /// Enum IS_PRE_PAID for value: is_pre_paid
            /// </summary>
            public static readonly FieldsEnum IS_PRE_PAID = new FieldsEnum("is_pre_paid");

            /// <summary>
            /// Enum TAGS for value: tags
            /// </summary>
            public static readonly FieldsEnum TAGS = new FieldsEnum("tags");

            /// <summary>
            /// Enum SYS_TAGS for value: sys_tags
            /// </summary>
            public static readonly FieldsEnum SYS_TAGS = new FieldsEnum("sys_tags");

            /// <summary>
            /// Enum ENTERPRISE_PROJECT_ID for value: enterprise_project_id
            /// </summary>
            public static readonly FieldsEnum ENTERPRISE_PROJECT_ID = new FieldsEnum("enterprise_project_id");

            private static readonly Dictionary<string, FieldsEnum> StaticFields =
            new Dictionary<string, FieldsEnum>()
            {
                { "id", ID },
                { "name", NAME },
                { "description", DESCRIPTION },
                { "domain_id", DOMAIN_ID },
                { "access_site", ACCESS_SITE },
                { "geip_pool_name", GEIP_POOL_NAME },
                { "isp", ISP },
                { "ip_version", IP_VERSION },
                { "cidr", CIDR },
                { "cidr_v6", CIDR_V6 },
                { "freezen", FREEZEN },
                { "freezen_info", FREEZEN_INFO },
                { "status", STATUS },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
                { "internet_bandwidth", INTERNET_BANDWIDTH },
                { "associate_instance", ASSOCIATE_INSTANCE },
                { "is_pre_paid", IS_PRE_PAID },
                { "tags", TAGS },
                { "sys_tags", SYS_TAGS },
                { "enterprise_project_id", ENTERPRISE_PROJECT_ID },
            };

            private string _value;

            public FieldsEnum()
            {

            }

            public FieldsEnum(string value)
            {
                _value = value;
            }

            public static FieldsEnum FromValue(string value)
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

                if (this.Equals(obj as FieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FieldsEnum a, FieldsEnum b)
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

            public static bool operator !=(FieldsEnum a, FieldsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines sortKey
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum ID for value: id
            /// </summary>
            public static readonly SortKeyEnum ID = new SortKeyEnum("id");

            /// <summary>
            /// Enum CIDR for value: cidr
            /// </summary>
            public static readonly SortKeyEnum CIDR = new SortKeyEnum("cidr");

            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly SortKeyEnum CREATED_AT = new SortKeyEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly SortKeyEnum UPDATED_AT = new SortKeyEnum("updated_at");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "id", ID },
                { "cidr", CIDR },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
            };

            private string _value;

            public SortKeyEnum()
            {

            }

            public SortKeyEnum(string value)
            {
                _value = value;
            }

            public static SortKeyEnum FromValue(string value)
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines sortDir
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortDirEnum>))]
        public class SortDirEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortDirEnum ASC = new SortDirEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortDirEnum DESC = new SortDirEnum("desc");

            private static readonly Dictionary<string, SortDirEnum> StaticFields =
            new Dictionary<string, SortDirEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public SortDirEnum()
            {

            }

            public SortDirEnum(string value)
            {
                _value = value;
            }

            public static SortDirEnum FromValue(string value)
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

                if (this.Equals(obj as SortDirEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortDirEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortDirEnum a, SortDirEnum b)
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

            public static bool operator !=(SortDirEnum a, SortDirEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines ipVersion
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<IpVersionEnum>))]
        public class IpVersionEnum
        {
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly IpVersionEnum NUMBER_4 = new IpVersionEnum(4);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly IpVersionEnum NUMBER_6 = new IpVersionEnum(6);

            private static readonly Dictionary<int?, IpVersionEnum> StaticFields =
            new Dictionary<int?, IpVersionEnum>()
            {
                { 4, NUMBER_4 },
                { 6, NUMBER_6 },
            };

            private int? _value;

            public IpVersionEnum()
            {

            }

            public IpVersionEnum(int? value)
            {
                _value = value;
            }

            public static IpVersionEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as IpVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpVersionEnum a, IpVersionEnum b)
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

            public static bool operator !=(IpVersionEnum a, IpVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum IDLE for value: idle
            /// </summary>
            public static readonly StatusEnum IDLE = new StatusEnum("idle");

            /// <summary>
            /// Enum INUSE for value: inuse
            /// </summary>
            public static readonly StatusEnum INUSE = new StatusEnum("inuse");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "idle", IDLE },
                { "inuse", INUSE },
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
        /// 每页条数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 翻页方向
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 只显示指定的字段
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldsEnum> Fields { get; set; }
        /// <summary>
        /// 按照sort_key指定的字段排序
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortKeyEnum> SortKey { get; set; }
        /// <summary>
        /// 排序的方向，倒序或者正序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortDirEnum> SortDir { get; set; }
        /// <summary>
        /// 根据资源ID过滤
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 根据全域公网带宽的ID过滤
        /// </summary>
        [SDKProperty("internet_bandwidth_id", IsQuery = true)]
        [JsonProperty("internet_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InternetBandwidthId { get; set; }

        /// <summary>
        /// 根据名称过滤
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 根据名称模糊匹配
        /// </summary>
        [SDKProperty("name_like", IsQuery = true)]
        [JsonProperty("name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLike { get; set; }

        /// <summary>
        /// 根据接入点过滤
        /// </summary>
        [SDKProperty("access_site", IsQuery = true)]
        [JsonProperty("access_site", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessSite { get; set; }

        /// <summary>
        /// 根据全域弹性公网IP池名称过滤
        /// </summary>
        [SDKProperty("geip_pool_name", IsQuery = true)]
        [JsonProperty("geip_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GeipPoolName { get; set; }

        /// <summary>
        /// 根据运营商线路过滤
        /// </summary>
        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isp { get; set; }

        /// <summary>
        /// 根据可分配的IP版本过滤
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpVersionEnum> IpVersion { get; set; }
        /// <summary>
        /// 根据分配的CIDR过滤
        /// </summary>
        [SDKProperty("cidr", IsQuery = true)]
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Cidr { get; set; }

        /// <summary>
        /// 根据分配的IPv6 CIDR过滤
        /// </summary>
        [SDKProperty("cidr_v6", IsQuery = true)]
        [JsonProperty("cidr_v6", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CidrV6 { get; set; }

        /// <summary>
        /// 根据是否冻结过滤
        /// </summary>
        [SDKProperty("freezen", IsQuery = true)]
        [JsonProperty("freezen", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> Freezen { get; set; }

        /// <summary>
        /// 根据是否绑定全域公网带宽过滤
        /// </summary>
        [SDKProperty("internet_bandwidth_is_null", IsQuery = true)]
        [JsonProperty("internet_bandwidth_is_null", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> InternetBandwidthIsNull { get; set; }

        /// <summary>
        /// 根据状态过滤
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// 根据绑定实例所属的局点过滤
        /// </summary>
        [SDKProperty("associate_instance.region", IsQuery = true)]
        [JsonProperty("associate_instance.region", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceRegion { get; set; }

        /// <summary>
        /// 根据绑定实例的类型过滤
        /// </summary>
        [SDKProperty("associate_instance.instance_type", IsQuery = true)]
        [JsonProperty("associate_instance.instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInstanceType { get; set; }

        /// <summary>
        /// 根据绑定实例所属的边缘信息过滤
        /// </summary>
        [SDKProperty("associate_instance.public_border_group", IsQuery = true)]
        [JsonProperty("associate_instance.public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstancePublicBorderGroup { get; set; }

        /// <summary>
        /// 根据绑定实例所在的站点过滤
        /// </summary>
        [SDKProperty("associate_instance.instance_site", IsQuery = true)]
        [JsonProperty("associate_instance.instance_site", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInstanceSite { get; set; }

        /// <summary>
        /// 根据绑定实例的ID过滤
        /// </summary>
        [SDKProperty("associate_instance.instance_id", IsQuery = true)]
        [JsonProperty("associate_instance.instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInstanceId { get; set; }

        /// <summary>
        /// 根据绑定实例所属的项目ID过滤
        /// </summary>
        [SDKProperty("associate_instance.project_id", IsQuery = true)]
        [JsonProperty("associate_instance.project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceProjectId { get; set; }

        /// <summary>
        /// 根据绑定实例所属的服务ID过滤
        /// </summary>
        [SDKProperty("associate_instance.service_id", IsQuery = true)]
        [JsonProperty("associate_instance.service_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceServiceId { get; set; }

        /// <summary>
        /// 根据绑定实例的服务类型过滤
        /// </summary>
        [SDKProperty("associate_instance.service_type", IsQuery = true)]
        [JsonProperty("associate_instance.service_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceServiceType { get; set; }

        /// <summary>
        /// 根据企业项目ID过滤
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 根据标签过滤
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGlobalEipSegmentsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  internetBandwidthId: ").Append(InternetBandwidthId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameLike: ").Append(NameLike).Append("\n");
            sb.Append("  accessSite: ").Append(AccessSite).Append("\n");
            sb.Append("  geipPoolName: ").Append(GeipPoolName).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  cidrV6: ").Append(CidrV6).Append("\n");
            sb.Append("  freezen: ").Append(Freezen).Append("\n");
            sb.Append("  internetBandwidthIsNull: ").Append(InternetBandwidthIsNull).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  associateInstanceRegion: ").Append(AssociateInstanceRegion).Append("\n");
            sb.Append("  associateInstanceInstanceType: ").Append(AssociateInstanceInstanceType).Append("\n");
            sb.Append("  associateInstancePublicBorderGroup: ").Append(AssociateInstancePublicBorderGroup).Append("\n");
            sb.Append("  associateInstanceInstanceSite: ").Append(AssociateInstanceInstanceSite).Append("\n");
            sb.Append("  associateInstanceInstanceId: ").Append(AssociateInstanceInstanceId).Append("\n");
            sb.Append("  associateInstanceProjectId: ").Append(AssociateInstanceProjectId).Append("\n");
            sb.Append("  associateInstanceServiceId: ").Append(AssociateInstanceServiceId).Append("\n");
            sb.Append("  associateInstanceServiceType: ").Append(AssociateInstanceServiceType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGlobalEipSegmentsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalEipSegmentsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.SortKey == input.SortKey ||
                    this.SortKey != null &&
                    input.SortKey != null &&
                    this.SortKey.SequenceEqual(input.SortKey)
                ) && 
                (
                    this.SortDir == input.SortDir ||
                    this.SortDir != null &&
                    input.SortDir != null &&
                    this.SortDir.SequenceEqual(input.SortDir)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.InternetBandwidthId == input.InternetBandwidthId ||
                    this.InternetBandwidthId != null &&
                    input.InternetBandwidthId != null &&
                    this.InternetBandwidthId.SequenceEqual(input.InternetBandwidthId)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.NameLike == input.NameLike ||
                    (this.NameLike != null &&
                    this.NameLike.Equals(input.NameLike))
                ) && 
                (
                    this.AccessSite == input.AccessSite ||
                    this.AccessSite != null &&
                    input.AccessSite != null &&
                    this.AccessSite.SequenceEqual(input.AccessSite)
                ) && 
                (
                    this.GeipPoolName == input.GeipPoolName ||
                    this.GeipPoolName != null &&
                    input.GeipPoolName != null &&
                    this.GeipPoolName.SequenceEqual(input.GeipPoolName)
                ) && 
                (
                    this.Isp == input.Isp ||
                    this.Isp != null &&
                    input.Isp != null &&
                    this.Isp.SequenceEqual(input.Isp)
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    this.IpVersion != null &&
                    input.IpVersion != null &&
                    this.IpVersion.SequenceEqual(input.IpVersion)
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    this.Cidr != null &&
                    input.Cidr != null &&
                    this.Cidr.SequenceEqual(input.Cidr)
                ) && 
                (
                    this.CidrV6 == input.CidrV6 ||
                    this.CidrV6 != null &&
                    input.CidrV6 != null &&
                    this.CidrV6.SequenceEqual(input.CidrV6)
                ) && 
                (
                    this.Freezen == input.Freezen ||
                    this.Freezen != null &&
                    input.Freezen != null &&
                    this.Freezen.SequenceEqual(input.Freezen)
                ) && 
                (
                    this.InternetBandwidthIsNull == input.InternetBandwidthIsNull ||
                    this.InternetBandwidthIsNull != null &&
                    input.InternetBandwidthIsNull != null &&
                    this.InternetBandwidthIsNull.SequenceEqual(input.InternetBandwidthIsNull)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.AssociateInstanceRegion == input.AssociateInstanceRegion ||
                    this.AssociateInstanceRegion != null &&
                    input.AssociateInstanceRegion != null &&
                    this.AssociateInstanceRegion.SequenceEqual(input.AssociateInstanceRegion)
                ) && 
                (
                    this.AssociateInstanceInstanceType == input.AssociateInstanceInstanceType ||
                    this.AssociateInstanceInstanceType != null &&
                    input.AssociateInstanceInstanceType != null &&
                    this.AssociateInstanceInstanceType.SequenceEqual(input.AssociateInstanceInstanceType)
                ) && 
                (
                    this.AssociateInstancePublicBorderGroup == input.AssociateInstancePublicBorderGroup ||
                    this.AssociateInstancePublicBorderGroup != null &&
                    input.AssociateInstancePublicBorderGroup != null &&
                    this.AssociateInstancePublicBorderGroup.SequenceEqual(input.AssociateInstancePublicBorderGroup)
                ) && 
                (
                    this.AssociateInstanceInstanceSite == input.AssociateInstanceInstanceSite ||
                    this.AssociateInstanceInstanceSite != null &&
                    input.AssociateInstanceInstanceSite != null &&
                    this.AssociateInstanceInstanceSite.SequenceEqual(input.AssociateInstanceInstanceSite)
                ) && 
                (
                    this.AssociateInstanceInstanceId == input.AssociateInstanceInstanceId ||
                    this.AssociateInstanceInstanceId != null &&
                    input.AssociateInstanceInstanceId != null &&
                    this.AssociateInstanceInstanceId.SequenceEqual(input.AssociateInstanceInstanceId)
                ) && 
                (
                    this.AssociateInstanceProjectId == input.AssociateInstanceProjectId ||
                    this.AssociateInstanceProjectId != null &&
                    input.AssociateInstanceProjectId != null &&
                    this.AssociateInstanceProjectId.SequenceEqual(input.AssociateInstanceProjectId)
                ) && 
                (
                    this.AssociateInstanceServiceId == input.AssociateInstanceServiceId ||
                    this.AssociateInstanceServiceId != null &&
                    input.AssociateInstanceServiceId != null &&
                    this.AssociateInstanceServiceId.SequenceEqual(input.AssociateInstanceServiceId)
                ) && 
                (
                    this.AssociateInstanceServiceType == input.AssociateInstanceServiceType ||
                    this.AssociateInstanceServiceType != null &&
                    input.AssociateInstanceServiceType != null &&
                    this.AssociateInstanceServiceType.SequenceEqual(input.AssociateInstanceServiceType)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.SortKey != null)
                    hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null)
                    hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InternetBandwidthId != null)
                    hashCode = hashCode * 59 + this.InternetBandwidthId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameLike != null)
                    hashCode = hashCode * 59 + this.NameLike.GetHashCode();
                if (this.AccessSite != null)
                    hashCode = hashCode * 59 + this.AccessSite.GetHashCode();
                if (this.GeipPoolName != null)
                    hashCode = hashCode * 59 + this.GeipPoolName.GetHashCode();
                if (this.Isp != null)
                    hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.CidrV6 != null)
                    hashCode = hashCode * 59 + this.CidrV6.GetHashCode();
                if (this.Freezen != null)
                    hashCode = hashCode * 59 + this.Freezen.GetHashCode();
                if (this.InternetBandwidthIsNull != null)
                    hashCode = hashCode * 59 + this.InternetBandwidthIsNull.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AssociateInstanceRegion != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceRegion.GetHashCode();
                if (this.AssociateInstanceInstanceType != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInstanceType.GetHashCode();
                if (this.AssociateInstancePublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.AssociateInstancePublicBorderGroup.GetHashCode();
                if (this.AssociateInstanceInstanceSite != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInstanceSite.GetHashCode();
                if (this.AssociateInstanceInstanceId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInstanceId.GetHashCode();
                if (this.AssociateInstanceProjectId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceProjectId.GetHashCode();
                if (this.AssociateInstanceServiceId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceServiceId.GetHashCode();
                if (this.AssociateInstanceServiceType != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceServiceType.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
