using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecordData 
    {

        /// <summary>
        /// 最大并发路数。
        /// </summary>
        [JsonProperty("concurrent_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentCount { get; set; }

        /// <summary>
        /// 采样时间，每小时内最大并发路数时间点。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ 。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordData {\n");
            sb.Append("  concurrentCount: ").Append(ConcurrentCount).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConcurrentCount == input.ConcurrentCount ||
                    (this.ConcurrentCount != null &&
                    this.ConcurrentCount.Equals(input.ConcurrentCount))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.ConcurrentCount != null)
                    hashCode = hashCode * 59 + this.ConcurrentCount.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}
