using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateSinkTaskQuotaReq 
    {

        /// <summary>
        /// 转储任务的总个数。 
        /// </summary>
        [JsonProperty("sink_max_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public int? SinkMaxTasks { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSinkTaskQuotaReq {\n");
            sb.Append("  sinkMaxTasks: ").Append(SinkMaxTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSinkTaskQuotaReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSinkTaskQuotaReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SinkMaxTasks == input.SinkMaxTasks ||
                    (this.SinkMaxTasks != null &&
                    this.SinkMaxTasks.Equals(input.SinkMaxTasks))
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
                if (this.SinkMaxTasks != null)
                    hashCode = hashCode * 59 + this.SinkMaxTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
