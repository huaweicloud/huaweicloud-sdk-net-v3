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
    /// 从迭代中移除需求API Body信息
    /// </summary>
    public class RemoveIssuesInfo 
    {

        /// <summary>
        /// 关联需求
        /// </summary>
        [JsonProperty("workitem_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkItemInfo> WorkitemList { get; set; }

        /// <summary>
        /// 是否删除需求关联的用例
        /// </summary>
        [JsonProperty("is_delete_case", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleteCase { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveIssuesInfo {\n");
            sb.Append("  workitemList: ").Append(WorkitemList).Append("\n");
            sb.Append("  isDeleteCase: ").Append(IsDeleteCase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoveIssuesInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoveIssuesInfo input)
        {
            if (input == null) return false;
            if (this.WorkitemList != input.WorkitemList || (this.WorkitemList != null && input.WorkitemList != null && !this.WorkitemList.SequenceEqual(input.WorkitemList))) return false;
            if (this.IsDeleteCase != input.IsDeleteCase || (this.IsDeleteCase != null && !this.IsDeleteCase.Equals(input.IsDeleteCase))) return false;

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
                if (this.WorkitemList != null) hashCode = hashCode * 59 + this.WorkitemList.GetHashCode();
                if (this.IsDeleteCase != null) hashCode = hashCode * 59 + this.IsDeleteCase.GetHashCode();
                return hashCode;
            }
        }
    }
}
