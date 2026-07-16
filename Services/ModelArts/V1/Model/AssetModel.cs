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
    /// **参数解释**：自定义训练作业产物发布成模型的信息。
    /// </summary>
    public class AssetModel 
    {

        /// <summary>
        /// **参数解释**：模型名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：模型名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**：模型发布版本。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**：模型描述。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// **参数解释**：模型品牌。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public string Series { get; set; }

        /// <summary>
        /// **参数解释**：模型类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：模型资产描述。\\n**取值范围**：不涉及。
        /// </summary>
        [JsonProperty("model_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelDesc { get; set; }

        /// <summary>
        /// **参数解释**：父资产ID（可选），选择已有模型时传递。\\n**取值范围**：不涉及。
        /// </summary>
        [JsonProperty("parent_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentAssetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetModel {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  series: ").Append(Series).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  modelDesc: ").Append(ModelDesc).Append("\n");
            sb.Append("  parentAssetId: ").Append(ParentAssetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetModel input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.Series != input.Series || (this.Series != null && !this.Series.Equals(input.Series))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ModelDesc != input.ModelDesc || (this.ModelDesc != null && !this.ModelDesc.Equals(input.ModelDesc))) return false;
            if (this.ParentAssetId != input.ParentAssetId || (this.ParentAssetId != null && !this.ParentAssetId.Equals(input.ParentAssetId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.Series != null) hashCode = hashCode * 59 + this.Series.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ModelDesc != null) hashCode = hashCode * 59 + this.ModelDesc.GetHashCode();
                if (this.ParentAssetId != null) hashCode = hashCode * 59 + this.ParentAssetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
