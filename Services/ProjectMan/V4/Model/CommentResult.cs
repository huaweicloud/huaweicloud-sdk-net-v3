using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// IPD工作项评论列表查询结果
    /// </summary>
    public class CommentResult 
    {

        /// <summary>
        /// **参数解释**： 符合过滤条件的工作项评论总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 工作项评论列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("comment_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommentEntity> CommentList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentResult {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  commentList: ").Append(CommentList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommentResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommentResult input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.CommentList != input.CommentList || (this.CommentList != null && input.CommentList != null && !this.CommentList.SequenceEqual(input.CommentList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.CommentList != null) hashCode = hashCode * 59 + this.CommentList.GetHashCode();
                return hashCode;
            }
        }
    }
}
