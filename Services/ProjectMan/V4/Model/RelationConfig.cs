using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RelationConfig 
    {

        /// <summary>
        /// key为工作项类型，value为该类型的所有关联关系
        /// </summary>
        [JsonProperty("relations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<Relation>> Relations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationConfig {\n");
            sb.Append("  relations: ").Append(Relations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelationConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelationConfig input)
        {
            if (input == null) return false;
            if (this.Relations != input.Relations || (this.Relations != null && input.Relations != null && !this.Relations.SequenceEqual(input.Relations))) return false;

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
                if (this.Relations != null) hashCode = hashCode * 59 + this.Relations.GetHashCode();
                return hashCode;
            }
        }
    }
}
