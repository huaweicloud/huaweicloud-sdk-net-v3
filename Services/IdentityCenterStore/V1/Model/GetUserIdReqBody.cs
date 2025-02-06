using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 获取用户id的请求体
    /// </summary>
    public class GetUserIdReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alternate_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public AlternateIdentifierDto AlternateIdentifier { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUserIdReqBody {\n");
            sb.Append("  alternateIdentifier: ").Append(AlternateIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetUserIdReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetUserIdReqBody input)
        {
            if (input == null) return false;
            if (this.AlternateIdentifier != input.AlternateIdentifier || (this.AlternateIdentifier != null && !this.AlternateIdentifier.Equals(input.AlternateIdentifier))) return false;

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
                if (this.AlternateIdentifier != null) hashCode = hashCode * 59 + this.AlternateIdentifier.GetHashCode();
                return hashCode;
            }
        }
    }
}
