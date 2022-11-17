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
    public class CheckMd5DuplicationResponse : SdkResponse
    {

        /// <summary>
        /// 是否重复。  取值如下： - 0：表示不重复。 - 1：表示重复。
        /// </summary>
        [JsonProperty("is_duplicated", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsDuplicated { get; set; }

        /// <summary>
        /// 重复的媒资ID
        /// </summary>
        [JsonProperty("asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckMd5DuplicationResponse {\n");
            sb.Append("  isDuplicated: ").Append(IsDuplicated).Append("\n");
            sb.Append("  assetIds: ").Append(AssetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckMd5DuplicationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckMd5DuplicationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsDuplicated == input.IsDuplicated ||
                    (this.IsDuplicated != null &&
                    this.IsDuplicated.Equals(input.IsDuplicated))
                ) && 
                (
                    this.AssetIds == input.AssetIds ||
                    this.AssetIds != null &&
                    input.AssetIds != null &&
                    this.AssetIds.SequenceEqual(input.AssetIds)
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
                if (this.IsDuplicated != null)
                    hashCode = hashCode * 59 + this.IsDuplicated.GetHashCode();
                if (this.AssetIds != null)
                    hashCode = hashCode * 59 + this.AssetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
