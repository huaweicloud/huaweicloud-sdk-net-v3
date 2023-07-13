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
    /// 创建单个任务请求体。
    /// </summary>
    public class SingleCreateJobReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public CreateJobReq Job { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleCreateJobReq {\n");
            sb.Append("  job: ").Append(Job).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SingleCreateJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SingleCreateJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
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
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                return hashCode;
            }
        }
    }
}
