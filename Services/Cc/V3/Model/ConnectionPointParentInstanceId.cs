using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 连接点的实例的父资源ID。
    /// </summary>
    public class ConnectionPointParentInstanceId 
    {

        /// <summary>
        /// 连接点的实例的父资源ID。
        /// </summary>
        [JsonProperty("parent_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionPointParentInstanceId {\n");
            sb.Append("  parentInstanceId: ").Append(ParentInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionPointParentInstanceId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectionPointParentInstanceId input)
        {
            if (input == null) return false;
            if (this.ParentInstanceId != input.ParentInstanceId || (this.ParentInstanceId != null && !this.ParentInstanceId.Equals(input.ParentInstanceId))) return false;

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
                if (this.ParentInstanceId != null) hashCode = hashCode * 59 + this.ParentInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
