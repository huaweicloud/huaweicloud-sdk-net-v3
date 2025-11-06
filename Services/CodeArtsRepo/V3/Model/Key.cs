using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Key 
    {

        /// <summary>
        /// 是否允许推送
        /// </summary>
        [JsonProperty("can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanPush { get; set; }

        /// <summary>
        /// 部署密钥新建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 部署密钥
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string _Key { get; set; }

        /// <summary>
        /// 部署密钥id
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 部署密钥名称
        /// </summary>
        [JsonProperty("key_title", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyTitle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Key {\n");
            sb.Append("  canPush: ").Append(CanPush).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  _key: ").Append(_Key).Append("\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  keyTitle: ").Append(KeyTitle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Key);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Key input)
        {
            if (input == null) return false;
            if (this.CanPush != input.CanPush || (this.CanPush != null && !this.CanPush.Equals(input.CanPush))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this._Key != input._Key || (this._Key != null && !this._Key.Equals(input._Key))) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.KeyTitle != input.KeyTitle || (this.KeyTitle != null && !this.KeyTitle.Equals(input.KeyTitle))) return false;

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
                if (this.CanPush != null) hashCode = hashCode * 59 + this.CanPush.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this._Key != null) hashCode = hashCode * 59 + this._Key.GetHashCode();
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.KeyTitle != null) hashCode = hashCode * 59 + this.KeyTitle.GetHashCode();
                return hashCode;
            }
        }
    }
}
