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
    public class ShowAssetByCodeAndVersionRequest 
    {

        /// <summary>
        /// **参数解释**：资产code。 **约束限制**：1-60字符，英文字母，数字，中划线，下划线，点。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_code", IsPath = true)]
        [JsonProperty("asset_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCode { get; set; }

        /// <summary>
        /// **参数解释**：资产version。 **约束限制**：数字或为格式x.y.z， x,y,z均为数字。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_version", IsPath = true)]
        [JsonProperty("asset_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// 工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc)未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。
        /// </summary>
        [SDKProperty("workspace_id", IsQuery = true)]
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**:资产类型。 **约束限制**:不涉及。 **取值范围**:不涉及。 **默认取值**:MODEL。
        /// </summary>
        [SDKProperty("asset_type", IsQuery = true)]
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetByCodeAndVersionRequest {\n");
            sb.Append("  assetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  assetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetByCodeAndVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetByCodeAndVersionRequest input)
        {
            if (input == null) return false;
            if (this.AssetCode != input.AssetCode || (this.AssetCode != null && !this.AssetCode.Equals(input.AssetCode))) return false;
            if (this.AssetVersion != input.AssetVersion || (this.AssetVersion != null && !this.AssetVersion.Equals(input.AssetVersion))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.AssetType != input.AssetType || (this.AssetType != null && !this.AssetType.Equals(input.AssetType))) return false;

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
                if (this.AssetCode != null) hashCode = hashCode * 59 + this.AssetCode.GetHashCode();
                if (this.AssetVersion != null) hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.AssetType != null) hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
