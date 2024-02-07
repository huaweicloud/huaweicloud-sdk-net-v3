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
    public class CountGlobalEipSegmentRequest 
    {
        /// <summary>
        /// Defines fields
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<FieldsEnum>))]
        public class FieldsEnum
        {
            /// <summary>
            /// Enum COUNT for value: count
            /// </summary>
            public static readonly FieldsEnum COUNT = new FieldsEnum("count");

            private static readonly Dictionary<string, FieldsEnum> StaticFields =
            new Dictionary<string, FieldsEnum>()
            {
                { "count", COUNT },
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
        /// 只显示指定的字段
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldsEnum> Fields { get; set; }
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
        /// 根据IP版本过滤
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
        /// 根据资源状态过滤
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
        /// 根据绑定实例的类型过滤
        /// </summary>
        [SDKProperty("associate_instance.instance_type", IsQuery = true)]
        [JsonProperty("associate_instance.instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInstanceType { get; set; }

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
            sb.Append("class CountGlobalEipSegmentRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
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
            sb.Append("  associateInstancePublicBorderGroup: ").Append(AssociateInstancePublicBorderGroup).Append("\n");
            sb.Append("  associateInstanceInstanceSite: ").Append(AssociateInstanceInstanceSite).Append("\n");
            sb.Append("  associateInstanceInstanceType: ").Append(AssociateInstanceInstanceType).Append("\n");
            sb.Append("  associateInstanceInstanceId: ").Append(AssociateInstanceInstanceId).Append("\n");
            sb.Append("  associateInstanceProjectId: ").Append(AssociateInstanceProjectId).Append("\n");
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
            return this.Equals(input as CountGlobalEipSegmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountGlobalEipSegmentRequest input)
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
                    this.AssociateInstanceInstanceType == input.AssociateInstanceInstanceType ||
                    this.AssociateInstanceInstanceType != null &&
                    input.AssociateInstanceInstanceType != null &&
                    this.AssociateInstanceInstanceType.SequenceEqual(input.AssociateInstanceInstanceType)
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
                if (this.AssociateInstancePublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.AssociateInstancePublicBorderGroup.GetHashCode();
                if (this.AssociateInstanceInstanceSite != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInstanceSite.GetHashCode();
                if (this.AssociateInstanceInstanceType != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInstanceType.GetHashCode();
                if (this.AssociateInstanceInstanceId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInstanceId.GetHashCode();
                if (this.AssociateInstanceProjectId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceProjectId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
