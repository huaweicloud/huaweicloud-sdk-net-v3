using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 作业创建参数
    /// </summary>
    public class AudioModerationResultRequestParams 
    {

        /// <summary>
        /// 创建作业时传的event_type参数
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public AudioModerationResultRequestParamsData Data { get; set; }

        /// <summary>
        /// 创建作业时传的callback参数
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public string Callback { get; set; }

        /// <summary>
        /// 创建作业时传的categories参数
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioModerationResultRequestParams {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  callback: ").Append(Callback).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioModerationResultRequestParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioModerationResultRequestParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Callback == input.Callback ||
                    (this.Callback != null &&
                    this.Callback.Equals(input.Callback))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Callback != null)
                    hashCode = hashCode * 59 + this.Callback.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                return hashCode;
            }
        }
    }
}
