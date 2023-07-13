using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PostTranscriberJobs 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public TranscriberConfig Config { get; set; }

        /// <summary>
        /// 存放在OBS的音频文件路径。OBS的region要和请求服务的region保持一致，region不一致则OBS不可用，即使obs是公开访问权限。
        /// </summary>
        [JsonProperty("data_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DataUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostTranscriberJobs {\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("  dataUrl: ").Append(DataUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostTranscriberJobs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostTranscriberJobs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.DataUrl == input.DataUrl ||
                    (this.DataUrl != null &&
                    this.DataUrl.Equals(input.DataUrl))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.DataUrl != null)
                    hashCode = hashCode * 59 + this.DataUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
