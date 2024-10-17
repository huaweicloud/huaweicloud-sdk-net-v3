using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 操作单个任务请求体，支持测试连接、预检查、启动、暂停、续传、重置、对比、结束等操作。
    /// </summary>
    public class JobActionReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public ActionReq Job { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobActionReq {\n");
            sb.Append("  job: ").Append(Job).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobActionReq input)
        {
            if (input == null) return false;
            if (this.Job != input.Job || (this.Job != null && !this.Job.Equals(input.Job))) return false;

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
                if (this.Job != null) hashCode = hashCode * 59 + this.Job.GetHashCode();
                return hashCode;
            }
        }
    }
}
