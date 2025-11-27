using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class APIEnablement 
    {

        /// <summary>
        /// 资源组版本
        /// </summary>
        [JsonProperty("groupVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupVersion { get; set; }

        /// <summary>
        /// 资源类型、名称
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<APIResource> Resources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIEnablement {\n");
            sb.Append("  groupVersion: ").Append(GroupVersion).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as APIEnablement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(APIEnablement input)
        {
            if (input == null) return false;
            if (this.GroupVersion != input.GroupVersion || (this.GroupVersion != null && !this.GroupVersion.Equals(input.GroupVersion))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;

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
                if (this.GroupVersion != null) hashCode = hashCode * 59 + this.GroupVersion.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                return hashCode;
            }
        }
    }
}
