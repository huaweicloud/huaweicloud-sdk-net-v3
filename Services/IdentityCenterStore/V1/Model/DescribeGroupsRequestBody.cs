using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 查询用户组信息请求体
    /// </summary>
    public class DescribeGroupsRequestBody 
    {

        /// <summary>
        /// 用户组唯一标识符（ID）列表
        /// </summary>
        [JsonProperty("group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribeGroupsRequestBody {\n");
            sb.Append("  groupIds: ").Append(GroupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribeGroupsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribeGroupsRequestBody input)
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
