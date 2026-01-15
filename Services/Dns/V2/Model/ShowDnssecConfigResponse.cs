using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDnssecConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 域名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }

        /// <summary>
        /// **参数解释：** 密钥标签。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("key_tag", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeyTag { get; set; }

        /// <summary>
        /// **参数解释：** 旗标。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Flag { get; set; }

        /// <summary>
        /// **参数解释：** 摘要算法。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("digest_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string DigestAlgorithm { get; set; }

        /// <summary>
        /// **参数解释：** 摘要算法类型。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("digest_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DigestType { get; set; }

        /// <summary>
        /// **参数解释：** 摘要。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("digest", NullValueHandling = NullValueHandling.Ignore)]
        public string Digest { get; set; }

        /// <summary>
        /// **参数解释：** 签名算法。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// **参数解释：** 签名算法类型。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("signature_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SignatureType { get; set; }

        /// <summary>
        /// **参数解释：** 公有密钥。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("ksk_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string KskPublicKey { get; set; }

        /// <summary>
        /// **参数解释：** DS记录。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("ds_record", NullValueHandling = NullValueHandling.Ignore)]
        public string DsRecord { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 状态。 **取值范围：** - ENABLE：启用 - DISABLE：关闭
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDnssecConfigResponse {\n");
            sb.Append("  zoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  keyTag: ").Append(KeyTag).Append("\n");
            sb.Append("  flag: ").Append(Flag).Append("\n");
            sb.Append("  digestAlgorithm: ").Append(DigestAlgorithm).Append("\n");
            sb.Append("  digestType: ").Append(DigestType).Append("\n");
            sb.Append("  digest: ").Append(Digest).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("  signatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  kskPublicKey: ").Append(KskPublicKey).Append("\n");
            sb.Append("  dsRecord: ").Append(DsRecord).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDnssecConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDnssecConfigResponse input)
        {
            if (input == null) return false;
            if (this.ZoneName != input.ZoneName || (this.ZoneName != null && !this.ZoneName.Equals(input.ZoneName))) return false;
            if (this.KeyTag != input.KeyTag || (this.KeyTag != null && !this.KeyTag.Equals(input.KeyTag))) return false;
            if (this.Flag != input.Flag || (this.Flag != null && !this.Flag.Equals(input.Flag))) return false;
            if (this.DigestAlgorithm != input.DigestAlgorithm || (this.DigestAlgorithm != null && !this.DigestAlgorithm.Equals(input.DigestAlgorithm))) return false;
            if (this.DigestType != input.DigestType || (this.DigestType != null && !this.DigestType.Equals(input.DigestType))) return false;
            if (this.Digest != input.Digest || (this.Digest != null && !this.Digest.Equals(input.Digest))) return false;
            if (this.Signature != input.Signature || (this.Signature != null && !this.Signature.Equals(input.Signature))) return false;
            if (this.SignatureType != input.SignatureType || (this.SignatureType != null && !this.SignatureType.Equals(input.SignatureType))) return false;
            if (this.KskPublicKey != input.KskPublicKey || (this.KskPublicKey != null && !this.KskPublicKey.Equals(input.KskPublicKey))) return false;
            if (this.DsRecord != input.DsRecord || (this.DsRecord != null && !this.DsRecord.Equals(input.DsRecord))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ZoneName != null) hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.KeyTag != null) hashCode = hashCode * 59 + this.KeyTag.GetHashCode();
                if (this.Flag != null) hashCode = hashCode * 59 + this.Flag.GetHashCode();
                if (this.DigestAlgorithm != null) hashCode = hashCode * 59 + this.DigestAlgorithm.GetHashCode();
                if (this.DigestType != null) hashCode = hashCode * 59 + this.DigestType.GetHashCode();
                if (this.Digest != null) hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Signature != null) hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.SignatureType != null) hashCode = hashCode * 59 + this.SignatureType.GetHashCode();
                if (this.KskPublicKey != null) hashCode = hashCode * 59 + this.KskPublicKey.GetHashCode();
                if (this.DsRecord != null) hashCode = hashCode * 59 + this.DsRecord.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
