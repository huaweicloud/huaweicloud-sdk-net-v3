using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GpgSubKeyDto 
    {

        /// <summary>
        /// **参数解释：** 子公钥subkey的id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 子公钥的指纹格式。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// **参数解释：** gpg_key的id。
        /// </summary>
        [JsonProperty("gpg_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? GpgKeyId { get; set; }

        /// <summary>
        /// **参数解释：** 子密钥的id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("keyid", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GpgSubKeyDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  gpgKeyId: ").Append(GpgKeyId).Append("\n");
            sb.Append("  keyid: ").Append(Keyid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GpgSubKeyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GpgSubKeyDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Fingerprint != input.Fingerprint || (this.Fingerprint != null && !this.Fingerprint.Equals(input.Fingerprint))) return false;
            if (this.GpgKeyId != input.GpgKeyId || (this.GpgKeyId != null && !this.GpgKeyId.Equals(input.GpgKeyId))) return false;
            if (this.Keyid != input.Keyid || (this.Keyid != null && !this.Keyid.Equals(input.Keyid))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Fingerprint != null) hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.GpgKeyId != null) hashCode = hashCode * 59 + this.GpgKeyId.GetHashCode();
                if (this.Keyid != null) hashCode = hashCode * 59 + this.Keyid.GetHashCode();
                return hashCode;
            }
        }
    }
}
