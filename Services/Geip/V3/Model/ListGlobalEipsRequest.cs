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
    public class ListGlobalEipsRequest 
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
            /// Enum IP_ADDRESS for value: ip_address
            /// </summary>
            public static readonly FieldsEnum IP_ADDRESS = new FieldsEnum("ip_address");

            /// <summary>
            /// Enum IPV6_ADDRESS for value: ipv6_address
            /// </summary>
            public static readonly FieldsEnum IPV6_ADDRESS = new FieldsEnum("ipv6_address");

            /// <summary>
            /// Enum FREEZEN for value: freezen
            /// </summary>
            public static readonly FieldsEnum FREEZEN = new FieldsEnum("freezen");

            /// <summary>
            /// Enum FREEZEN_INFO for value: freezen_info
            /// </summary>
            public static readonly FieldsEnum FREEZEN_INFO = new FieldsEnum("freezen_info");

            /// <summary>
            /// Enum POLLUTED for value: polluted
            /// </summary>
            public static readonly FieldsEnum POLLUTED = new FieldsEnum("polluted");

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
            /// Enum INTERNET_BANDWIDTH_INFO for value: internet_bandwidth_info
            /// </summary>
            public static readonly FieldsEnum INTERNET_BANDWIDTH_INFO = new FieldsEnum("internet_bandwidth_info");

            /// <summary>
            /// Enum GLOBAL_CONNECTION_BANDWIDTH_INFO for value: global_connection_bandwidth_info
            /// </summary>
            public static readonly FieldsEnum GLOBAL_CONNECTION_BANDWIDTH_INFO = new FieldsEnum("global_connection_bandwidth_info");

            /// <summary>
            /// Enum ASSOCIATE_INSTANCE_INFO for value: associate_instance_info
            /// </summary>
            public static readonly FieldsEnum ASSOCIATE_INSTANCE_INFO = new FieldsEnum("associate_instance_info");

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
                { "ip_address", IP_ADDRESS },
                { "ipv6_address", IPV6_ADDRESS },
                { "freezen", FREEZEN },
                { "freezen_info", FREEZEN_INFO },
                { "polluted", POLLUTED },
                { "status", STATUS },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
                { "internet_bandwidth_info", INTERNET_BANDWIDTH_INFO },
                { "global_connection_bandwidth_info", GLOBAL_CONNECTION_BANDWIDTH_INFO },
                { "associate_instance_info", ASSOCIATE_INSTANCE_INFO },
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
            /// Enum IP_ADDRESS for value: ip_address
            /// </summary>
            public static readonly SortKeyEnum IP_ADDRESS = new SortKeyEnum("ip_address");

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
                { "ip_address", IP_ADDRESS },
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

            /// <summary>
            /// Enum PENDING_CREATE for value: pending_create
            /// </summary>
            public static readonly StatusEnum PENDING_CREATE = new StatusEnum("pending_create");

            /// <summary>
            /// Enum PENDING_UPDATE for value: pending_update
            /// </summary>
            public static readonly StatusEnum PENDING_UPDATE = new StatusEnum("pending_update");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "idle", IDLE },
                { "inuse", INUSE },
                { "pending_create", PENDING_CREATE },
                { "pending_update", PENDING_UPDATE },
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
        /// 
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
        /// 
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("internet_bandwidth_id", IsQuery = true)]
        [JsonProperty("internet_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InternetBandwidthId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name_like", IsQuery = true)]
        [JsonProperty("name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLike { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("access_site", IsQuery = true)]
        [JsonProperty("access_site", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("geip_pool_name", IsQuery = true)]
        [JsonProperty("geip_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GeipPoolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpVersionEnum> IpVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ip_address", IsQuery = true)]
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ipv6_address", IsQuery = true)]
        [JsonProperty("ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("freezen", IsQuery = true)]
        [JsonProperty("freezen", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> Freezen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("polluted", IsQuery = true)]
        [JsonProperty("polluted", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> Polluted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("internet_bandwidth_is_null", IsQuery = true)]
        [JsonProperty("internet_bandwidth_is_null", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> InternetBandwidthIsNull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("gcb_bandwidth_is_null", IsQuery = true)]
        [JsonProperty("gcb_bandwidth_is_null", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> GcbBandwidthIsNull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.region", IsQuery = true)]
        [JsonProperty("associate_instance_info.region", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.instance_type", IsQuery = true)]
        [JsonProperty("associate_instance_info.instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoInstanceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.public_border_group", IsQuery = true)]
        [JsonProperty("associate_instance_info.public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoPublicBorderGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.instance_site", IsQuery = true)]
        [JsonProperty("associate_instance_info.instance_site", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoInstanceSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.instance_id", IsQuery = true)]
        [JsonProperty("associate_instance_info.instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoInstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.project_id", IsQuery = true)]
        [JsonProperty("associate_instance_info.project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.service_id", IsQuery = true)]
        [JsonProperty("associate_instance_info.service_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("associate_instance_info.service_type", IsQuery = true)]
        [JsonProperty("associate_instance_info.service_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoServiceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
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
            sb.Append("class ListGlobalEipsRequest {\n");
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
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  freezen: ").Append(Freezen).Append("\n");
            sb.Append("  polluted: ").Append(Polluted).Append("\n");
            sb.Append("  internetBandwidthIsNull: ").Append(InternetBandwidthIsNull).Append("\n");
            sb.Append("  gcbBandwidthIsNull: ").Append(GcbBandwidthIsNull).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  associateInstanceInfoRegion: ").Append(AssociateInstanceInfoRegion).Append("\n");
            sb.Append("  associateInstanceInfoInstanceType: ").Append(AssociateInstanceInfoInstanceType).Append("\n");
            sb.Append("  associateInstanceInfoPublicBorderGroup: ").Append(AssociateInstanceInfoPublicBorderGroup).Append("\n");
            sb.Append("  associateInstanceInfoInstanceSite: ").Append(AssociateInstanceInfoInstanceSite).Append("\n");
            sb.Append("  associateInstanceInfoInstanceId: ").Append(AssociateInstanceInfoInstanceId).Append("\n");
            sb.Append("  associateInstanceInfoProjectId: ").Append(AssociateInstanceInfoProjectId).Append("\n");
            sb.Append("  associateInstanceInfoServiceId: ").Append(AssociateInstanceInfoServiceId).Append("\n");
            sb.Append("  associateInstanceInfoServiceType: ").Append(AssociateInstanceInfoServiceType).Append("\n");
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
            return this.Equals(input as ListGlobalEipsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalEipsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && input.SortKey != null && !this.SortKey.SequenceEqual(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && input.SortDir != null && !this.SortDir.SequenceEqual(input.SortDir))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.InternetBandwidthId != input.InternetBandwidthId || (this.InternetBandwidthId != null && input.InternetBandwidthId != null && !this.InternetBandwidthId.SequenceEqual(input.InternetBandwidthId))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.NameLike != input.NameLike || (this.NameLike != null && !this.NameLike.Equals(input.NameLike))) return false;
            if (this.AccessSite != input.AccessSite || (this.AccessSite != null && input.AccessSite != null && !this.AccessSite.SequenceEqual(input.AccessSite))) return false;
            if (this.GeipPoolName != input.GeipPoolName || (this.GeipPoolName != null && input.GeipPoolName != null && !this.GeipPoolName.SequenceEqual(input.GeipPoolName))) return false;
            if (this.Isp != input.Isp || (this.Isp != null && input.Isp != null && !this.Isp.SequenceEqual(input.Isp))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && input.IpVersion != null && !this.IpVersion.SequenceEqual(input.IpVersion))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && input.IpAddress != null && !this.IpAddress.SequenceEqual(input.IpAddress))) return false;
            if (this.Ipv6Address != input.Ipv6Address || (this.Ipv6Address != null && input.Ipv6Address != null && !this.Ipv6Address.SequenceEqual(input.Ipv6Address))) return false;
            if (this.Freezen != input.Freezen || (this.Freezen != null && input.Freezen != null && !this.Freezen.SequenceEqual(input.Freezen))) return false;
            if (this.Polluted != input.Polluted || (this.Polluted != null && input.Polluted != null && !this.Polluted.SequenceEqual(input.Polluted))) return false;
            if (this.InternetBandwidthIsNull != input.InternetBandwidthIsNull || (this.InternetBandwidthIsNull != null && input.InternetBandwidthIsNull != null && !this.InternetBandwidthIsNull.SequenceEqual(input.InternetBandwidthIsNull))) return false;
            if (this.GcbBandwidthIsNull != input.GcbBandwidthIsNull || (this.GcbBandwidthIsNull != null && input.GcbBandwidthIsNull != null && !this.GcbBandwidthIsNull.SequenceEqual(input.GcbBandwidthIsNull))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.AssociateInstanceInfoRegion != input.AssociateInstanceInfoRegion || (this.AssociateInstanceInfoRegion != null && input.AssociateInstanceInfoRegion != null && !this.AssociateInstanceInfoRegion.SequenceEqual(input.AssociateInstanceInfoRegion))) return false;
            if (this.AssociateInstanceInfoInstanceType != input.AssociateInstanceInfoInstanceType || (this.AssociateInstanceInfoInstanceType != null && input.AssociateInstanceInfoInstanceType != null && !this.AssociateInstanceInfoInstanceType.SequenceEqual(input.AssociateInstanceInfoInstanceType))) return false;
            if (this.AssociateInstanceInfoPublicBorderGroup != input.AssociateInstanceInfoPublicBorderGroup || (this.AssociateInstanceInfoPublicBorderGroup != null && input.AssociateInstanceInfoPublicBorderGroup != null && !this.AssociateInstanceInfoPublicBorderGroup.SequenceEqual(input.AssociateInstanceInfoPublicBorderGroup))) return false;
            if (this.AssociateInstanceInfoInstanceSite != input.AssociateInstanceInfoInstanceSite || (this.AssociateInstanceInfoInstanceSite != null && input.AssociateInstanceInfoInstanceSite != null && !this.AssociateInstanceInfoInstanceSite.SequenceEqual(input.AssociateInstanceInfoInstanceSite))) return false;
            if (this.AssociateInstanceInfoInstanceId != input.AssociateInstanceInfoInstanceId || (this.AssociateInstanceInfoInstanceId != null && input.AssociateInstanceInfoInstanceId != null && !this.AssociateInstanceInfoInstanceId.SequenceEqual(input.AssociateInstanceInfoInstanceId))) return false;
            if (this.AssociateInstanceInfoProjectId != input.AssociateInstanceInfoProjectId || (this.AssociateInstanceInfoProjectId != null && input.AssociateInstanceInfoProjectId != null && !this.AssociateInstanceInfoProjectId.SequenceEqual(input.AssociateInstanceInfoProjectId))) return false;
            if (this.AssociateInstanceInfoServiceId != input.AssociateInstanceInfoServiceId || (this.AssociateInstanceInfoServiceId != null && input.AssociateInstanceInfoServiceId != null && !this.AssociateInstanceInfoServiceId.SequenceEqual(input.AssociateInstanceInfoServiceId))) return false;
            if (this.AssociateInstanceInfoServiceType != input.AssociateInstanceInfoServiceType || (this.AssociateInstanceInfoServiceType != null && input.AssociateInstanceInfoServiceType != null && !this.AssociateInstanceInfoServiceType.SequenceEqual(input.AssociateInstanceInfoServiceType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                hashCode = hashCode * 59 + this.Fields.GetHashCode();
                hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InternetBandwidthId != null) hashCode = hashCode * 59 + this.InternetBandwidthId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameLike != null) hashCode = hashCode * 59 + this.NameLike.GetHashCode();
                if (this.AccessSite != null) hashCode = hashCode * 59 + this.AccessSite.GetHashCode();
                if (this.GeipPoolName != null) hashCode = hashCode * 59 + this.GeipPoolName.GetHashCode();
                if (this.Isp != null) hashCode = hashCode * 59 + this.Isp.GetHashCode();
                hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Ipv6Address != null) hashCode = hashCode * 59 + this.Ipv6Address.GetHashCode();
                if (this.Freezen != null) hashCode = hashCode * 59 + this.Freezen.GetHashCode();
                if (this.Polluted != null) hashCode = hashCode * 59 + this.Polluted.GetHashCode();
                if (this.InternetBandwidthIsNull != null) hashCode = hashCode * 59 + this.InternetBandwidthIsNull.GetHashCode();
                if (this.GcbBandwidthIsNull != null) hashCode = hashCode * 59 + this.GcbBandwidthIsNull.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AssociateInstanceInfoRegion != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoRegion.GetHashCode();
                if (this.AssociateInstanceInfoInstanceType != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoInstanceType.GetHashCode();
                if (this.AssociateInstanceInfoPublicBorderGroup != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoPublicBorderGroup.GetHashCode();
                if (this.AssociateInstanceInfoInstanceSite != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoInstanceSite.GetHashCode();
                if (this.AssociateInstanceInfoInstanceId != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoInstanceId.GetHashCode();
                if (this.AssociateInstanceInfoProjectId != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoProjectId.GetHashCode();
                if (this.AssociateInstanceInfoServiceId != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoServiceId.GetHashCode();
                if (this.AssociateInstanceInfoServiceType != null) hashCode = hashCode * 59 + this.AssociateInstanceInfoServiceType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
