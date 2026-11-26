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
    public class DeleteAssetRequest 
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
        /// **参数解释**：数据集资产是否删除OBS桶中的数据，boolean类型，取值true：删除OBS桶中的数据，取值false：仅删除记录不删除OBS桶中的数据。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("force_delete", IsQuery = true)]
        [JsonProperty("force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceDelete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAssetRequest {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  forceDelete: ").Append(ForceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAssetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAssetRequest input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.ForceDelete != input.ForceDelete || (this.ForceDelete != null && !this.ForceDelete.Equals(input.ForceDelete))) return false;

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
                if (this.ForceDelete != null) hashCode = hashCode * 59 + this.ForceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
