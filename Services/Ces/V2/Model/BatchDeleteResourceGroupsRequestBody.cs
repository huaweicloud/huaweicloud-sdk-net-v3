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
    /// 
    /// </summary>
    public class BatchDeleteResourceGroupsRequestBody 
    {

        /// <summary>
        /// 需要批量删除的资源分组ID列表
        /// </summary>
        [JsonProperty("group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteResourceGroupsRequestBody {\n");
            sb.Append("  groupIds: ").Append(GroupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteResourceGroupsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteResourceGroupsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    input.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
