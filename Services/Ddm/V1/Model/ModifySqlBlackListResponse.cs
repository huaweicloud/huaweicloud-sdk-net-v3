using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ModifySqlBlackListResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  全量匹配sql黑名单。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("sql_black_list_full_check", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlBlackListFullCheck { get; set; }

        /// <summary>
        /// **参数解释**：  前缀匹配sql黑名单。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("sql_black_list_prefix_check", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlBlackListPrefixCheck { get; set; }

        /// <summary>
        /// **参数解释**：  正则匹配sql黑名单。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("sql_black_list_regex_check", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlBlackListRegexCheck { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifySqlBlackListResponse {\n");
            sb.Append("  sqlBlackListFullCheck: ").Append(SqlBlackListFullCheck).Append("\n");
            sb.Append("  sqlBlackListPrefixCheck: ").Append(SqlBlackListPrefixCheck).Append("\n");
            sb.Append("  sqlBlackListRegexCheck: ").Append(SqlBlackListRegexCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifySqlBlackListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifySqlBlackListResponse input)
        {
            if (input == null) return false;
            if (this.SqlBlackListFullCheck != input.SqlBlackListFullCheck || (this.SqlBlackListFullCheck != null && !this.SqlBlackListFullCheck.Equals(input.SqlBlackListFullCheck))) return false;
            if (this.SqlBlackListPrefixCheck != input.SqlBlackListPrefixCheck || (this.SqlBlackListPrefixCheck != null && !this.SqlBlackListPrefixCheck.Equals(input.SqlBlackListPrefixCheck))) return false;
            if (this.SqlBlackListRegexCheck != input.SqlBlackListRegexCheck || (this.SqlBlackListRegexCheck != null && !this.SqlBlackListRegexCheck.Equals(input.SqlBlackListRegexCheck))) return false;

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
                if (this.SqlBlackListFullCheck != null) hashCode = hashCode * 59 + this.SqlBlackListFullCheck.GetHashCode();
                if (this.SqlBlackListPrefixCheck != null) hashCode = hashCode * 59 + this.SqlBlackListPrefixCheck.GetHashCode();
                if (this.SqlBlackListRegexCheck != null) hashCode = hashCode * 59 + this.SqlBlackListRegexCheck.GetHashCode();
                return hashCode;
            }
        }
    }
}
