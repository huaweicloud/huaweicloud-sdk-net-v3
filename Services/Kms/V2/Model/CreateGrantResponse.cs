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
    public class CreateGrantResponse : SdkResponse
    {

        /// <summary>
        /// 授权ID，64字节。
        /// </summary>
        [JsonProperty("grant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GrantId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGrantResponse {\n");
            sb.Append("  grantId: ").Append(GrantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGrantResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGrantResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GrantId == input.GrantId ||
                    (this.GrantId != null &&
                    this.GrantId.Equals(input.GrantId))
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
                if (this.GrantId != null)
                    hashCode = hashCode * 59 + this.GrantId.GetHashCode();
                return hashCode;
            }
        }
    }
}
