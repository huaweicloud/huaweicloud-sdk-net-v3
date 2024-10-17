using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteResourceGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 成功删除的资源分组ID列表
        /// </summary>
        [JsonProperty("group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteResourceGroupsResponse {\n");
            sb.Append("  groupIds: ").Append(GroupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteResourceGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteResourceGroupsResponse input)
        {
            if (input == null) return false;
            if (this.GroupIds != input.GroupIds || (this.GroupIds != null && input.GroupIds != null && !this.GroupIds.SequenceEqual(input.GroupIds))) return false;

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
                if (this.GroupIds != null) hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
