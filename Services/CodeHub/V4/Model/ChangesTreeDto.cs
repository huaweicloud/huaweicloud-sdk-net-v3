using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 合并请求文件变更列表详情
    /// </summary>
    public class ChangesTreeDto 
    {

        /// <summary>
        /// **参数解释：** 展示审核文件。
        /// </summary>
        [JsonProperty("can_show_my_approval_files", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanShowMyApprovalFiles { get; set; }

        /// <summary>
        /// **参数解释：** 变更树。
        /// </summary>
        [JsonProperty("tree", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChangesTreeObjectDto> Tree { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangesTreeDto {\n");
            sb.Append("  canShowMyApprovalFiles: ").Append(CanShowMyApprovalFiles).Append("\n");
            sb.Append("  tree: ").Append(Tree).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangesTreeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangesTreeDto input)
        {
            if (input == null) return false;
            if (this.CanShowMyApprovalFiles != input.CanShowMyApprovalFiles || (this.CanShowMyApprovalFiles != null && !this.CanShowMyApprovalFiles.Equals(input.CanShowMyApprovalFiles))) return false;
            if (this.Tree != input.Tree || (this.Tree != null && input.Tree != null && !this.Tree.SequenceEqual(input.Tree))) return false;

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
                if (this.CanShowMyApprovalFiles != null) hashCode = hashCode * 59 + this.CanShowMyApprovalFiles.GetHashCode();
                if (this.Tree != null) hashCode = hashCode * 59 + this.Tree.GetHashCode();
                return hashCode;
            }
        }
    }
}
