using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 云服务详情
    /// </summary>
    public class ResourceProviderResponse 
    {

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 云服务显示名称，可以通过请求Header中的&#39;X-Language&#39;设置语言
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 云服务类别显示名称，可以通过请求Header中的&#39;X-Language&#39;设置语言
        /// </summary>
        [JsonProperty("category_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryDisplayName { get; set; }

        /// <summary>
        /// 资源类型列表
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTypeResponse> ResourceTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceProviderResponse {\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  categoryDisplayName: ").Append(CategoryDisplayName).Append("\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceProviderResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceProviderResponse input)
        {
            if (input == null) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.CategoryDisplayName != input.CategoryDisplayName || (this.CategoryDisplayName != null && !this.CategoryDisplayName.Equals(input.CategoryDisplayName))) return false;
            if (this.ResourceTypes != input.ResourceTypes || (this.ResourceTypes != null && input.ResourceTypes != null && !this.ResourceTypes.SequenceEqual(input.ResourceTypes))) return false;

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
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CategoryDisplayName != null) hashCode = hashCode * 59 + this.CategoryDisplayName.GetHashCode();
                if (this.ResourceTypes != null) hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
