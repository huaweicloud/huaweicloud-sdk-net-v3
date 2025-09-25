using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeRequestListDtoUser 
    {

        /// <summary>
        /// 当前用户是否可合入
        /// </summary>
        [JsonProperty("can_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanMerge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestListDtoUser {\n");
            sb.Append("  canMerge: ").Append(CanMerge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestListDtoUser);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestListDtoUser input)
        {
            if (input == null) return false;
            if (this.CanMerge != input.CanMerge || (this.CanMerge != null && !this.CanMerge.Equals(input.CanMerge))) return false;

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
                if (this.CanMerge != null) hashCode = hashCode * 59 + this.CanMerge.GetHashCode();
                return hashCode;
            }
        }
    }
}
