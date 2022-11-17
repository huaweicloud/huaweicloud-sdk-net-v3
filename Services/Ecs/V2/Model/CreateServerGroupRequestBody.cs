using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateServerGroupRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_group", NullValueHandling = NullValueHandling.Ignore)]
        public CreateServerGroupOption ServerGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServerGroupRequestBody {\n");
            sb.Append("  serverGroup: ").Append(ServerGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateServerGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateServerGroupRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerGroup == input.ServerGroup ||
                    (this.ServerGroup != null &&
                    this.ServerGroup.Equals(input.ServerGroup))
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
                if (this.ServerGroup != null)
                    hashCode = hashCode * 59 + this.ServerGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
