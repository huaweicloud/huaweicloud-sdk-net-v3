using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kps.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Keypairs 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("keypair", NullValueHandling = NullValueHandling.Ignore)]
        public Keypair Keypair { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Keypairs {\n");
            sb.Append("  keypair: ").Append(Keypair).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Keypairs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Keypairs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keypair == input.Keypair ||
                    (this.Keypair != null &&
                    this.Keypair.Equals(input.Keypair))
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
                if (this.Keypair != null)
                    hashCode = hashCode * 59 + this.Keypair.GetHashCode();
                return hashCode;
            }
        }
    }
}
