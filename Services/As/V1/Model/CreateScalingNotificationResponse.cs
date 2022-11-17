using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateScalingNotificationResponse : SdkResponse
    {

        /// <summary>
        /// SMN服务中Topic的唯一的资源标识。
        /// </summary>
        [JsonProperty("topic_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicUrn { get; set; }

        /// <summary>
        /// 通知场景，有以下五种类型。SCALING_UP：扩容成功。SCALING_UP_FAIL：扩容失败。SCALING_DOWN：减容成功。SCALING_DOWN_FAIL：减容失败。SCALING_GROUP_ABNORMAL：伸缩组发生异常
        /// </summary>
        [JsonProperty("topic_scene", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TopicScene { get; set; }

        /// <summary>
        /// SMN服务中Topic的资源名称。
        /// </summary>
        [JsonProperty("topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScalingNotificationResponse {\n");
            sb.Append("  topicUrn: ").Append(TopicUrn).Append("\n");
            sb.Append("  topicScene: ").Append(TopicScene).Append("\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScalingNotificationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScalingNotificationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopicUrn == input.TopicUrn ||
                    (this.TopicUrn != null &&
                    this.TopicUrn.Equals(input.TopicUrn))
                ) && 
                (
                    this.TopicScene == input.TopicScene ||
                    this.TopicScene != null &&
                    input.TopicScene != null &&
                    this.TopicScene.SequenceEqual(input.TopicScene)
                ) && 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
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
                if (this.TopicUrn != null)
                    hashCode = hashCode * 59 + this.TopicUrn.GetHashCode();
                if (this.TopicScene != null)
                    hashCode = hashCode * 59 + this.TopicScene.GetHashCode();
                if (this.TopicName != null)
                    hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                return hashCode;
            }
        }
    }
}
