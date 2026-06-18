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
    /// 仓库近15日每日代码提交行数增减信息
    /// </summary>
    public class CodelineDto 
    {

        /// <summary>
        /// **参数解释：** 增加行数。 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Additions { get; set; }

        /// <summary>
        /// **参数解释：** 删除行数。 **取值范围：** 最小0 **默认取值：** 0
        /// </summary>
        [JsonProperty("deletions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deletions { get; set; }

        /// <summary>
        /// **参数解释：** 日期，格式&#39;yyyyMMdd&#39;,举例：20251030。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodelineDto {\n");
            sb.Append("  additions: ").Append(Additions).Append("\n");
            sb.Append("  deletions: ").Append(Deletions).Append("\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CodelineDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CodelineDto input)
        {
            if (input == null) return false;
            if (this.Additions != input.Additions || (this.Additions != null && !this.Additions.Equals(input.Additions))) return false;
            if (this.Deletions != input.Deletions || (this.Deletions != null && !this.Deletions.Equals(input.Deletions))) return false;
            if (this.Date != input.Date || (this.Date != null && !this.Date.Equals(input.Date))) return false;

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
                if (this.Additions != null) hashCode = hashCode * 59 + this.Additions.GetHashCode();
                if (this.Deletions != null) hashCode = hashCode * 59 + this.Deletions.GetHashCode();
                if (this.Date != null) hashCode = hashCode * 59 + this.Date.GetHashCode();
                return hashCode;
            }
        }
    }
}
