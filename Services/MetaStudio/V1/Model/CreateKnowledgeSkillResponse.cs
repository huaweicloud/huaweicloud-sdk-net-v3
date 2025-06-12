using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateKnowledgeSkillResponse : SdkResponse
    {

        /// <summary>
        /// 技能ID。
        /// </summary>
        [JsonProperty("skill_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillId { get; set; }

        /// <summary>
        /// 技能标识。
        /// </summary>
        [JsonProperty("identify", NullValueHandling = NullValueHandling.Ignore)]
        public string Identify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKnowledgeSkillResponse {\n");
            sb.Append("  skillId: ").Append(SkillId).Append("\n");
            sb.Append("  identify: ").Append(Identify).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKnowledgeSkillResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKnowledgeSkillResponse input)
        {
            if (input == null) return false;
            if (this.SkillId != input.SkillId || (this.SkillId != null && !this.SkillId.Equals(input.SkillId))) return false;
            if (this.Identify != input.Identify || (this.Identify != null && !this.Identify.Equals(input.Identify))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.Identify != null) hashCode = hashCode * 59 + this.Identify.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
