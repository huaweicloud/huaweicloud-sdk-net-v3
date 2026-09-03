using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量查询技能包请求。
    /// </summary>
    public class BatchListSkillPackagesReq 
    {

        /// <summary>
        /// 技能 ID 列表。
        /// </summary>
        [JsonProperty("skill_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SkillIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchListSkillPackagesReq {\n");
            sb.Append("  skillIds: ").Append(SkillIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchListSkillPackagesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchListSkillPackagesReq input)
        {
            if (input == null) return false;
            if (this.SkillIds != input.SkillIds || (this.SkillIds != null && input.SkillIds != null && !this.SkillIds.SequenceEqual(input.SkillIds))) return false;

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
                if (this.SkillIds != null) hashCode = hashCode * 59 + this.SkillIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
