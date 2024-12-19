using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GroupedResourceCount 
    {

        /// <summary>
        /// 分组名称。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 资源数量。
        /// </summary>
        [JsonProperty("resource_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupedResourceCount {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  resourceCount: ").Append(ResourceCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupedResourceCount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupedResourceCount input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.ResourceCount != input.ResourceCount || (this.ResourceCount != null && !this.ResourceCount.Equals(input.ResourceCount))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ResourceCount != null) hashCode = hashCode * 59 + this.ResourceCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
