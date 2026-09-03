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
    /// 训练产物自动发布配置
    /// </summary>
    public class ArtifactsPublish 
    {

        /// <summary>
        /// 是否是中间产物，false-是模型产物，true-是中间产物
        /// </summary>
        [JsonProperty("is_ckpt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCkpt { get; set; }

        /// <summary>
        /// 断点ID,ckpt发布时使用
        /// </summary>
        [JsonProperty("artifact_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// 模型产物发布后资产名称，默认{源模型名字}-{训练类型}-{训练时间}
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 全局可见性，用来控制资产是当前空间可见或者全部空间可见，取值current|all。
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        /// <summary>
        /// 发布资产描述信息，{任务名}的最终产出模型
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模型发布方式
        /// </summary>
        [JsonProperty("publish_asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishAssetType { get; set; }

        /// <summary>
        /// 资产来源
        /// </summary>
        [JsonProperty("asset_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSourceType { get; set; }

        /// <summary>
        /// 选择模型。
        /// </summary>
        [JsonProperty("asset_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCode { get; set; }

        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("asset_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// 版本描述。
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArtifactsPublish {\n");
            sb.Append("  isCkpt: ").Append(IsCkpt).Append("\n");
            sb.Append("  artifactId: ").Append(ArtifactId).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  publishAssetType: ").Append(PublishAssetType).Append("\n");
            sb.Append("  assetSourceType: ").Append(AssetSourceType).Append("\n");
            sb.Append("  assetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  assetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArtifactsPublish);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ArtifactsPublish input)
        {
            if (input == null) return false;
            if (this.IsCkpt != input.IsCkpt || (this.IsCkpt != null && !this.IsCkpt.Equals(input.IsCkpt))) return false;
            if (this.ArtifactId != input.ArtifactId || (this.ArtifactId != null && !this.ArtifactId.Equals(input.ArtifactId))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.Visibility != input.Visibility || (this.Visibility != null && !this.Visibility.Equals(input.Visibility))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PublishAssetType != input.PublishAssetType || (this.PublishAssetType != null && !this.PublishAssetType.Equals(input.PublishAssetType))) return false;
            if (this.AssetSourceType != input.AssetSourceType || (this.AssetSourceType != null && !this.AssetSourceType.Equals(input.AssetSourceType))) return false;
            if (this.AssetCode != input.AssetCode || (this.AssetCode != null && !this.AssetCode.Equals(input.AssetCode))) return false;
            if (this.AssetVersion != input.AssetVersion || (this.AssetVersion != null && !this.AssetVersion.Equals(input.AssetVersion))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;

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
                if (this.IsCkpt != null) hashCode = hashCode * 59 + this.IsCkpt.GetHashCode();
                if (this.ArtifactId != null) hashCode = hashCode * 59 + this.ArtifactId.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.Visibility != null) hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PublishAssetType != null) hashCode = hashCode * 59 + this.PublishAssetType.GetHashCode();
                if (this.AssetSourceType != null) hashCode = hashCode * 59 + this.AssetSourceType.GetHashCode();
                if (this.AssetCode != null) hashCode = hashCode * 59 + this.AssetCode.GetHashCode();
                if (this.AssetVersion != null) hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
