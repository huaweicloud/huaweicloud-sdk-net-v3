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
    public class ShowAssetResourceRequest 
    {

        /// <summary>
        /// **参数解释**：资产id。 **约束限制**：1-36字符，英文字母，数字，下划线，中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_id", IsPath = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc)未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。
        /// </summary>
        [SDKProperty("workspace_id", IsQuery = true)]
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：静态资源名称。 **约束限制**：当前只支持readme文件查询（docs/RELEASE.md）。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("resource_name", IsQuery = true)]
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// **参数解释**：查询资源时是否拼接区域信息。如果为false，则直接查询docs/RELEASE.md文件；如果为true，则会优先匹配带有区域信息的文件（请求头传递x-language，如英文查询docs/RELEASE_en-US.md）。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("check_locale", IsQuery = true)]
        [JsonProperty("check_locale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckLocale { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetResourceRequest {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  checkLocale: ").Append(CheckLocale).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetResourceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetResourceRequest input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.CheckLocale != input.CheckLocale || (this.CheckLocale != null && !this.CheckLocale.Equals(input.CheckLocale))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.CheckLocale != null) hashCode = hashCode * 59 + this.CheckLocale.GetHashCode();
                return hashCode;
            }
        }
    }
}
