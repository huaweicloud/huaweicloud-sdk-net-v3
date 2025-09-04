using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EmChildNodeV2 
    {

        /// <summary>
        /// 实体关系ID。
        /// </summary>
        [JsonProperty("relation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationId { get; set; }

        /// <summary>
        /// 节点ID（即组织单元的Party ID）。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 子节点列表。
        /// </summary>
        [JsonProperty("child_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<EmChildNodeV2> ChildNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmChildNodeV2 {\n");
            sb.Append("  relationId: ").Append(RelationId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  childNodes: ").Append(ChildNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmChildNodeV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EmChildNodeV2 input)
        {
            if (input == null) return false;
            if (this.RelationId != input.RelationId || (this.RelationId != null && !this.RelationId.Equals(input.RelationId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ChildNodes != input.ChildNodes || (this.ChildNodes != null && input.ChildNodes != null && !this.ChildNodes.SequenceEqual(input.ChildNodes))) return false;

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
                if (this.RelationId != null) hashCode = hashCode * 59 + this.RelationId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ChildNodes != null) hashCode = hashCode * 59 + this.ChildNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
