using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryRequirementsOverviewInfo 
    {

        /// <summary>
        /// 筛选迭代ID
        /// </summary>
        [JsonProperty("fixed_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedVersionId { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pi_filter", NullValueHandling = NullValueHandling.Ignore)]
        public PiFilterInfo PiFilter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRequirementsOverviewInfo {\n");
            sb.Append("  fixedVersionId: ").Append(FixedVersionId).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  piFilter: ").Append(PiFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRequirementsOverviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRequirementsOverviewInfo input)
        {
            if (input == null) return false;
            if (this.FixedVersionId != input.FixedVersionId || (this.FixedVersionId != null && !this.FixedVersionId.Equals(input.FixedVersionId))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PiFilter != input.PiFilter || (this.PiFilter != null && !this.PiFilter.Equals(input.PiFilter))) return false;

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
                if (this.FixedVersionId != null) hashCode = hashCode * 59 + this.FixedVersionId.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PiFilter != null) hashCode = hashCode * 59 + this.PiFilter.GetHashCode();
                return hashCode;
            }
        }
    }
}
