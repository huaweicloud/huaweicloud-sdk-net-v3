using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeletePublicipRequest 
    {

        /// <summary>
        /// 弹性公网IP唯一标识
        /// </summary>
        [SDKProperty("publicip_id", IsPath = true)]
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePublicipRequest {\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePublicipRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePublicipRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipId == input.PublicipId ||
                    (this.PublicipId != null &&
                    this.PublicipId.Equals(input.PublicipId))
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
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
