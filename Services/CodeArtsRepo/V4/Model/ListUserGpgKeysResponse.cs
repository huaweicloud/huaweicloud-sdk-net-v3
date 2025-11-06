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
    /// Response Object
    /// </summary>
    public class ListUserGpgKeysResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 解析到的邮箱列表以及是否生效。
        /// </summary>
        [JsonProperty("emails_with_verified_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool?> EmailsWithVerifiedStatus { get; set; }

        /// <summary>
        /// **参数解释：** 主密/公钥的指纹格式。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// **参数解释：** gpg的公钥。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释：** 描述。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** gpg_key的标题。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释：** 主密/公钥primary_key的id。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("primary_keyid", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryKeyid { get; set; }

        /// <summary>
        /// **参数解释：** 是否生效。
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// **参数解释：** 子钥列表。 **取值范围：** 列表长度不少于0，不超过1000。
        /// </summary>
        [JsonProperty("subkeys", NullValueHandling = NullValueHandling.Ignore)]
        public List<GpgSubKeyDto> Subkeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUserGpgKeysResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  emailsWithVerifiedStatus: ").Append(EmailsWithVerifiedStatus).Append("\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  primaryKeyid: ").Append(PrimaryKeyid).Append("\n");
            sb.Append("  active: ").Append(Active).Append("\n");
            sb.Append("  subkeys: ").Append(Subkeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUserGpgKeysResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUserGpgKeysResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.EmailsWithVerifiedStatus != input.EmailsWithVerifiedStatus || (this.EmailsWithVerifiedStatus != null && input.EmailsWithVerifiedStatus != null && !this.EmailsWithVerifiedStatus.SequenceEqual(input.EmailsWithVerifiedStatus))) return false;
            if (this.Fingerprint != input.Fingerprint || (this.Fingerprint != null && !this.Fingerprint.Equals(input.Fingerprint))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.PrimaryKeyid != input.PrimaryKeyid || (this.PrimaryKeyid != null && !this.PrimaryKeyid.Equals(input.PrimaryKeyid))) return false;
            if (this.Active != input.Active || (this.Active != null && !this.Active.Equals(input.Active))) return false;
            if (this.Subkeys != input.Subkeys || (this.Subkeys != null && input.Subkeys != null && !this.Subkeys.SequenceEqual(input.Subkeys))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EmailsWithVerifiedStatus != null) hashCode = hashCode * 59 + this.EmailsWithVerifiedStatus.GetHashCode();
                if (this.Fingerprint != null) hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.PrimaryKeyid != null) hashCode = hashCode * 59 + this.PrimaryKeyid.GetHashCode();
                if (this.Active != null) hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Subkeys != null) hashCode = hashCode * 59 + this.Subkeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
