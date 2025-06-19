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
    /// 过滤条件
    /// </summary>
    public class IssueListFilterInfo 
    {

        /// <summary>
        /// 迭代id列表
        /// </summary>
        [JsonProperty("iteration_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IterationIds { get; set; }

        /// <summary>
        /// pi过滤条件
        /// </summary>
        [JsonProperty("pi_sprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueListPiFilterInfo> PiSprints { get; set; }

        /// <summary>
        /// 需求名
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 需求状态id
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueListFilterInfo {\n");
            sb.Append("  iterationIds: ").Append(IterationIds).Append("\n");
            sb.Append("  piSprints: ").Append(PiSprints).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueListFilterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueListFilterInfo input)
        {
            if (input == null) return false;
            if (this.IterationIds != input.IterationIds || (this.IterationIds != null && input.IterationIds != null && !this.IterationIds.SequenceEqual(input.IterationIds))) return false;
            if (this.PiSprints != input.PiSprints || (this.PiSprints != null && input.PiSprints != null && !this.PiSprints.SequenceEqual(input.PiSprints))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.StatusId != input.StatusId || (this.StatusId != null && !this.StatusId.Equals(input.StatusId))) return false;

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
                if (this.IterationIds != null) hashCode = hashCode * 59 + this.IterationIds.GetHashCode();
                if (this.PiSprints != null) hashCode = hashCode * 59 + this.PiSprints.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.StatusId != null) hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                return hashCode;
            }
        }
    }
}
