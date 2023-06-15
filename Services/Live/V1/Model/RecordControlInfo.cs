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
    public class RecordControlInfo 
    {

        /// <summary>
        /// 直播推流域名
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 待启动或停止录制的流名
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordControlInfo {\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordControlInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordControlInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublishDomain == input.PublishDomain ||
                    (this.PublishDomain != null &&
                    this.PublishDomain.Equals(input.PublishDomain))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
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
                if (this.PublishDomain != null)
                    hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                return hashCode;
            }
        }
    }
}
