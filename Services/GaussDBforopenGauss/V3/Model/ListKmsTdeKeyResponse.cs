using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListKmsTdeKeyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: kms秘钥列表。
        /// </summary>
        [JsonProperty("key_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListKmsTdeKeyResponseBodyKeyDetails> KeyDetails { get; set; }

        /// <summary>
        /// **参数解释**: 授权用户ID，在开启透明加密能力时，必须对当前用户ID进行授权。 授权操作参考创建授权接口 https://support.huaweicloud.com/api-dew/CreateGrant.html。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("authorized_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizedId { get; set; }

        /// <summary>
        /// **参数解释**: 授权用户名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("authorized_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizedName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKmsTdeKeyResponse {\n");
            sb.Append("  keyDetails: ").Append(KeyDetails).Append("\n");
            sb.Append("  authorizedId: ").Append(AuthorizedId).Append("\n");
            sb.Append("  authorizedName: ").Append(AuthorizedName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKmsTdeKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKmsTdeKeyResponse input)
        {
            if (input == null) return false;
            if (this.KeyDetails != input.KeyDetails || (this.KeyDetails != null && input.KeyDetails != null && !this.KeyDetails.SequenceEqual(input.KeyDetails))) return false;
            if (this.AuthorizedId != input.AuthorizedId || (this.AuthorizedId != null && !this.AuthorizedId.Equals(input.AuthorizedId))) return false;
            if (this.AuthorizedName != input.AuthorizedName || (this.AuthorizedName != null && !this.AuthorizedName.Equals(input.AuthorizedName))) return false;

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
                if (this.KeyDetails != null) hashCode = hashCode * 59 + this.KeyDetails.GetHashCode();
                if (this.AuthorizedId != null) hashCode = hashCode * 59 + this.AuthorizedId.GetHashCode();
                if (this.AuthorizedName != null) hashCode = hashCode * 59 + this.AuthorizedName.GetHashCode();
                return hashCode;
            }
        }
    }
}
