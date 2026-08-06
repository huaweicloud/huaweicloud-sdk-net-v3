using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateDatakeyCapsuleResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 密钥ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// **参数解释：** datakey和datakey_cipher响应二选一，如果请求参数中没传递public_key，则返回datakey **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("datakey", NullValueHandling = NullValueHandling.Ignore)]
        public string Datakey { get; set; }

        /// <summary>
        /// **参数解释：** datakey和datakey_cipher响应二选一，如果请求参数中传递了public_key，使用public_key加密datakey后返回datakey_cipher **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("datakey_cipher", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyCipher { get; set; }

        /// <summary>
        /// **参数解释：** 密钥胶囊 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("datakey_capsule", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyCapsule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDatakeyCapsuleResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  datakey: ").Append(Datakey).Append("\n");
            sb.Append("  datakeyCipher: ").Append(DatakeyCipher).Append("\n");
            sb.Append("  datakeyCapsule: ").Append(DatakeyCapsule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDatakeyCapsuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDatakeyCapsuleResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.Datakey != input.Datakey || (this.Datakey != null && !this.Datakey.Equals(input.Datakey))) return false;
            if (this.DatakeyCipher != input.DatakeyCipher || (this.DatakeyCipher != null && !this.DatakeyCipher.Equals(input.DatakeyCipher))) return false;
            if (this.DatakeyCapsule != input.DatakeyCapsule || (this.DatakeyCapsule != null && !this.DatakeyCapsule.Equals(input.DatakeyCapsule))) return false;

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
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.Datakey != null) hashCode = hashCode * 59 + this.Datakey.GetHashCode();
                if (this.DatakeyCipher != null) hashCode = hashCode * 59 + this.DatakeyCipher.GetHashCode();
                if (this.DatakeyCapsule != null) hashCode = hashCode * 59 + this.DatakeyCapsule.GetHashCode();
                return hashCode;
            }
        }
    }
}
