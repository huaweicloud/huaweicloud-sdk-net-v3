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
    /// **参数解释**： 产品规格的详细信息。
    /// </summary>
    public class ListEngineProductsEntity 
    {

        /// <summary>
        /// **参数解释**： 产品类型。 **取值范围**： - single    - cluster
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 产品ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释**： 底层资源类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ecs_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsFlavorId { get; set; }

        /// <summary>
        /// **参数解释**： 账单计费类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("billing_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCode { get; set; }

        /// <summary>
        /// **参数解释**： CPU架构。
        /// </summary>
        [JsonProperty("arch_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ArchTypes { get; set; }

        /// <summary>
        /// **参数解释**： 计费模式。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ChargingMode { get; set; }

        /// <summary>
        /// **参数解释**： 支持的磁盘IO类型列表。
        /// </summary>
        [JsonProperty("ios", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListEngineIosEntity> Ios { get; set; }

        /// <summary>
        /// **参数解释**： 当前规格实例支持的功能特性列表。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListEngineSupportFeaturesEntity> SupportFeatures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public ListEnginePropertiesEntity Properties { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEngineProductsEntity {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  ecsFlavorId: ").Append(EcsFlavorId).Append("\n");
            sb.Append("  billingCode: ").Append(BillingCode).Append("\n");
            sb.Append("  archTypes: ").Append(ArchTypes).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  ios: ").Append(Ios).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEngineProductsEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEngineProductsEntity input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.EcsFlavorId != input.EcsFlavorId || (this.EcsFlavorId != null && !this.EcsFlavorId.Equals(input.EcsFlavorId))) return false;
            if (this.BillingCode != input.BillingCode || (this.BillingCode != null && !this.BillingCode.Equals(input.BillingCode))) return false;
            if (this.ArchTypes != input.ArchTypes || (this.ArchTypes != null && input.ArchTypes != null && !this.ArchTypes.SequenceEqual(input.ArchTypes))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && input.ChargingMode != null && !this.ChargingMode.SequenceEqual(input.ChargingMode))) return false;
            if (this.Ios != input.Ios || (this.Ios != null && input.Ios != null && !this.Ios.SequenceEqual(input.Ios))) return false;
            if (this.SupportFeatures != input.SupportFeatures || (this.SupportFeatures != null && input.SupportFeatures != null && !this.SupportFeatures.SequenceEqual(input.SupportFeatures))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;

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
                return hashCode;
            }
        }
    }
}
