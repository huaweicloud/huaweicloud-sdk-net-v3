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
    /// 批量主备倒换请求体
    /// </summary>
    public class BatchSwitchoverReq 
    {

        /// <summary>
        /// 批量主备调换的任务详情ID请求列表
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Jobs { get; set; }

        /// <summary>
        /// 灾备倒换后是否暂停任务。默认值为false，不暂停灾备任务。
        /// </summary>
        [JsonProperty("is_pause_job", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPauseJob { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSwitchoverReq {\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("  isPauseJob: ").Append(IsPauseJob).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSwitchoverReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSwitchoverReq input)
        {
            if (input == null) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;
            if (this.IsPauseJob != input.IsPauseJob || (this.IsPauseJob != null && !this.IsPauseJob.Equals(input.IsPauseJob))) return false;

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
                if (this.IsPauseJob != null) hashCode = hashCode * 59 + this.IsPauseJob.GetHashCode();
                return hashCode;
            }
        }
    }
}
