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
    /// 服务开通请求
    /// </summary>
    public class CreateProductRequestBody 
    {

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 标签。单个标签16字节，多个用逗号分隔，最多50个。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public ProductCoverInfo Cover { get; set; }

        /// <summary>
        /// 文本列表
        /// </summary>
        [JsonProperty("text_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductTextInfo> TextList { get; set; }

        /// <summary>
        /// 资产列表,仅支持图片、视频、音频资产
        /// </summary>
        [JsonProperty("asset_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductMediaInfo> AssetList { get; set; }

        /// <summary>
        /// **参数解释**： 自动激活商品
        /// </summary>
        [JsonProperty("auto_active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoActive { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProductRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  cover: ").Append(Cover).Append("\n");
            sb.Append("  textList: ").Append(TextList).Append("\n");
            sb.Append("  assetList: ").Append(AssetList).Append("\n");
            sb.Append("  autoActive: ").Append(AutoActive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProductRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProductRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Cover != input.Cover || (this.Cover != null && !this.Cover.Equals(input.Cover))) return false;
            if (this.TextList != input.TextList || (this.TextList != null && input.TextList != null && !this.TextList.SequenceEqual(input.TextList))) return false;
            if (this.AssetList != input.AssetList || (this.AssetList != null && input.AssetList != null && !this.AssetList.SequenceEqual(input.AssetList))) return false;
            if (this.AutoActive != input.AutoActive || (this.AutoActive != null && !this.AutoActive.Equals(input.AutoActive))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Cover != null) hashCode = hashCode * 59 + this.Cover.GetHashCode();
                if (this.TextList != null) hashCode = hashCode * 59 + this.TextList.GetHashCode();
                if (this.AssetList != null) hashCode = hashCode * 59 + this.AssetList.GetHashCode();
                if (this.AutoActive != null) hashCode = hashCode * 59 + this.AutoActive.GetHashCode();
                return hashCode;
            }
        }
    }
}
