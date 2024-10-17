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
    /// 云服务器组添加、删除成员列表
    /// </summary>
    public class ServerGroupMember 
    {

        /// <summary>
        /// 云服务器UUID。
        /// </summary>
        [JsonProperty("instance_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceUuid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerGroupMember {\n");
            sb.Append("  instanceUuid: ").Append(InstanceUuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerGroupMember);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerGroupMember input)
        {
            if (input == null) return false;
            if (this.InstanceUuid != input.InstanceUuid || (this.InstanceUuid != null && !this.InstanceUuid.Equals(input.InstanceUuid))) return false;

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
                if (this.InstanceUuid != null) hashCode = hashCode * 59 + this.InstanceUuid.GetHashCode();
                return hashCode;
            }
        }
    }
}
