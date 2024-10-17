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
    public class ShowAssetCipherResponse : SdkResponse
    {

        /// <summary>
        /// 媒资ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 密钥密文。
        /// </summary>
        [JsonProperty("edk", NullValueHandling = NullValueHandling.Ignore)]
        public string Edk { get; set; }

        /// <summary>
        /// 密钥明文。
        /// </summary>
        [JsonProperty("dk", NullValueHandling = NullValueHandling.Ignore)]
        public string Dk { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetCipherResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  edk: ").Append(Edk).Append("\n");
            sb.Append("  dk: ").Append(Dk).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetCipherResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetCipherResponse input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.Edk != input.Edk || (this.Edk != null && !this.Edk.Equals(input.Edk))) return false;
            if (this.Dk != input.Dk || (this.Dk != null && !this.Dk.Equals(input.Dk))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Edk != null) hashCode = hashCode * 59 + this.Edk.GetHashCode();
                if (this.Dk != null) hashCode = hashCode * 59 + this.Dk.GetHashCode();
                return hashCode;
            }
        }
    }
}
