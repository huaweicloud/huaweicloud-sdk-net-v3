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
    /// 关系对应的实体，比如工作项
    /// </summary>
    public class RelationObject 
    {

        /// <summary>
        /// **参数解释**： 实体的种类。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// **参数解释**： 类型列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationObject {\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelationObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelationObject input)
        {
            if (input == null) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;

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
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                return hashCode;
            }
        }
    }
}
