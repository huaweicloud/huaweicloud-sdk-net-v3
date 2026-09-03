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
    /// 批量查询技能包响应项。
    /// </summary>
    public class BatchListSkillPackageItem 
    {

        /// <summary>
        /// 技能 ID。
        /// </summary>
        [JsonProperty("skill_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("current_package", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentPackageInfo CurrentPackage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchListSkillPackageItem {\n");
            sb.Append("  skillId: ").Append(SkillId).Append("\n");
            sb.Append("  currentPackage: ").Append(CurrentPackage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchListSkillPackageItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchListSkillPackageItem input)
        {
            if (input == null) return false;
            if (this.SkillId != input.SkillId || (this.SkillId != null && !this.SkillId.Equals(input.SkillId))) return false;
            if (this.CurrentPackage != input.CurrentPackage || (this.CurrentPackage != null && !this.CurrentPackage.Equals(input.CurrentPackage))) return false;

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
                if (this.SkillId != null) hashCode = hashCode * 59 + this.SkillId.GetHashCode();
                if (this.CurrentPackage != null) hashCode = hashCode * 59 + this.CurrentPackage.GetHashCode();
                return hashCode;
            }
        }
    }
}
