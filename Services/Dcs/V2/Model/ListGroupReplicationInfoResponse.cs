using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListGroupReplicationInfoResponse : SdkResponse
    {

        /// <summary>
        /// 分片列表
        /// </summary>
        [JsonProperty("group_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceGroupListInfo> GroupList { get; set; }

        /// <summary>
        /// 实例分片总数。
        /// </summary>
        [JsonProperty("group_count", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupCount { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGroupReplicationInfoResponse {\n");
            sb.Append("  groupList: ").Append(GroupList).Append("\n");
            sb.Append("  groupCount: ").Append(GroupCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGroupReplicationInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGroupReplicationInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupList == input.GroupList ||
                    this.GroupList != null &&
                    input.GroupList != null &&
                    this.GroupList.SequenceEqual(input.GroupList)
                ) && 
                (
                    this.GroupCount == input.GroupCount ||
                    (this.GroupCount != null &&
                    this.GroupCount.Equals(input.GroupCount))
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
                if (this.GroupList != null)
                    hashCode = hashCode * 59 + this.GroupList.GetHashCode();
                if (this.GroupCount != null)
                    hashCode = hashCode * 59 + this.GroupCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
