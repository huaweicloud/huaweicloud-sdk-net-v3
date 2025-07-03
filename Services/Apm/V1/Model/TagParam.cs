using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TagParam 
    {

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 关键字。
        /// </summary>
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// 是否分页。
        /// </summary>
        [JsonProperty("page_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageEnable { get; set; }

        /// <summary>
        /// 每页容量。
        /// </summary>
        [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 当前页码。
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagParam {\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("  pageEnable: ").Append(PageEnable).Append("\n");
            sb.Append("  pageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagParam input)
        {
            if (input == null) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;
            if (this.PageEnable != input.PageEnable || (this.PageEnable != null && !this.PageEnable.Equals(input.PageEnable))) return false;
            if (this.PageNumber != input.PageNumber || (this.PageNumber != null && !this.PageNumber.Equals(input.PageNumber))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;

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
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                if (this.PageEnable != null) hashCode = hashCode * 59 + this.PageEnable.GetHashCode();
                if (this.PageNumber != null) hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
