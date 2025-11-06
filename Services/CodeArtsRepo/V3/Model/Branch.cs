using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Branch 
    {

        /// <summary>
        /// 是否开启保护分支功能
        /// </summary>
        [JsonProperty("is_protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProtected { get; set; }

        /// <summary>
        /// 分支名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Branch {\n");
            sb.Append("  isProtected: ").Append(IsProtected).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Branch);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Branch input)
        {
            if (input == null) return false;
            if (this.IsProtected != input.IsProtected || (this.IsProtected != null && !this.IsProtected.Equals(input.IsProtected))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.IsProtected != null) hashCode = hashCode * 59 + this.IsProtected.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
