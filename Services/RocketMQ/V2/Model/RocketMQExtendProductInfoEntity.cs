using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RocketMQExtendProductInfoEntity 
    {

        /// <summary>
        /// 实例类型。
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
        /// 账单计费类型。
        /// </summary>
        [JsonProperty("billing_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCode { get; set; }

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
        public List<RocketMQExtendProductIosEntity> Ios { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public RocketMQExtendProductPropertiesEntity Properties { get; set; }

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
        /// 支持的特性功能。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public List<RocketMQProductSupportFeaturesEntity> SupportFeatures { get; set; }

        /// <summary>
        /// 是否为擎天实例。
        /// </summary>
        [JsonProperty("qingtian_incompatible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QingtianIncompatible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RocketMQExtendProductInfoEntity {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  ecsFlavorId: ").Append(EcsFlavorId).Append("\n");
            sb.Append("  billingCode: ").Append(BillingCode).Append("\n");
            sb.Append("  archTypes: ").Append(ArchTypes).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  ios: ").Append(Ios).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  qingtianIncompatible: ").Append(QingtianIncompatible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RocketMQExtendProductInfoEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RocketMQExtendProductInfoEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.EcsFlavorId == input.EcsFlavorId ||
                    (this.EcsFlavorId != null &&
                    this.EcsFlavorId.Equals(input.EcsFlavorId))
                ) && 
                (
                    this.BillingCode == input.BillingCode ||
                    (this.BillingCode != null &&
                    this.BillingCode.Equals(input.BillingCode))
                ) && 
                (
                    this.ArchTypes == input.ArchTypes ||
                    this.ArchTypes != null &&
                    input.ArchTypes != null &&
                    this.ArchTypes.SequenceEqual(input.ArchTypes)
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    this.ChargingMode != null &&
                    input.ChargingMode != null &&
                    this.ChargingMode.SequenceEqual(input.ChargingMode)
                ) && 
                (
                    this.Ios == input.Ios ||
                    this.Ios != null &&
                    input.Ios != null &&
                    this.Ios.SequenceEqual(input.Ios)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.AvailableZones == input.AvailableZones ||
                    this.AvailableZones != null &&
                    input.AvailableZones != null &&
                    this.AvailableZones.SequenceEqual(input.AvailableZones)
                ) && 
                (
                    this.UnavailableZones == input.UnavailableZones ||
                    this.UnavailableZones != null &&
                    input.UnavailableZones != null &&
                    this.UnavailableZones.SequenceEqual(input.UnavailableZones)
                ) && 
                (
                    this.SupportFeatures == input.SupportFeatures ||
                    this.SupportFeatures != null &&
                    input.SupportFeatures != null &&
                    this.SupportFeatures.SequenceEqual(input.SupportFeatures)
                ) && 
                (
                    this.QingtianIncompatible == input.QingtianIncompatible ||
                    (this.QingtianIncompatible != null &&
                    this.QingtianIncompatible.Equals(input.QingtianIncompatible))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.EcsFlavorId != null)
                    hashCode = hashCode * 59 + this.EcsFlavorId.GetHashCode();
                if (this.BillingCode != null)
                    hashCode = hashCode * 59 + this.BillingCode.GetHashCode();
                if (this.ArchTypes != null)
                    hashCode = hashCode * 59 + this.ArchTypes.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.Ios != null)
                    hashCode = hashCode * 59 + this.Ios.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.UnavailableZones != null)
                    hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                if (this.SupportFeatures != null)
                    hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.QingtianIncompatible != null)
                    hashCode = hashCode * 59 + this.QingtianIncompatible.GetHashCode();
                return hashCode;
            }
        }
    }
}
