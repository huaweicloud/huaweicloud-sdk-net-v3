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
    /// 
    /// </summary>
    public class ListAssetSummarysReq 
    {

        /// <summary>
        /// 需要查询的资产ID。
        /// </summary>
        [JsonProperty("asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetSummarysReq {\n");
            sb.Append("  assetIds: ").Append(AssetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetSummarysReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetSummarysReq input)
        {
            if (input == null) return false;
            if (this.AssetIds != input.AssetIds || (this.AssetIds != null && input.AssetIds != null && !this.AssetIds.SequenceEqual(input.AssetIds))) return false;

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
                if (this.AssetIds != null) hashCode = hashCode * 59 + this.AssetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
