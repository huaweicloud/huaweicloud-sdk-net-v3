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
    /// 存储库创建参数
    /// </summary>
    public class VaultCreateParameters 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("combined_order", NullValueHandling = NullValueHandling.Ignore)]
        public CombinedOrder CombinedOrder { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VaultCreateParameters {\n");
            sb.Append("  combinedOrder: ").Append(CombinedOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VaultCreateParameters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VaultCreateParameters input)
        {
            if (input == null) return false;
            if (this.CombinedOrder != input.CombinedOrder || (this.CombinedOrder != null && !this.CombinedOrder.Equals(input.CombinedOrder))) return false;

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
                if (this.CombinedOrder != null) hashCode = hashCode * 59 + this.CombinedOrder.GetHashCode();
                return hashCode;
            }
        }
    }
}
