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
    /// Response Object
    /// </summary>
    public class ShowAssetReplicationInfoResponse : SdkResponse
    {

        /// <summary>
        /// 资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 加密后的资产信息。
        /// </summary>
        [JsonProperty("asset_info", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encryption_info", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationEncInfo EncryptionInfo { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetReplicationInfoResponse {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetInfo: ").Append(AssetInfo).Append("\n");
            sb.Append("  encryptionInfo: ").Append(EncryptionInfo).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetReplicationInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetReplicationInfoResponse input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetInfo != input.AssetInfo || (this.AssetInfo != null && !this.AssetInfo.Equals(input.AssetInfo))) return false;
            if (this.EncryptionInfo != input.EncryptionInfo || (this.EncryptionInfo != null && !this.EncryptionInfo.Equals(input.EncryptionInfo))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.AssetInfo != null) hashCode = hashCode * 59 + this.AssetInfo.GetHashCode();
                if (this.EncryptionInfo != null) hashCode = hashCode * 59 + this.EncryptionInfo.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
