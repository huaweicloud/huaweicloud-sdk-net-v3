using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeManagement 
    {

        /// <summary>
        /// 云服务器组ID，若指定，节点池中所有节点将创建在该云服务器组下，节点池的云服务器组只能在创建时指定，无法修改。指定云服务器组时节点池中的节点数量不允许超出云服务器组的配额限制。 
        /// </summary>
        [JsonProperty("serverGroupReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupReference { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeManagement {\n");
            sb.Append("  serverGroupReference: ").Append(ServerGroupReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeManagement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeManagement input)
        {
            if (input == null) return false;
            if (this.ServerGroupReference != input.ServerGroupReference || (this.ServerGroupReference != null && !this.ServerGroupReference.Equals(input.ServerGroupReference))) return false;

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
                if (this.ServerGroupReference != null) hashCode = hashCode * 59 + this.ServerGroupReference.GetHashCode();
                return hashCode;
            }
        }
    }
}
