using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceSpecInfo 
    {

        /// <summary>
        /// 云服务类型编码
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 云服务类型名称
        /// </summary>
        [JsonProperty("cloud_service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceTypeName { get; set; }

        /// <summary>
        /// 资源类型编码
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源类型名称
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// 云服务类型的资源规格编码
        /// </summary>
        [JsonProperty("resource_spec", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpec { get; set; }

        /// <summary>
        /// 云服务类型的资源规格名称
        /// </summary>
        [JsonProperty("resource_spec_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecName { get; set; }

        /// <summary>
        /// 属性列表，need_attributes&#x3D;true时返回属性信息。
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attribute> Attributes { get; set; }

        /// <summary>
        /// 定价列表，need_price&#x3D;true时返回定价信息。
        /// </summary>
        [JsonProperty("price_lists", NullValueHandling = NullValueHandling.Ignore)]
        public List<PriceItem> PriceLists { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceSpecInfo {\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  cloudServiceTypeName: ").Append(CloudServiceTypeName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  resourceSpec: ").Append(ResourceSpec).Append("\n");
            sb.Append("  resourceSpecName: ").Append(ResourceSpecName).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("  priceLists: ").Append(PriceLists).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSpecInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceSpecInfo input)
        {
            if (input == null) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.CloudServiceTypeName != input.CloudServiceTypeName || (this.CloudServiceTypeName != null && !this.CloudServiceTypeName.Equals(input.CloudServiceTypeName))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ResourceSpec != input.ResourceSpec || (this.ResourceSpec != null && !this.ResourceSpec.Equals(input.ResourceSpec))) return false;
            if (this.ResourceSpecName != input.ResourceSpecName || (this.ResourceSpecName != null && !this.ResourceSpecName.Equals(input.ResourceSpecName))) return false;
            if (this.Attributes != input.Attributes || (this.Attributes != null && input.Attributes != null && !this.Attributes.SequenceEqual(input.Attributes))) return false;
            if (this.PriceLists != input.PriceLists || (this.PriceLists != null && input.PriceLists != null && !this.PriceLists.SequenceEqual(input.PriceLists))) return false;

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
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ResourceSpec != null) hashCode = hashCode * 59 + this.ResourceSpec.GetHashCode();
                if (this.ResourceSpecName != null) hashCode = hashCode * 59 + this.ResourceSpecName.GetHashCode();
                if (this.Attributes != null) hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.PriceLists != null) hashCode = hashCode * 59 + this.PriceLists.GetHashCode();
                return hashCode;
            }
        }
    }
}
