using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowAssetTagsInfoRequest 
    {

        /// <summary>
        /// **参数解释**：标签分类。 **约束限制**：1-128位字符，仅支持中文、英文字母、数字、下划线和中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("tag_category", IsPath = true)]
        [JsonProperty("tag_category", NullValueHandling = NullValueHandling.Ignore)]
        public string TagCategory { get; set; }

        /// <summary>
        /// **参数解释**：请求头（Header）参数，主要用于控制API返回内容的语言。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc)未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。
        /// </summary>
        [SDKProperty("workspace_id", IsQuery = true)]
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetTagsInfoRequest {\n");
            sb.Append("  tagCategory: ").Append(TagCategory).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetTagsInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetTagsInfoRequest input)
        {
            if (input == null) return false;
            if (this.TagCategory != input.TagCategory || (this.TagCategory != null && !this.TagCategory.Equals(input.TagCategory))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;

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
                if (this.TagCategory != null) hashCode = hashCode * 59 + this.TagCategory.GetHashCode();
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
