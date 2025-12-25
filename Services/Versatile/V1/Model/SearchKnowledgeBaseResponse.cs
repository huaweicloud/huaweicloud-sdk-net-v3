using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SearchKnowledgeBaseResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 检索结果总数。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 检索结果列表。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("retrieve_result_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetrievalResultInfo> RetrieveResultList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchKnowledgeBaseResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  retrieveResultList: ").Append(RetrieveResultList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchKnowledgeBaseResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchKnowledgeBaseResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.RetrieveResultList != input.RetrieveResultList || (this.RetrieveResultList != null && input.RetrieveResultList != null && !this.RetrieveResultList.SequenceEqual(input.RetrieveResultList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.RetrieveResultList != null) hashCode = hashCode * 59 + this.RetrieveResultList.GetHashCode();
                return hashCode;
            }
        }
    }
}
