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
    public class EnableKeyStoreResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("keystore", NullValueHandling = NullValueHandling.Ignore)]
        public KeyStoreStateInfo Keystore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableKeyStoreResponse {\n");
            sb.Append("  keystore: ").Append(Keystore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableKeyStoreResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableKeyStoreResponse input)
        {
            if (input == null) return false;
            if (this.Keystore != input.Keystore || (this.Keystore != null && !this.Keystore.Equals(input.Keystore))) return false;

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
                if (this.Keystore != null) hashCode = hashCode * 59 + this.Keystore.GetHashCode();
                return hashCode;
            }
        }
    }
}
