using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Encryption 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hls_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public HlsEncrypt HlsEncrypt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Encryption {\n");
            sb.Append("  hlsEncrypt: ").Append(HlsEncrypt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Encryption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Encryption input)
        {
            if (input == null) return false;
            if (this.HlsEncrypt != input.HlsEncrypt || (this.HlsEncrypt != null && !this.HlsEncrypt.Equals(input.HlsEncrypt))) return false;

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
                if (this.HlsEncrypt != null) hashCode = hashCode * 59 + this.HlsEncrypt.GetHashCode();
                return hashCode;
            }
        }
    }
}
