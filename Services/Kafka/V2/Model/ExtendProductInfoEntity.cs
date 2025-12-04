using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtendProductInfoEntity 
    {

        /// <summary>
        /// **参数解释**： 实例类型。 **取值范围**： - single：单机。 - cluster：集群。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 该产品使用的ECS规格。
        /// </summary>
        [JsonProperty("ecs_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsFlavorId { get; set; }

        /// <summary>
        /// 支持的CPU架构类型。
        /// </summary>
        [JsonProperty("arch_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ArchTypes { get; set; }

        /// <summary>
        /// 支持的计费模式类型。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChargingMode { get; set; }

        /// <summary>
        /// 磁盘IO信息。
        /// </summary>
        [JsonProperty("ios", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtendProductIosEntity> Ios { get; set; }

        /// <summary>
        /// 支持的特性功能。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtendProductSupportFeaturesEntity> SupportFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public ExtendProductPropertiesEntity Properties { get; set; }

        /// <summary>
        /// 有可用资源的可用区列表。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 资源售罄的可用区列表。
        /// </summary>
        [JsonProperty("unavailable_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableZones { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendProductInfoEntity {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  ecsFlavorId: ").Append(EcsFlavorId).Append("\n");
            sb.Append("  archTypes: ").Append(ArchTypes).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  ios: ").Append(Ios).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtendProductInfoEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtendProductInfoEntity input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.EcsFlavorId != input.EcsFlavorId || (this.EcsFlavorId != null && !this.EcsFlavorId.Equals(input.EcsFlavorId))) return false;
            if (this.ArchTypes != input.ArchTypes || (this.ArchTypes != null && input.ArchTypes != null && !this.ArchTypes.SequenceEqual(input.ArchTypes))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && input.ChargingMode != null && !this.ChargingMode.SequenceEqual(input.ChargingMode))) return false;
            if (this.Ios != input.Ios || (this.Ios != null && input.Ios != null && !this.Ios.SequenceEqual(input.Ios))) return false;
            if (this.SupportFeatures != input.SupportFeatures || (this.SupportFeatures != null && input.SupportFeatures != null && !this.SupportFeatures.SequenceEqual(input.SupportFeatures))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.UnavailableZones != input.UnavailableZones || (this.UnavailableZones != null && input.UnavailableZones != null && !this.UnavailableZones.SequenceEqual(input.UnavailableZones))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.EcsFlavorId != null) hashCode = hashCode * 59 + this.EcsFlavorId.GetHashCode();
                if (this.ArchTypes != null) hashCode = hashCode * 59 + this.ArchTypes.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.Ios != null) hashCode = hashCode * 59 + this.Ios.GetHashCode();
                if (this.SupportFeatures != null) hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.UnavailableZones != null) hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
