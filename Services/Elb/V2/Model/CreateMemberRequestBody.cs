using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateMemberRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        public CreateMemberReq Member { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMemberRequestBody {\n");
            sb.Append("  member: ").Append(Member).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMemberRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMemberRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
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
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                return hashCode;
            }
        }
    }
}
