using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class PublishAssetsResponse : SdkResponse
    {

        /// <summary>
        /// 发布的媒资信息。
        /// </summary>
        [JsonProperty("asset_info_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetInfo> AssetInfoArray { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublishAssetsResponse {\n");
            sb.Append("  assetInfoArray: ").Append(AssetInfoArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublishAssetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublishAssetsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetInfoArray == input.AssetInfoArray ||
                    this.AssetInfoArray != null &&
                    input.AssetInfoArray != null &&
                    this.AssetInfoArray.SequenceEqual(input.AssetInfoArray)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AssetInfoArray != null)
                    hashCode = hashCode * 59 + this.AssetInfoArray.GetHashCode();
                return hashCode;
            }
        }
    }
}
