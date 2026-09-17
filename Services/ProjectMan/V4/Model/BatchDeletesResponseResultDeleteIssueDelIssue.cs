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
    /// 
    /// </summary>
    public class BatchDeletesResponseResultDeleteIssueDelIssue 
    {

        /// <summary>
        /// **参数解释：** 工作项id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 工作项类型。 **取值范围：** 2（任务/Task） 3（缺陷/Bug） 5（Epic） 6（Feature） 7（Story）
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrackerId { get; set; }

        /// <summary>
        /// **参数解释：** 工作项名称 。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// **参数解释：** 工作项状态id 。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; }

        /// <summary>
        /// **参数解释：** 工作项完成度。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? DoneRatio { get; set; }

        /// <summary>
        /// **参数解释：** 预计工时(单位：人时)。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpectedWorkHours { get; set; }

        /// <summary>
        /// **参数解释：** 实际工时(单位：人时)。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActualWorkHours { get; set; }

        /// <summary>
        /// **参数解释：** 是否完成删除。 **取值范围：** 0（未删除） 1（已删除）
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// **参数解释：** 是否归档。 **取值范围：** 0（未归档） 1（已归档）
        /// </summary>
        [JsonProperty("is_archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsArchived { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeletesResponseResultDeleteIssueDelIssue {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  isArchived: ").Append(IsArchived).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeletesResponseResultDeleteIssueDelIssue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeletesResponseResultDeleteIssueDelIssue input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TrackerId != input.TrackerId || (this.TrackerId != null && !this.TrackerId.Equals(input.TrackerId))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.StatusId != input.StatusId || (this.StatusId != null && !this.StatusId.Equals(input.StatusId))) return false;
            if (this.DoneRatio != input.DoneRatio || (this.DoneRatio != null && !this.DoneRatio.Equals(input.DoneRatio))) return false;
            if (this.ExpectedWorkHours != input.ExpectedWorkHours || (this.ExpectedWorkHours != null && !this.ExpectedWorkHours.Equals(input.ExpectedWorkHours))) return false;
            if (this.ActualWorkHours != input.ActualWorkHours || (this.ActualWorkHours != null && !this.ActualWorkHours.Equals(input.ActualWorkHours))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.IsArchived != input.IsArchived || (this.IsArchived != null && !this.IsArchived.Equals(input.IsArchived))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TrackerId != null) hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.StatusId != null) hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.DoneRatio != null) hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.ExpectedWorkHours != null) hashCode = hashCode * 59 + this.ExpectedWorkHours.GetHashCode();
                if (this.ActualWorkHours != null) hashCode = hashCode * 59 + this.ActualWorkHours.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.IsArchived != null) hashCode = hashCode * 59 + this.IsArchived.GetHashCode();
                return hashCode;
            }
        }
    }
}
