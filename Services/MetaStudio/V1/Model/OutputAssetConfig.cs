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
    /// 输出视频资产信息配置。
    /// </summary>
    public class OutputAssetConfig 
    {

        /// <summary>
        /// **参数解释**： 输出视频资产名称。 &gt; * 视频资产名称最大长度支持256；文件名称最大长度支持240（超过长度的会被舍弃）  **约束限制**： 不涉及。 **取值范围**： 字符长度0-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputAssetConfig {\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OutputAssetConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OutputAssetConfig input)
        {
            if (input == null) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;

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
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                return hashCode;
            }
        }
    }
}
