using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// **参数解释**  设置备份保留策略请求体  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
    /// </summary>
    public class SetBackupRetainPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释**  自动备份保留策略。NONE不保留，LAST保留最后一个，ALL全部保留。  **约束限制**  不涉及       **取值范围**  NONE、LAST、ALL  **默认取值**  不涉及。
        /// </summary>
        [JsonProperty("auto", NullValueHandling = NullValueHandling.Ignore)]
        public string Auto { get; set; }

        /// <summary>
        /// **参数解释**  手动备份保留策略。NONE不保留，LAST保留最后一个，ALL全部保留。  **约束限制**  不涉及      **取值范围**  NONE、LAST、ALL  **默认取值**  不涉及。
        /// </summary>
        [JsonProperty("manual", NullValueHandling = NullValueHandling.Ignore)]
        public string Manual { get; set; }

        /// <summary>
        /// **参数解释**  实例ID列表，实例ID是实例的唯一标识。  **约束限制**  不涉及。  **取值范围**  实例ID只能由英文字母、数字组成，长度为36个字符。  **默认取值**  不涉及。
        /// </summary>
        [JsonProperty("instanceids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Instanceids { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetBackupRetainPolicyRequestBody {\n");
            sb.Append("  auto: ").Append(Auto).Append("\n");
            sb.Append("  manual: ").Append(Manual).Append("\n");
            sb.Append("  instanceids: ").Append(Instanceids).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetBackupRetainPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetBackupRetainPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.Auto != input.Auto || (this.Auto != null && !this.Auto.Equals(input.Auto))) return false;
            if (this.Manual != input.Manual || (this.Manual != null && !this.Manual.Equals(input.Manual))) return false;
            if (this.Instanceids != input.Instanceids || (this.Instanceids != null && input.Instanceids != null && !this.Instanceids.SequenceEqual(input.Instanceids))) return false;

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
                if (this.Auto != null) hashCode = hashCode * 59 + this.Auto.GetHashCode();
                if (this.Manual != null) hashCode = hashCode * 59 + this.Manual.GetHashCode();
                if (this.Instanceids != null) hashCode = hashCode * 59 + this.Instanceids.GetHashCode();
                return hashCode;
            }
        }
    }
}
