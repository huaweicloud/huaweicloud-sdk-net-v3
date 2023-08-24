using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FirewallAssociation 
    {

        /// <summary>
        /// 功能说明：ACL绑定的子网ID
        /// </summary>
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallAssociation {\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FirewallAssociation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FirewallAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VirsubnetId == input.VirsubnetId ||
                    (this.VirsubnetId != null &&
                    this.VirsubnetId.Equals(input.VirsubnetId))
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
                if (this.VirsubnetId != null)
                    hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
