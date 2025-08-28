using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 租户能力实例。
    /// </summary>
    public class CloudConnectionCapability 
    {
        /// <summary>
        /// 租户能力类型，分为： 1. v2：V2的API 2. v3：V3的API 3. billing_mode_period_reduce: 实时降配（包周期） 4. billing_mode_demand: 按需计费（每小时统计打点） 5. bwp95: 按需计费-95（传统95计费方式） 6. bwp95Avg: 按需计费-日95（95峰值平均） 7. network-quality: 丢包和时延统计 8. er：是否支持ER 9. domain_bandwidth：租户带宽值 10. ipv6: 是否支持IPV6 11. ipv6_support_regions: IPV6支持的region列表
        /// </summary>
        /// <value>租户能力类型，分为： 1. v2：V2的API 2. v3：V3的API 3. billing_mode_period_reduce: 实时降配（包周期） 4. billing_mode_demand: 按需计费（每小时统计打点） 5. bwp95: 按需计费-95（传统95计费方式） 6. bwp95Avg: 按需计费-日95（95峰值平均） 7. network-quality: 丢包和时延统计 8. er：是否支持ER 9. domain_bandwidth：租户带宽值 10. ipv6: 是否支持IPV6 11. ipv6_support_regions: IPV6支持的region列表</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum V2 for value: v2
            /// </summary>
            public static readonly ResourceTypeEnum V2 = new ResourceTypeEnum("v2");

            /// <summary>
            /// Enum V3 for value: v3
            /// </summary>
            public static readonly ResourceTypeEnum V3 = new ResourceTypeEnum("v3");

            /// <summary>
            /// Enum BILLING_MODE_PERIOD_REDUCE for value: billing_mode_period_reduce
            /// </summary>
            public static readonly ResourceTypeEnum BILLING_MODE_PERIOD_REDUCE = new ResourceTypeEnum("billing_mode_period_reduce");

            /// <summary>
            /// Enum BILLING_MODE_DEMAND for value: billing_mode_demand
            /// </summary>
            public static readonly ResourceTypeEnum BILLING_MODE_DEMAND = new ResourceTypeEnum("billing_mode_demand");

            /// <summary>
            /// Enum BWP95 for value: bwp95
            /// </summary>
            public static readonly ResourceTypeEnum BWP95 = new ResourceTypeEnum("bwp95");

            /// <summary>
            /// Enum BWP95AVG for value: bwp95Avg
            /// </summary>
            public static readonly ResourceTypeEnum BWP95AVG = new ResourceTypeEnum("bwp95Avg");

            /// <summary>
            /// Enum NETWORK_QUALITY for value: network-quality
            /// </summary>
            public static readonly ResourceTypeEnum NETWORK_QUALITY = new ResourceTypeEnum("network-quality");

            /// <summary>
            /// Enum ER for value: er
            /// </summary>
            public static readonly ResourceTypeEnum ER = new ResourceTypeEnum("er");

            /// <summary>
            /// Enum DOMAIN_BANDWIDTH for value: domain_bandwidth
            /// </summary>
            public static readonly ResourceTypeEnum DOMAIN_BANDWIDTH = new ResourceTypeEnum("domain_bandwidth");

            /// <summary>
            /// Enum IPV6 for value: ipv6
            /// </summary>
            public static readonly ResourceTypeEnum IPV6 = new ResourceTypeEnum("ipv6");

            /// <summary>
            /// Enum IPV6_SUPPORT_REGIONS for value: ipv6_support_regions
            /// </summary>
            public static readonly ResourceTypeEnum IPV6_SUPPORT_REGIONS = new ResourceTypeEnum("ipv6_support_regions");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "v2", V2 },
                { "v3", V3 },
                { "billing_mode_period_reduce", BILLING_MODE_PERIOD_REDUCE },
                { "billing_mode_demand", BILLING_MODE_DEMAND },
                { "bwp95", BWP95 },
                { "bwp95Avg", BWP95AVG },
                { "network-quality", NETWORK_QUALITY },
                { "er", ER },
                { "domain_bandwidth", DOMAIN_BANDWIDTH },
                { "ipv6", IPV6 },
                { "ipv6_support_regions", IPV6_SUPPORT_REGIONS },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例创建时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 实例更新时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 租户能力类型，分为： 1. v2：V2的API 2. v3：V3的API 3. billing_mode_period_reduce: 实时降配（包周期） 4. billing_mode_demand: 按需计费（每小时统计打点） 5. bwp95: 按需计费-95（传统95计费方式） 6. bwp95Avg: 按需计费-日95（95峰值平均） 7. network-quality: 丢包和时延统计 8. er：是否支持ER 9. domain_bandwidth：租户带宽值 10. ipv6: 是否支持IPV6 11. ipv6_support_regions: IPV6支持的region列表
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthCapability Bandwidth { get; set; }

        /// <summary>
        /// 租户支持的REGION列表。
        /// </summary>
        [JsonProperty("support_regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportRegions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudConnectionCapability {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  supportRegions: ").Append(SupportRegions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudConnectionCapability);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudConnectionCapability input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.ResourceType != input.ResourceType) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.SupportRegions != input.SupportRegions || (this.SupportRegions != null && input.SupportRegions != null && !this.SupportRegions.SequenceEqual(input.SupportRegions))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.SupportRegions != null) hashCode = hashCode * 59 + this.SupportRegions.GetHashCode();
                return hashCode;
            }
        }
    }
}
