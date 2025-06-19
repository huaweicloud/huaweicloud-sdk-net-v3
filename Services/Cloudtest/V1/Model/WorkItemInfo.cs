using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 关联需求
    /// </summary>
    public class WorkItemInfo 
    {

        /// <summary>
        /// 工作项编号
        /// </summary>
        [JsonProperty("work_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkItemId { get; set; }

        /// <summary>
        /// 是否有子需求
        /// </summary>
        [JsonProperty("has_child", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasChild { get; set; }

        /// <summary>
        /// 是否展开
        /// </summary>
        [JsonProperty("is_open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// 子需求
        /// </summary>
        [JsonProperty("child_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkItemInfo> ChildList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemInfo {\n");
            sb.Append("  workItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  hasChild: ").Append(HasChild).Append("\n");
            sb.Append("  isOpen: ").Append(IsOpen).Append("\n");
            sb.Append("  childList: ").Append(ChildList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemInfo input)
        {
            if (input == null) return false;
            if (this.WorkItemId != input.WorkItemId || (this.WorkItemId != null && !this.WorkItemId.Equals(input.WorkItemId))) return false;
            if (this.HasChild != input.HasChild || (this.HasChild != null && !this.HasChild.Equals(input.HasChild))) return false;
            if (this.IsOpen != input.IsOpen || (this.IsOpen != null && !this.IsOpen.Equals(input.IsOpen))) return false;
            if (this.ChildList != input.ChildList || (this.ChildList != null && input.ChildList != null && !this.ChildList.SequenceEqual(input.ChildList))) return false;

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
                if (this.WorkItemId != null) hashCode = hashCode * 59 + this.WorkItemId.GetHashCode();
                if (this.HasChild != null) hashCode = hashCode * 59 + this.HasChild.GetHashCode();
                if (this.IsOpen != null) hashCode = hashCode * 59 + this.IsOpen.GetHashCode();
                if (this.ChildList != null) hashCode = hashCode * 59 + this.ChildList.GetHashCode();
                return hashCode;
            }
        }
    }
}
