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
    public class CountGlobalEipsRequest 
    {
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
        [SDKProperty("associate_instance_info.instance_type", IsQuery = true)]
        [JsonProperty("associate_instance_info.instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociateInstanceInfoInstanceType { get; set; }

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
            sb.Append("class CountGlobalEipsRequest {\n");
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
            sb.Append("  associateInstanceInfoPublicBorderGroup: ").Append(AssociateInstanceInfoPublicBorderGroup).Append("\n");
            sb.Append("  associateInstanceInfoInstanceSite: ").Append(AssociateInstanceInfoInstanceSite).Append("\n");
            sb.Append("  associateInstanceInfoInstanceType: ").Append(AssociateInstanceInfoInstanceType).Append("\n");
            sb.Append("  associateInstanceInfoInstanceId: ").Append(AssociateInstanceInfoInstanceId).Append("\n");
            sb.Append("  associateInstanceInfoProjectId: ").Append(AssociateInstanceInfoProjectId).Append("\n");
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
            return this.Equals(input as CountGlobalEipsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountGlobalEipsRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.IpAddress == input.IpAddress ||
                    this.IpAddress != null &&
                    input.IpAddress != null &&
                    this.IpAddress.SequenceEqual(input.IpAddress)
                ) && 
                (
                    this.Ipv6Address == input.Ipv6Address ||
                    this.Ipv6Address != null &&
                    input.Ipv6Address != null &&
                    this.Ipv6Address.SequenceEqual(input.Ipv6Address)
                ) && 
                (
                    this.Freezen == input.Freezen ||
                    this.Freezen != null &&
                    input.Freezen != null &&
                    this.Freezen.SequenceEqual(input.Freezen)
                ) && 
                (
                    this.Polluted == input.Polluted ||
                    this.Polluted != null &&
                    input.Polluted != null &&
                    this.Polluted.SequenceEqual(input.Polluted)
                ) && 
                (
                    this.InternetBandwidthIsNull == input.InternetBandwidthIsNull ||
                    this.InternetBandwidthIsNull != null &&
                    input.InternetBandwidthIsNull != null &&
                    this.InternetBandwidthIsNull.SequenceEqual(input.InternetBandwidthIsNull)
                ) && 
                (
                    this.GcbBandwidthIsNull == input.GcbBandwidthIsNull ||
                    this.GcbBandwidthIsNull != null &&
                    input.GcbBandwidthIsNull != null &&
                    this.GcbBandwidthIsNull.SequenceEqual(input.GcbBandwidthIsNull)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.AssociateInstanceInfoRegion == input.AssociateInstanceInfoRegion ||
                    this.AssociateInstanceInfoRegion != null &&
                    input.AssociateInstanceInfoRegion != null &&
                    this.AssociateInstanceInfoRegion.SequenceEqual(input.AssociateInstanceInfoRegion)
                ) && 
                (
                    this.AssociateInstanceInfoPublicBorderGroup == input.AssociateInstanceInfoPublicBorderGroup ||
                    this.AssociateInstanceInfoPublicBorderGroup != null &&
                    input.AssociateInstanceInfoPublicBorderGroup != null &&
                    this.AssociateInstanceInfoPublicBorderGroup.SequenceEqual(input.AssociateInstanceInfoPublicBorderGroup)
                ) && 
                (
                    this.AssociateInstanceInfoInstanceSite == input.AssociateInstanceInfoInstanceSite ||
                    this.AssociateInstanceInfoInstanceSite != null &&
                    input.AssociateInstanceInfoInstanceSite != null &&
                    this.AssociateInstanceInfoInstanceSite.SequenceEqual(input.AssociateInstanceInfoInstanceSite)
                ) && 
                (
                    this.AssociateInstanceInfoInstanceType == input.AssociateInstanceInfoInstanceType ||
                    this.AssociateInstanceInfoInstanceType != null &&
                    input.AssociateInstanceInfoInstanceType != null &&
                    this.AssociateInstanceInfoInstanceType.SequenceEqual(input.AssociateInstanceInfoInstanceType)
                ) && 
                (
                    this.AssociateInstanceInfoInstanceId == input.AssociateInstanceInfoInstanceId ||
                    this.AssociateInstanceInfoInstanceId != null &&
                    input.AssociateInstanceInfoInstanceId != null &&
                    this.AssociateInstanceInfoInstanceId.SequenceEqual(input.AssociateInstanceInfoInstanceId)
                ) && 
                (
                    this.AssociateInstanceInfoProjectId == input.AssociateInstanceInfoProjectId ||
                    this.AssociateInstanceInfoProjectId != null &&
                    input.AssociateInstanceInfoProjectId != null &&
                    this.AssociateInstanceInfoProjectId.SequenceEqual(input.AssociateInstanceInfoProjectId)
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
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Ipv6Address != null)
                    hashCode = hashCode * 59 + this.Ipv6Address.GetHashCode();
                if (this.Freezen != null)
                    hashCode = hashCode * 59 + this.Freezen.GetHashCode();
                if (this.Polluted != null)
                    hashCode = hashCode * 59 + this.Polluted.GetHashCode();
                if (this.InternetBandwidthIsNull != null)
                    hashCode = hashCode * 59 + this.InternetBandwidthIsNull.GetHashCode();
                if (this.GcbBandwidthIsNull != null)
                    hashCode = hashCode * 59 + this.GcbBandwidthIsNull.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AssociateInstanceInfoRegion != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInfoRegion.GetHashCode();
                if (this.AssociateInstanceInfoPublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInfoPublicBorderGroup.GetHashCode();
                if (this.AssociateInstanceInfoInstanceSite != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInfoInstanceSite.GetHashCode();
                if (this.AssociateInstanceInfoInstanceType != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInfoInstanceType.GetHashCode();
                if (this.AssociateInstanceInfoInstanceId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInfoInstanceId.GetHashCode();
                if (this.AssociateInstanceInfoProjectId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInfoProjectId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
