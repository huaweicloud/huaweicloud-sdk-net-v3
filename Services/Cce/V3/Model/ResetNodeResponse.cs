using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ResetNodeResponse : SdkResponse
    {

        /// <summary>
        /// 提交任务成功后返回的任务ID，用户可以使用该ID对任务执行情况进行查询。
        /// </summary>
        [JsonProperty("jobid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Jobid { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetNodeResponse {\n");
            sb.Append("  jobid: ").Append(Jobid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetNodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetNodeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Jobid == input.Jobid ||
                    (this.Jobid != null &&
                    this.Jobid.Equals(input.Jobid))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Jobid != null)
                    hashCode = hashCode * 59 + this.Jobid.GetHashCode();
                return hashCode;
            }
        }
    }
}
