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
    public class DiskusageEntity 
    {

        /// <summary>
        /// Broker名称。
        /// </summary>
        [JsonProperty("broker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerName { get; set; }

        /// <summary>
        /// 磁盘容量。
        /// </summary>
        [JsonProperty("data_disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskSize { get; set; }

        /// <summary>
        /// 已使用的磁盘容量。
        /// </summary>
        [JsonProperty("data_disk_use", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskUse { get; set; }

        /// <summary>
        /// 剩余可用的磁盘容量。
        /// </summary>
        [JsonProperty("data_disk_free", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskFree { get; set; }

        /// <summary>
        /// 消息标签。
        /// </summary>
        [JsonProperty("data_disk_use_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string DataDiskUsePercentage { get; set; }

        /// <summary>
        /// 消息标签。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// topic磁盘容量使用列表。
        /// </summary>
        [JsonProperty("topic_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiskusageTopicEntity> TopicList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiskusageEntity {\n");
            sb.Append("  brokerName: ").Append(BrokerName).Append("\n");
            sb.Append("  dataDiskSize: ").Append(DataDiskSize).Append("\n");
            sb.Append("  dataDiskUse: ").Append(DataDiskUse).Append("\n");
            sb.Append("  dataDiskFree: ").Append(DataDiskFree).Append("\n");
            sb.Append("  dataDiskUsePercentage: ").Append(DataDiskUsePercentage).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  topicList: ").Append(TopicList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiskusageEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiskusageEntity input)
        {
            if (input == null) return false;
            if (this.BrokerName != input.BrokerName || (this.BrokerName != null && !this.BrokerName.Equals(input.BrokerName))) return false;
            if (this.DataDiskSize != input.DataDiskSize || (this.DataDiskSize != null && !this.DataDiskSize.Equals(input.DataDiskSize))) return false;
            if (this.DataDiskUse != input.DataDiskUse || (this.DataDiskUse != null && !this.DataDiskUse.Equals(input.DataDiskUse))) return false;
            if (this.DataDiskFree != input.DataDiskFree || (this.DataDiskFree != null && !this.DataDiskFree.Equals(input.DataDiskFree))) return false;
            if (this.DataDiskUsePercentage != input.DataDiskUsePercentage || (this.DataDiskUsePercentage != null && !this.DataDiskUsePercentage.Equals(input.DataDiskUsePercentage))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TopicList != input.TopicList || (this.TopicList != null && input.TopicList != null && !this.TopicList.SequenceEqual(input.TopicList))) return false;

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
                if (this.BrokerName != null) hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                if (this.DataDiskSize != null) hashCode = hashCode * 59 + this.DataDiskSize.GetHashCode();
                if (this.DataDiskUse != null) hashCode = hashCode * 59 + this.DataDiskUse.GetHashCode();
                if (this.DataDiskFree != null) hashCode = hashCode * 59 + this.DataDiskFree.GetHashCode();
                if (this.DataDiskUsePercentage != null) hashCode = hashCode * 59 + this.DataDiskUsePercentage.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TopicList != null) hashCode = hashCode * 59 + this.TopicList.GetHashCode();
                return hashCode;
            }
        }
    }
}
