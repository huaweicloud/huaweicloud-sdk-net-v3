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
    /// 加密信息
    /// </summary>
    public class ReplicationEncInfo 
    {

        /// <summary>
        /// 加密算法
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string Algorithm { get; set; }

        /// <summary>
        /// 秘钥id
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 初始化向量
        /// </summary>
        [JsonProperty("iv", NullValueHandling = NullValueHandling.Ignore)]
        public string Iv { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplicationEncInfo {\n");
            sb.Append("  algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  iv: ").Append(Iv).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplicationEncInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplicationEncInfo input)
        {
            if (input == null) return false;
            if (this.Algorithm != input.Algorithm || (this.Algorithm != null && !this.Algorithm.Equals(input.Algorithm))) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.Iv != input.Iv || (this.Iv != null && !this.Iv.Equals(input.Iv))) return false;

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
                if (this.Algorithm != null) hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.Iv != null) hashCode = hashCode * 59 + this.Iv.GetHashCode();
                return hashCode;
            }
        }
    }
}
