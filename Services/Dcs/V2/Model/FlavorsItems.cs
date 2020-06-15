using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlavorsItems 
    {

        /// <summary>
        /// 产品规格编码。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 云服务类型编码。
        /// </summary>
        [JsonProperty("cloud_service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceTypeCode { get; set; }

        /// <summary>
        /// 云资源类型编码。
        /// </summary>
        [JsonProperty("cloud_resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudResourceTypeCode { get; set; }

        /// <summary>
        /// 缓存实例类型。取值范围如下： - single：表示单机实例 - ha：表示主备实例 - cluster：表示cluster集群实例 - proxy：表示Proxy集群实例 
        /// </summary>
        [JsonProperty("cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string CacheMode { get; set; }

        /// <summary>
        /// 缓存引擎类型。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 缓存版本，当缓存引擎为Redis时，取值为3.0、4.0或5.0。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Redis缓存实例的产品类型。取值当前仅支持： generic：标准类型 
        /// </summary>
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductType { get; set; }

        /// <summary>
        /// CPU架构类型。取值范围如下： - X86_64：X86架构 - aarch64: ARM架构 
        /// </summary>
        [JsonProperty("cpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuType { get; set; }

        /// <summary>
        /// 存储类型，取值当前仅支持： DRAM:内存存储 
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// 缓存容量（G Byte）。
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Capacity { get; set; }

        /// <summary>
        /// 计费模式，取值范围如下： - Hourly：按需计费 - Monthly: 包月计费 - Yearly: 包周期计费 
        /// </summary>
        [JsonProperty("billing_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BillingMode { get; set; }

        /// <summary>
        /// 租户侧IP数量。
        /// </summary>
        [JsonProperty("tenant_ip_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TenantIpCount { get; set; }

        /// <summary>
        /// 定价类型，取值如下： - tier: 阶梯定价，一个规格对应多个容量 - normal: 规格和容量一一对应 
        /// </summary>
        [JsonProperty("pricing_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PricingType { get; set; }

        /// <summary>
        /// 是否支持专属云。
        /// </summary>
        [JsonProperty("is_dec", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDec { get; set; }

        /// <summary>
        /// 规格的其他信息。
        /// </summary>
        [JsonProperty("attrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttrsObject> Attrs { get; set; }

        /// <summary>
        /// 有资源的可用区。
        /// </summary>
        [JsonProperty("flavors_available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlavorAzObject> FlavorsAvailableZones { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorsItems {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  cloudServiceTypeCode: ").Append(CloudServiceTypeCode).Append("\n");
            sb.Append("  cloudResourceTypeCode: ").Append(CloudResourceTypeCode).Append("\n");
            sb.Append("  cacheMode: ").Append(CacheMode).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  productType: ").Append(ProductType).Append("\n");
            sb.Append("  cpuType: ").Append(CpuType).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  tenantIpCount: ").Append(TenantIpCount).Append("\n");
            sb.Append("  pricingType: ").Append(PricingType).Append("\n");
            sb.Append("  isDec: ").Append(IsDec).Append("\n");
            sb.Append("  attrs: ").Append(Attrs).Append("\n");
            sb.Append("  flavorsAvailableZones: ").Append(FlavorsAvailableZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorsItems);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorsItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.CloudServiceTypeCode == input.CloudServiceTypeCode ||
                    (this.CloudServiceTypeCode != null &&
                    this.CloudServiceTypeCode.Equals(input.CloudServiceTypeCode))
                ) && 
                (
                    this.CloudResourceTypeCode == input.CloudResourceTypeCode ||
                    (this.CloudResourceTypeCode != null &&
                    this.CloudResourceTypeCode.Equals(input.CloudResourceTypeCode))
                ) && 
                (
                    this.CacheMode == input.CacheMode ||
                    (this.CacheMode != null &&
                    this.CacheMode.Equals(input.CacheMode))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.CpuType == input.CpuType ||
                    (this.CpuType != null &&
                    this.CpuType.Equals(input.CpuType))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    this.Capacity != null &&
                    input.Capacity != null &&
                    this.Capacity.SequenceEqual(input.Capacity)
                ) && 
                (
                    this.BillingMode == input.BillingMode ||
                    this.BillingMode != null &&
                    input.BillingMode != null &&
                    this.BillingMode.SequenceEqual(input.BillingMode)
                ) && 
                (
                    this.TenantIpCount == input.TenantIpCount ||
                    (this.TenantIpCount != null &&
                    this.TenantIpCount.Equals(input.TenantIpCount))
                ) && 
                (
                    this.PricingType == input.PricingType ||
                    (this.PricingType != null &&
                    this.PricingType.Equals(input.PricingType))
                ) && 
                (
                    this.IsDec == input.IsDec ||
                    (this.IsDec != null &&
                    this.IsDec.Equals(input.IsDec))
                ) && 
                (
                    this.Attrs == input.Attrs ||
                    this.Attrs != null &&
                    input.Attrs != null &&
                    this.Attrs.SequenceEqual(input.Attrs)
                ) && 
                (
                    this.FlavorsAvailableZones == input.FlavorsAvailableZones ||
                    this.FlavorsAvailableZones != null &&
                    input.FlavorsAvailableZones != null &&
                    this.FlavorsAvailableZones.SequenceEqual(input.FlavorsAvailableZones)
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
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.CloudServiceTypeCode != null)
                    hashCode = hashCode * 59 + this.CloudServiceTypeCode.GetHashCode();
                if (this.CloudResourceTypeCode != null)
                    hashCode = hashCode * 59 + this.CloudResourceTypeCode.GetHashCode();
                if (this.CacheMode != null)
                    hashCode = hashCode * 59 + this.CacheMode.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.CpuType != null)
                    hashCode = hashCode * 59 + this.CpuType.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.BillingMode != null)
                    hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.TenantIpCount != null)
                    hashCode = hashCode * 59 + this.TenantIpCount.GetHashCode();
                if (this.PricingType != null)
                    hashCode = hashCode * 59 + this.PricingType.GetHashCode();
                if (this.IsDec != null)
                    hashCode = hashCode * 59 + this.IsDec.GetHashCode();
                if (this.Attrs != null)
                    hashCode = hashCode * 59 + this.Attrs.GetHashCode();
                if (this.FlavorsAvailableZones != null)
                    hashCode = hashCode * 59 + this.FlavorsAvailableZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
