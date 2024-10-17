using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlShowProxyResponseV3 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proxy", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlProxyV3 Proxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("master_node", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlProxyNodeV3 MasterNode { get; set; }

        /// <summary>
        /// 只读节点信息。
        /// </summary>
        [JsonProperty("readonly_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlProxyNodeV3> ReadonlyNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlShowProxyResponseV3 {\n");
            sb.Append("  proxy: ").Append(Proxy).Append("\n");
            sb.Append("  masterNode: ").Append(MasterNode).Append("\n");
            sb.Append("  readonlyNodes: ").Append(ReadonlyNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlShowProxyResponseV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlShowProxyResponseV3 input)
        {
            if (input == null) return false;
            if (this.Proxy != input.Proxy || (this.Proxy != null && !this.Proxy.Equals(input.Proxy))) return false;
            if (this.MasterNode != input.MasterNode || (this.MasterNode != null && !this.MasterNode.Equals(input.MasterNode))) return false;
            if (this.ReadonlyNodes != input.ReadonlyNodes || (this.ReadonlyNodes != null && input.ReadonlyNodes != null && !this.ReadonlyNodes.SequenceEqual(input.ReadonlyNodes))) return false;

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
                if (this.Proxy != null) hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.MasterNode != null) hashCode = hashCode * 59 + this.MasterNode.GetHashCode();
                if (this.ReadonlyNodes != null) hashCode = hashCode * 59 + this.ReadonlyNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
