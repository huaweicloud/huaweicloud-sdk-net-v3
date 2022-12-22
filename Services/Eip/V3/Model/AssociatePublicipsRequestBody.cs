using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 绑定弹性公网IP的请求体
    /// </summary>
    public class AssociatePublicipsRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public AssociatePublicipsOption Publicip { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatePublicipsRequestBody {\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatePublicipsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociatePublicipsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Publicip == input.Publicip ||
                    (this.Publicip != null &&
                    this.Publicip.Equals(input.Publicip))
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
                if (this.Publicip != null)
                    hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                return hashCode;
            }
        }
    }
}
