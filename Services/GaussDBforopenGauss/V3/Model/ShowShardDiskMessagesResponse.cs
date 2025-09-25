using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowShardDiskMessagesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 分片磁盘信息列表。
        /// </summary>
        [JsonProperty("group_disk_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupDiskInfoResult> GroupDiskInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowShardDiskMessagesResponse {\n");
            sb.Append("  groupDiskInfos: ").Append(GroupDiskInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowShardDiskMessagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowShardDiskMessagesResponse input)
        {
            if (input == null) return false;
            if (this.GroupDiskInfos != input.GroupDiskInfos || (this.GroupDiskInfos != null && input.GroupDiskInfos != null && !this.GroupDiskInfos.SequenceEqual(input.GroupDiskInfos))) return false;

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
                if (this.GroupDiskInfos != null) hashCode = hashCode * 59 + this.GroupDiskInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
