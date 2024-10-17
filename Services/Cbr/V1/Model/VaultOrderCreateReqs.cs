using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 创建包周期存储库请求体
    /// </summary>
    public class VaultOrderCreateReqs 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vault", NullValueHandling = NullValueHandling.Ignore)]
        public VaultOrder Vault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultOrderCreateReqs {\n");
            sb.Append("  vault: ").Append(Vault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultOrderCreateReqs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultOrderCreateReqs input)
        {
            if (input == null) return false;
            if (this.Vault != input.Vault || (this.Vault != null && !this.Vault.Equals(input.Vault))) return false;

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
                if (this.Vault != null) hashCode = hashCode * 59 + this.Vault.GetHashCode();
                return hashCode;
            }
        }
    }
}
