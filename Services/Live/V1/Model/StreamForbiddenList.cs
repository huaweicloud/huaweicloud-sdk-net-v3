using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StreamForbiddenList 
    {

        /// <summary>
        /// 流应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 流名称
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }

        /// <summary>
        /// 恢复流时间，格式：yyyy-mm-ddThh:mm:ssZ，UTC时间，不指定则默认7天，最大禁推为90天
        /// </summary>
        [JsonProperty("resume_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ResumeTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamForbiddenList {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("  resumeTime: ").Append(ResumeTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StreamForbiddenList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StreamForbiddenList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.StreamName == input.StreamName ||
                    (this.StreamName != null &&
                    this.StreamName.Equals(input.StreamName))
                ) && 
                (
                    this.ResumeTime == input.ResumeTime ||
                    (this.ResumeTime != null &&
                    this.ResumeTime.Equals(input.ResumeTime))
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
                if (this.AppName != null)
                    hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.StreamName != null)
                    hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                if (this.ResumeTime != null)
                    hashCode = hashCode * 59 + this.ResumeTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
