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
    /// Request Object
    /// </summary>
    public class ShowKafkaTopicPartitionDiskusageRequest 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 占用磁盘大小，默认值1G (1K，1M，1G)。
        /// </summary>
        [SDKProperty("minSize", IsQuery = true)]
        [JsonProperty("minSize", NullValueHandling = NullValueHandling.Ignore)]
        public string MinSize { get; set; }

        /// <summary>
        /// 占用磁盘大小，查询top N。
        /// </summary>
        [SDKProperty("top", IsQuery = true)]
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public string Top { get; set; }

        /// <summary>
        /// 占用磁盘大小，查询大于占比的分区。
        /// </summary>
        [SDKProperty("percentage", IsQuery = true)]
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string Percentage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKafkaTopicPartitionDiskusageRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  minSize: ").Append(MinSize).Append("\n");
            sb.Append("  top: ").Append(Top).Append("\n");
            sb.Append("  percentage: ").Append(Percentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKafkaTopicPartitionDiskusageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaTopicPartitionDiskusageRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.MinSize != input.MinSize || (this.MinSize != null && !this.MinSize.Equals(input.MinSize))) return false;
            if (this.Top != input.Top || (this.Top != null && !this.Top.Equals(input.Top))) return false;
            if (this.Percentage != input.Percentage || (this.Percentage != null && !this.Percentage.Equals(input.Percentage))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.MinSize != null) hashCode = hashCode * 59 + this.MinSize.GetHashCode();
                if (this.Top != null) hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.Percentage != null) hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                return hashCode;
            }
        }
    }
}
