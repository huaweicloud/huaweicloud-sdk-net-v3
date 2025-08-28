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
    /// 中心网络平面详情信息。
    /// </summary>
    public class CentralNetworkPlane 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 关联的中心网络ER实例列表。
        /// </summary>
        [JsonProperty("associate_er_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociateErTableDocument> AssociateErTables { get; set; }

        /// <summary>
        /// 当自动连接所有ER实例时，排除中心网络的ER实例的连接。
        /// </summary>
        [JsonProperty("exclude_er_connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<AssociateErInstanceDocument>> ExcludeErConnections { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkPlane {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  associateErTables: ").Append(AssociateErTables).Append("\n");
            sb.Append("  excludeErConnections: ").Append(ExcludeErConnections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkPlane);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkPlane input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AssociateErTables != input.AssociateErTables || (this.AssociateErTables != null && input.AssociateErTables != null && !this.AssociateErTables.SequenceEqual(input.AssociateErTables))) return false;
            if (this.ExcludeErConnections != input.ExcludeErConnections || (this.ExcludeErConnections != null && input.ExcludeErConnections != null && !this.ExcludeErConnections.SequenceEqual(input.ExcludeErConnections))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AssociateErTables != null) hashCode = hashCode * 59 + this.AssociateErTables.GetHashCode();
                if (this.ExcludeErConnections != null) hashCode = hashCode * 59 + this.ExcludeErConnections.GetHashCode();
                return hashCode;
            }
        }
    }
}
