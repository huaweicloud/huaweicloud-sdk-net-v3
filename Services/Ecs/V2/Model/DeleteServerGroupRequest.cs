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
    /// Request Object
    /// </summary>
    public class DeleteServerGroupRequest 
    {

        /// <summary>
        /// 弹性云服务器组UUID。
        /// </summary>
        [SDKProperty("server_group_id", IsPath = true)]
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteServerGroupRequest {\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteServerGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteServerGroupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerGroupId == input.ServerGroupId ||
                    (this.ServerGroupId != null &&
                    this.ServerGroupId.Equals(input.ServerGroupId))
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
                if (this.ServerGroupId != null)
                    hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
