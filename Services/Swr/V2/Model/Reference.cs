using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Reference 
    {

        /// <summary>
        /// 父制品的ID。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentId { get; set; }

        /// <summary>
        /// 子制品的ID。
        /// </summary>
        [JsonProperty("child_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ChildId { get; set; }

        /// <summary>
        /// 子制品的digest。
        /// </summary>
        [JsonProperty("child_digest", NullValueHandling = NullValueHandling.Ignore)]
        public string ChildDigest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public Platform Platform { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reference {\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  childId: ").Append(ChildId).Append("\n");
            sb.Append("  childDigest: ").Append(ChildDigest).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Reference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Reference input)
        {
            if (input == null) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.ChildId != input.ChildId || (this.ChildId != null && !this.ChildId.Equals(input.ChildId))) return false;
            if (this.ChildDigest != input.ChildDigest || (this.ChildDigest != null && !this.ChildDigest.Equals(input.ChildDigest))) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;

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
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ChildId != null) hashCode = hashCode * 59 + this.ChildId.GetHashCode();
                if (this.ChildDigest != null) hashCode = hashCode * 59 + this.ChildDigest.GetHashCode();
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                return hashCode;
            }
        }
    }
}
