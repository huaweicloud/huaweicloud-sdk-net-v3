using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// SQL限流规则和最大并发数
    /// </summary>
    public class SqlFilterRulePattern 
    {

        /// <summary>
        /// **参数解释**：  SQL限流规则。  **取值范围**：  由一个或多个关键字（最多为128个关键字）组成，关键字之间通过\&quot;~\&quot;分隔符分开，如select~from~t1。规则中不能包含‘\\’、中英文逗号、‘~~’，不能以‘~’结尾。
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// **参数解释**：  最大并发数。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("max_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// **参数解释**：  当前并发数。  **取值范围**：  0 - 4294967296。
        /// </summary>
        [JsonProperty("cur_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurConcurrency { get; set; }

        /// <summary>
        /// **参数解释**：  当前拦截次数。  **取值范围**：  0 - 4294967296。
        /// </summary>
        [JsonProperty("cur_reject", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurReject { get; set; }

        /// <summary>
        /// **参数解释**：  SQL限流规则创建时间。  **取值范围**：  0 - 9223372036854775807。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// **参数解释**：  SQL限流规则失效时间。  **取值范围**：  0 - 9223372036854775807。
        /// </summary>
        [JsonProperty("expire_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlFilterRulePattern {\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  maxConcurrency: ").Append(MaxConcurrency).Append("\n");
            sb.Append("  curConcurrency: ").Append(CurConcurrency).Append("\n");
            sb.Append("  curReject: ").Append(CurReject).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  expireAt: ").Append(ExpireAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlFilterRulePattern);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlFilterRulePattern input)
        {
            if (input == null) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.MaxConcurrency != input.MaxConcurrency || (this.MaxConcurrency != null && !this.MaxConcurrency.Equals(input.MaxConcurrency))) return false;
            if (this.CurConcurrency != input.CurConcurrency || (this.CurConcurrency != null && !this.CurConcurrency.Equals(input.CurConcurrency))) return false;
            if (this.CurReject != input.CurReject || (this.CurReject != null && !this.CurReject.Equals(input.CurReject))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.ExpireAt != input.ExpireAt || (this.ExpireAt != null && !this.ExpireAt.Equals(input.ExpireAt))) return false;

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
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.MaxConcurrency != null) hashCode = hashCode * 59 + this.MaxConcurrency.GetHashCode();
                if (this.CurConcurrency != null) hashCode = hashCode * 59 + this.CurConcurrency.GetHashCode();
                if (this.CurReject != null) hashCode = hashCode * 59 + this.CurReject.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.ExpireAt != null) hashCode = hashCode * 59 + this.ExpireAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
