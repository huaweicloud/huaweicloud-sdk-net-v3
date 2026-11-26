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
    public class ListAssetFileRequest 
    {

        /// <summary>
        /// 工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc)未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。
        /// </summary>
        [SDKProperty("workspace_id", IsQuery = true)]
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：资产id。 **约束限制**：1-36字符，英文字母，数字，下划线，中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("asset_id", IsPath = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// **参数解释**：列举桶内对象列表时，指定一个前缀，限定返回的对象名必须带有prefix前缀。 **约束限制**：1-1024位字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("prefix", IsQuery = true)]
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        /// <summary>
        /// **参数解释**：列举对象的最大数目，返回的对象列表将是按照字典顺序的最多前max_keys个对象。 **约束限制**：1-1000。 **取值范围**：不涉及。 **默认取值**：1000。
        /// </summary>
        [SDKProperty("max_keys", IsQuery = true)]
        [JsonProperty("max_keys", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetFileRequest {\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("  maxKeys: ").Append(MaxKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetFileRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetFileRequest input)
        {
            if (input == null) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.Prefix != input.Prefix || (this.Prefix != null && !this.Prefix.Equals(input.Prefix))) return false;
            if (this.MaxKeys != input.MaxKeys || (this.MaxKeys != null && !this.MaxKeys.Equals(input.MaxKeys))) return false;

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
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Prefix != null) hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.MaxKeys != null) hashCode = hashCode * 59 + this.MaxKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
