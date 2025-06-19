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
    /// 关联需求信息
    /// </summary>
    public class AssociateIssueInfoVo 
    {

        /// <summary>
        /// 是否已关联
        /// </summary>
        [JsonProperty("associate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Associate { get; set; }

        /// <summary>
        /// 需求ID
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 需求类型
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerId { get; set; }

        /// <summary>
        /// 工作项层级ID
        /// </summary>
        [JsonProperty("board_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BoardId { get; set; }

        /// <summary>
        /// 需求类型名称
        /// </summary>
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateIssueInfoVo {\n");
            sb.Append("  associate: ").Append(Associate).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  boardId: ").Append(BoardId).Append("\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateIssueInfoVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateIssueInfoVo input)
        {
            if (input == null) return false;
            if (this.Associate != input.Associate || (this.Associate != null && !this.Associate.Equals(input.Associate))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.TrackerId != input.TrackerId || (this.TrackerId != null && !this.TrackerId.Equals(input.TrackerId))) return false;
            if (this.BoardId != input.BoardId || (this.BoardId != null && !this.BoardId.Equals(input.BoardId))) return false;
            if (this.TrackerName != input.TrackerName || (this.TrackerName != null && !this.TrackerName.Equals(input.TrackerName))) return false;

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
                if (this.Associate != null) hashCode = hashCode * 59 + this.Associate.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.TrackerId != null) hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.BoardId != null) hashCode = hashCode * 59 + this.BoardId.GetHashCode();
                if (this.TrackerName != null) hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
