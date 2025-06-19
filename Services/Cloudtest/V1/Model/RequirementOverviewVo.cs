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
    /// 质量报告需求测试情况列表
    /// </summary>
    public class RequirementOverviewVo 
    {

        /// <summary>
        /// 需求名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 需求id
        /// </summary>
        [JsonProperty("workitem_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkitemId { get; set; }

        /// <summary>
        /// 需求序列编号
        /// </summary>
        [JsonProperty("sequence_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SequenceId { get; set; }

        /// <summary>
        /// 看板需求id
        /// </summary>
        [JsonProperty("board_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BoardId { get; set; }

        /// <summary>
        /// 需求类型id
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerId { get; set; }

        /// <summary>
        /// 需求类型
        /// </summary>
        [JsonProperty("tracker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrackerName { get; set; }

        /// <summary>
        /// 需求关联用例总数
        /// </summary>
        [JsonProperty("relate_case_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? RelateCaseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_pass_vo", NullValueHandling = NullValueHandling.Ignore)]
        public CasePassVo CasePassVo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_execute_vo", NullValueHandling = NullValueHandling.Ignore)]
        public CaseExecuteVo CaseExecuteVo { get; set; }

        /// <summary>
        /// 需求关联缺陷总数
        /// </summary>
        [JsonProperty("relate_defect_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? RelateDefectNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequirementOverviewVo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  workitemId: ").Append(WorkitemId).Append("\n");
            sb.Append("  sequenceId: ").Append(SequenceId).Append("\n");
            sb.Append("  boardId: ").Append(BoardId).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  trackerName: ").Append(TrackerName).Append("\n");
            sb.Append("  relateCaseNumber: ").Append(RelateCaseNumber).Append("\n");
            sb.Append("  casePassVo: ").Append(CasePassVo).Append("\n");
            sb.Append("  caseExecuteVo: ").Append(CaseExecuteVo).Append("\n");
            sb.Append("  relateDefectNumber: ").Append(RelateDefectNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequirementOverviewVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequirementOverviewVo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.WorkitemId != input.WorkitemId || (this.WorkitemId != null && !this.WorkitemId.Equals(input.WorkitemId))) return false;
            if (this.SequenceId != input.SequenceId || (this.SequenceId != null && !this.SequenceId.Equals(input.SequenceId))) return false;
            if (this.BoardId != input.BoardId || (this.BoardId != null && !this.BoardId.Equals(input.BoardId))) return false;
            if (this.TrackerId != input.TrackerId || (this.TrackerId != null && !this.TrackerId.Equals(input.TrackerId))) return false;
            if (this.TrackerName != input.TrackerName || (this.TrackerName != null && !this.TrackerName.Equals(input.TrackerName))) return false;
            if (this.RelateCaseNumber != input.RelateCaseNumber || (this.RelateCaseNumber != null && !this.RelateCaseNumber.Equals(input.RelateCaseNumber))) return false;
            if (this.CasePassVo != input.CasePassVo || (this.CasePassVo != null && !this.CasePassVo.Equals(input.CasePassVo))) return false;
            if (this.CaseExecuteVo != input.CaseExecuteVo || (this.CaseExecuteVo != null && !this.CaseExecuteVo.Equals(input.CaseExecuteVo))) return false;
            if (this.RelateDefectNumber != input.RelateDefectNumber || (this.RelateDefectNumber != null && !this.RelateDefectNumber.Equals(input.RelateDefectNumber))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.WorkitemId != null) hashCode = hashCode * 59 + this.WorkitemId.GetHashCode();
                if (this.SequenceId != null) hashCode = hashCode * 59 + this.SequenceId.GetHashCode();
                if (this.BoardId != null) hashCode = hashCode * 59 + this.BoardId.GetHashCode();
                if (this.TrackerId != null) hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.TrackerName != null) hashCode = hashCode * 59 + this.TrackerName.GetHashCode();
                if (this.RelateCaseNumber != null) hashCode = hashCode * 59 + this.RelateCaseNumber.GetHashCode();
                if (this.CasePassVo != null) hashCode = hashCode * 59 + this.CasePassVo.GetHashCode();
                if (this.CaseExecuteVo != null) hashCode = hashCode * 59 + this.CaseExecuteVo.GetHashCode();
                if (this.RelateDefectNumber != null) hashCode = hashCode * 59 + this.RelateDefectNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
