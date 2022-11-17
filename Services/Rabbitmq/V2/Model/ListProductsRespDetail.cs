using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListProductsRespDetail 
    {

        /// <summary>
        /// 消息存储空间。
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public string Storage { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 规格ID。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// IO信息。
        /// </summary>
        [JsonProperty("io", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListProductsRespIo> Io { get; set; }

        /// <summary>
        /// 资源售罄的可用区列表。
        /// </summary>
        [JsonProperty("unavailable_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableZones { get; set; }

        /// <summary>
        /// 有可用资源的可用区列表。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 该产品规格对应的虚拟机规格。
        /// </summary>
        [JsonProperty("ecs_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EcsFlavorId { get; set; }

        /// <summary>
        /// 实例规格架构类型。当前仅支持X86。
        /// </summary>
        [JsonProperty("arch_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProductsRespDetail {\n");
            sb.Append("  storage: ").Append(Storage).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  io: ").Append(Io).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  ecsFlavorId: ").Append(EcsFlavorId).Append("\n");
            sb.Append("  archType: ").Append(ArchType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProductsRespDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProductsRespDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.Io == input.Io ||
                    this.Io != null &&
                    input.Io != null &&
                    this.Io.SequenceEqual(input.Io)
                ) && 
                (
                    this.UnavailableZones == input.UnavailableZones ||
                    this.UnavailableZones != null &&
                    input.UnavailableZones != null &&
                    this.UnavailableZones.SequenceEqual(input.UnavailableZones)
                ) && 
                (
                    this.AvailableZones == input.AvailableZones ||
                    this.AvailableZones != null &&
                    input.AvailableZones != null &&
                    this.AvailableZones.SequenceEqual(input.AvailableZones)
                ) && 
                (
                    this.EcsFlavorId == input.EcsFlavorId ||
                    (this.EcsFlavorId != null &&
                    this.EcsFlavorId.Equals(input.EcsFlavorId))
                ) && 
                (
                    this.ArchType == input.ArchType ||
                    (this.ArchType != null &&
                    this.ArchType.Equals(input.ArchType))
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
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.Io != null)
                    hashCode = hashCode * 59 + this.Io.GetHashCode();
                if (this.UnavailableZones != null)
                    hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.EcsFlavorId != null)
                    hashCode = hashCode * 59 + this.EcsFlavorId.GetHashCode();
                if (this.ArchType != null)
                    hashCode = hashCode * 59 + this.ArchType.GetHashCode();
                return hashCode;
            }
        }
    }
}
