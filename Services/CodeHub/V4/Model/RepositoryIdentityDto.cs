using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryIdentityDto 
    {

        /// <summary>
        /// **参数解释：** 项目ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 项目路径。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("path_with_namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string PathWithNamespace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryIdentityDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  pathWithNamespace: ").Append(PathWithNamespace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryIdentityDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryIdentityDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PathWithNamespace != input.PathWithNamespace || (this.PathWithNamespace != null && !this.PathWithNamespace.Equals(input.PathWithNamespace))) return false;

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
                if (this.PathWithNamespace != null) hashCode = hashCode * 59 + this.PathWithNamespace.GetHashCode();
                return hashCode;
            }
        }
    }
}
