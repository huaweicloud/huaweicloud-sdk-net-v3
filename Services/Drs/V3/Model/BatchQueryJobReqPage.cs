using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 带分页的批量查询任务详情请求体
    /// </summary>
    public class BatchQueryJobReqPage 
    {

        /// <summary>
        /// 批量查询任务详情
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_req", NullValueHandling = NullValueHandling.Ignore)]
        public PageReq PageReq { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchQueryJobReqPage {\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("  pageReq: ").Append(PageReq).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchQueryJobReqPage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchQueryJobReqPage input)
        {
            if (input == null) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;
            if (this.PageReq != input.PageReq || (this.PageReq != null && !this.PageReq.Equals(input.PageReq))) return false;

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
                if (this.Jobs != null) hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                if (this.PageReq != null) hashCode = hashCode * 59 + this.PageReq.GetHashCode();
                return hashCode;
            }
        }
    }
}
