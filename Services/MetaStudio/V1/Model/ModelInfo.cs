using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 模型信息
    /// </summary>
    public class ModelInfo 
    {

        /// <summary>
        /// 模型资产ID，可以从资产库中查询。
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 主播轮换时备选主播数字人资产ID（仅形象资产，不包含音色），可以从资产库中查询。
        /// </summary>
        [JsonProperty("backup_model_asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BackupModelAssetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelInfo {\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  backupModelAssetIds: ").Append(BackupModelAssetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelInfo input)
        {
            if (input == null) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.BackupModelAssetIds != input.BackupModelAssetIds || (this.BackupModelAssetIds != null && input.BackupModelAssetIds != null && !this.BackupModelAssetIds.SequenceEqual(input.BackupModelAssetIds))) return false;

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
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.BackupModelAssetIds != null) hashCode = hashCode * 59 + this.BackupModelAssetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
