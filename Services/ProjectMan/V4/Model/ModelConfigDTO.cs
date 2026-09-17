using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 模型配置数据对象
    /// </summary>
    public class ModelConfigDTO 
    {

        /// <summary>
        /// **参数解释**： 工作项属性。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseCategory> Categories { get; set; }

        /// <summary>
        /// **参数解释**： 工作项层级关系。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("category_layer_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryLayerDTO> CategoryLayerConfig { get; set; }

        /// <summary>
        /// **参数解释**： 工作项功能页面跳转链接模板。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("feature_page_link_template", NullValueHandling = NullValueHandling.Ignore)]
        public string FeaturePageLinkTemplate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelConfigDTO {\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  categoryLayerConfig: ").Append(CategoryLayerConfig).Append("\n");
            sb.Append("  featurePageLinkTemplate: ").Append(FeaturePageLinkTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelConfigDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelConfigDTO input)
        {
            if (input == null) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;
            if (this.CategoryLayerConfig != input.CategoryLayerConfig || (this.CategoryLayerConfig != null && input.CategoryLayerConfig != null && !this.CategoryLayerConfig.SequenceEqual(input.CategoryLayerConfig))) return false;
            if (this.FeaturePageLinkTemplate != input.FeaturePageLinkTemplate || (this.FeaturePageLinkTemplate != null && !this.FeaturePageLinkTemplate.Equals(input.FeaturePageLinkTemplate))) return false;

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
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.CategoryLayerConfig != null) hashCode = hashCode * 59 + this.CategoryLayerConfig.GetHashCode();
                if (this.FeaturePageLinkTemplate != null) hashCode = hashCode * 59 + this.FeaturePageLinkTemplate.GetHashCode();
                return hashCode;
            }
        }
    }
}
