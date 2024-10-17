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
    public class StarRocksInstanceInfoGroups 
    {

        /// <summary>
        /// 分组ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 分组名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例节点。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<StarRocksInstanceInfoNodes> Nodes { get; set; }

        /// <summary>
        /// 实例分组类型名。
        /// </summary>
        [JsonProperty("group_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupTypeName { get; set; }

        /// <summary>
        /// 实例分组节点类型。
        /// </summary>
        [JsonProperty("group_node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupNodeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksInstanceInfoGroups {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  groupTypeName: ").Append(GroupTypeName).Append("\n");
            sb.Append("  groupNodeType: ").Append(GroupNodeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StarRocksInstanceInfoGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksInstanceInfoGroups input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.GroupTypeName != input.GroupTypeName || (this.GroupTypeName != null && !this.GroupTypeName.Equals(input.GroupTypeName))) return false;
            if (this.GroupNodeType != input.GroupNodeType || (this.GroupNodeType != null && !this.GroupNodeType.Equals(input.GroupNodeType))) return false;

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
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.GroupTypeName != null) hashCode = hashCode * 59 + this.GroupTypeName.GetHashCode();
                if (this.GroupNodeType != null) hashCode = hashCode * 59 + this.GroupNodeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
