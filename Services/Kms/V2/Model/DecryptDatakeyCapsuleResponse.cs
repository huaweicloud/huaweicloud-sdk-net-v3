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
    public class DecryptDatakeyCapsuleResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 密钥ID **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// **参数解释：** 解密胶囊所在的实例ID **取值范围：** ECS ID，CCE的集群ID或者通用场景的access_point_id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecryptDatakeyCapsuleResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  datakey: ").Append(Datakey).Append("\n");
            sb.Append("  datakeyCipher: ").Append(DatakeyCipher).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DecryptDatakeyCapsuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DecryptDatakeyCapsuleResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Datakey != input.Datakey || (this.Datakey != null && !this.Datakey.Equals(input.Datakey))) return false;
            if (this.DatakeyCipher != input.DatakeyCipher || (this.DatakeyCipher != null && !this.DatakeyCipher.Equals(input.DatakeyCipher))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Datakey != null) hashCode = hashCode * 59 + this.Datakey.GetHashCode();
                if (this.DatakeyCipher != null) hashCode = hashCode * 59 + this.DatakeyCipher.GetHashCode();
                return hashCode;
            }
        }
    }
}
