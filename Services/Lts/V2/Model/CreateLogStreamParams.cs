using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 创建日志流参数。
    /// </summary>
    public class CreateLogStreamParams 
    {

        /// <summary>
        /// 需要创建的日志流名称
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogStreamParams {\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLogStreamParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLogStreamParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogStreamName == input.LogStreamName ||
                    (this.LogStreamName != null &&
                    this.LogStreamName.Equals(input.LogStreamName))
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
                if (this.LogStreamName != null)
                    hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}
