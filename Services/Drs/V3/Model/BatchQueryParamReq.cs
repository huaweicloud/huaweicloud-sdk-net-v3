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
    /// 
    /// </summary>
    public class BatchQueryParamReq 
    {

        /// <summary>
        /// 查询任务ID集合。
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Jobs { get; set; }

        /// <summary>
        /// 是否重新获取数据库参数，1代表是，0代表否（从缓存中获取），第一次调用时请设置为1。
        /// </summary>
        [JsonProperty("refresh", NullValueHandling = NullValueHandling.Ignore)]
        public string Refresh { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchQueryParamReq {\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("  refresh: ").Append(Refresh).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchQueryParamReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchQueryParamReq input)
        {
            if (input == null) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;
            if (this.Refresh != input.Refresh || (this.Refresh != null && !this.Refresh.Equals(input.Refresh))) return false;

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
                if (this.Refresh != null) hashCode = hashCode * 59 + this.Refresh.GetHashCode();
                return hashCode;
            }
        }
    }
}
