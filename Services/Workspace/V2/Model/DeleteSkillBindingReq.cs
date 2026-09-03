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
    /// 批量解绑技能请求。
    /// </summary>
    public class DeleteSkillBindingReq 
    {

        /// <summary>
        /// 实例 ID 列表。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 技能 ID 列表。
        /// </summary>
        [JsonProperty("skill_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SkillIds { get; set; }

        /// <summary>
        /// 标签列表，格式为 key:value，通过标签查询 tbl_desktop_tags 表获取关联实例ID，与 instance_ids 合并后去重。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSkillBindingReq {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  skillIds: ").Append(SkillIds).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSkillBindingReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSkillBindingReq input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.SkillIds != input.SkillIds || (this.SkillIds != null && input.SkillIds != null && !this.SkillIds.SequenceEqual(input.SkillIds))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.SkillIds != null) hashCode = hashCode * 59 + this.SkillIds.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
