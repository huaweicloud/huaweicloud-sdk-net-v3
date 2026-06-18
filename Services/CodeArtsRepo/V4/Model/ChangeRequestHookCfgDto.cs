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
    public class ChangeRequestHookCfgDto 
    {

        /// <summary>
        /// **参数解释：** 预留字段，事件触发设置，可为空。
        /// </summary>
        [JsonProperty("event_cfgs", NullValueHandling = NullValueHandling.Ignore)]
        public List<WebHookEventCfgDto> EventCfgs { get; set; }

        /// <summary>
        /// **参数解释：** 预留字段，仓库分支规则设置，可为空。
        /// </summary>
        [JsonProperty("project_cfgs", NullValueHandling = NullValueHandling.Ignore)]
        public List<WebHookBranchCfgDto> ProjectCfgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("branch_cfgs", NullValueHandling = NullValueHandling.Ignore)]
        public List<WebHookBranchCfgDto> BranchCfgs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeRequestHookCfgDto {\n");
            sb.Append("  eventCfgs: ").Append(EventCfgs).Append("\n");
            sb.Append("  projectCfgs: ").Append(ProjectCfgs).Append("\n");
            sb.Append("  branchCfgs: ").Append(BranchCfgs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeRequestHookCfgDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeRequestHookCfgDto input)
        {
            if (input == null) return false;
            if (this.EventCfgs != input.EventCfgs || (this.EventCfgs != null && input.EventCfgs != null && !this.EventCfgs.SequenceEqual(input.EventCfgs))) return false;
            if (this.ProjectCfgs != input.ProjectCfgs || (this.ProjectCfgs != null && input.ProjectCfgs != null && !this.ProjectCfgs.SequenceEqual(input.ProjectCfgs))) return false;
            if (this.BranchCfgs != input.BranchCfgs || (this.BranchCfgs != null && input.BranchCfgs != null && !this.BranchCfgs.SequenceEqual(input.BranchCfgs))) return false;

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
                if (this.EventCfgs != null) hashCode = hashCode * 59 + this.EventCfgs.GetHashCode();
                if (this.ProjectCfgs != null) hashCode = hashCode * 59 + this.ProjectCfgs.GetHashCode();
                if (this.BranchCfgs != null) hashCode = hashCode * 59 + this.BranchCfgs.GetHashCode();
                return hashCode;
            }
        }
    }
}
