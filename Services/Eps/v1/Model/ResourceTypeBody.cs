using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.v1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceTypeBody 
    {

        /// <summary>
        /// 资源类型名称
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源类型显示名称，可以通过参数中&#39;locale&#39;设置语言
        /// </summary>
        [JsonProperty("resource_type_i18n_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeI18nDisplayName { get; set; }

        /// <summary>
        /// 支持的region列表
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// 是否是全局类型的资源
        /// </summary>
        [JsonProperty("global", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Global { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceTypeBody {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceTypeI18nDisplayName: ").Append(ResourceTypeI18nDisplayName).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("  global: ").Append(Global).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceTypeBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceTypeBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceTypeI18nDisplayName == input.ResourceTypeI18nDisplayName ||
                    (this.ResourceTypeI18nDisplayName != null &&
                    this.ResourceTypeI18nDisplayName.Equals(input.ResourceTypeI18nDisplayName))
                ) && 
                (
                    this.Regions == input.Regions ||
                    this.Regions != null &&
                    input.Regions != null &&
                    this.Regions.SequenceEqual(input.Regions)
                ) && 
                (
                    this.Global == input.Global ||
                    (this.Global != null &&
                    this.Global.Equals(input.Global))
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
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceTypeI18nDisplayName != null)
                    hashCode = hashCode * 59 + this.ResourceTypeI18nDisplayName.GetHashCode();
                if (this.Regions != null)
                    hashCode = hashCode * 59 + this.Regions.GetHashCode();
                if (this.Global != null)
                    hashCode = hashCode * 59 + this.Global.GetHashCode();
                return hashCode;
            }
        }
    }
}
