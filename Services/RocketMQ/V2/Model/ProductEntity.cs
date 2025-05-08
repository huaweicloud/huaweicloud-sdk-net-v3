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
    public class ProductEntity 
    {

        /// <summary>
        /// **参数解释**： 产品类型。 **取值范围**： - single：单机。 - cluster：集群。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 产品ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释**： ECS的Flavor ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ecs_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsFlavorId { get; set; }

        /// <summary>
        /// **参数解释**： CBC的规格码。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("billing_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCode { get; set; }

        /// <summary>
        /// **参数解释**： 架构类型。
        /// </summary>
        [JsonProperty("arch_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ArchTypes { get; set; }

        /// <summary>
        /// **参数解释**： 计费模式。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public Object ChargingMode { get; set; }

        /// <summary>
        /// **参数解释**： 支持的io类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ios", NullValueHandling = NullValueHandling.Ignore)]
        public Object Ios { get; set; }

        /// <summary>
        /// **参数解释**： 支持的特性。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public Object SupportFeatures { get; set; }

        /// <summary>
        /// **参数解释**： 产品特性。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Object Properties { get; set; }

        /// <summary>
        /// **参数解释**： 可用分区。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 不可用分区。
        /// </summary>
        [JsonProperty("unavailable_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 是否为擎天实例。 **取值范围**： - true：是 - false：否
        /// </summary>
        [JsonProperty("qingtian_incompatible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QingtianIncompatible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductEntity {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  ecsFlavorId: ").Append(EcsFlavorId).Append("\n");
            sb.Append("  billingCode: ").Append(BillingCode).Append("\n");
            sb.Append("  archTypes: ").Append(ArchTypes).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  ios: ").Append(Ios).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("  qingtianIncompatible: ").Append(QingtianIncompatible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductEntity input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.EcsFlavorId != input.EcsFlavorId || (this.EcsFlavorId != null && !this.EcsFlavorId.Equals(input.EcsFlavorId))) return false;
            if (this.BillingCode != input.BillingCode || (this.BillingCode != null && !this.BillingCode.Equals(input.BillingCode))) return false;
            if (this.ArchTypes != input.ArchTypes || (this.ArchTypes != null && input.ArchTypes != null && !this.ArchTypes.SequenceEqual(input.ArchTypes))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.Ios != input.Ios || (this.Ios != null && !this.Ios.Equals(input.Ios))) return false;
            if (this.SupportFeatures != input.SupportFeatures || (this.SupportFeatures != null && !this.SupportFeatures.Equals(input.SupportFeatures))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.UnavailableZones != input.UnavailableZones || (this.UnavailableZones != null && input.UnavailableZones != null && !this.UnavailableZones.SequenceEqual(input.UnavailableZones))) return false;
            if (this.QingtianIncompatible != input.QingtianIncompatible || (this.QingtianIncompatible != null && !this.QingtianIncompatible.Equals(input.QingtianIncompatible))) return false;

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
                if (this.BillingCode != null) hashCode = hashCode * 59 + this.BillingCode.GetHashCode();
                if (this.ArchTypes != null) hashCode = hashCode * 59 + this.ArchTypes.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.Ios != null) hashCode = hashCode * 59 + this.Ios.GetHashCode();
                if (this.SupportFeatures != null) hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.UnavailableZones != null) hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                if (this.QingtianIncompatible != null) hashCode = hashCode * 59 + this.QingtianIncompatible.GetHashCode();
                return hashCode;
            }
        }
    }
}
