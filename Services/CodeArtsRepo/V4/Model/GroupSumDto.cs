using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GroupSumDto 
    {

        /// <summary>
        /// 打开状态MR计数
        /// </summary>
        [JsonProperty("open_merge_requests_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenMergeRequestsCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSumDto {\n");
            sb.Append("  openMergeRequestsCount: ").Append(OpenMergeRequestsCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupSumDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupSumDto input)
        {
            if (input == null) return false;
            if (this.OpenMergeRequestsCount != input.OpenMergeRequestsCount || (this.OpenMergeRequestsCount != null && !this.OpenMergeRequestsCount.Equals(input.OpenMergeRequestsCount))) return false;

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
                if (this.OpenMergeRequestsCount != null) hashCode = hashCode * 59 + this.OpenMergeRequestsCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
