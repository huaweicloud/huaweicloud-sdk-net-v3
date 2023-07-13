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
    public class CreateKeyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("key_info", NullValueHandling = NullValueHandling.Ignore)]
        public KeKInfo KeyInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeyResponse {\n");
            sb.Append("  keyInfo: ").Append(KeyInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKeyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyInfo == input.KeyInfo ||
                    (this.KeyInfo != null &&
                    this.KeyInfo.Equals(input.KeyInfo))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.KeyInfo != null)
                    hashCode = hashCode * 59 + this.KeyInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
