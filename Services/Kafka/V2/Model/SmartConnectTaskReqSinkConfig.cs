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
    public class SmartConnectTaskReqSinkConfig 
    {

        /// <summary>
        /// 转储启动偏移量，latest为获取最新的数据，earliest为获取最早的数据。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerStrategy { get; set; }

        /// <summary>
        /// 转储文件格式。当前只支持TEXT。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("destination_file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationFileType { get; set; }

        /// <summary>
        /// 数据转储周期（秒），默认配置为300秒。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("deliver_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeliverTimeInterval { get; set; }

        /// <summary>
        /// AK，访问密钥ID。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// SK，与访问密钥ID结合使用的密钥。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }

        /// <summary>
        /// 转储地址，即存储Topic数据的OBS桶的名称。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// 转储目录，即OBS中存储Topic的目录，多级目录可以用“/”进行分隔。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("obs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPath { get; set; }

        /// <summary>
        /// 时间目录格式。（仅目标端类型为OBS时需要填写）   - yyyy：年   - yyyy/MM：年/月   - yyyy/MM/dd：年/月/日   - yyyy/MM/dd/HH：年/月/日/时   - yyyy/MM/dd/HH/mm：年/月/日/时/分 
        /// </summary>
        [JsonProperty("partition_format", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionFormat { get; set; }

        /// <summary>
        ///  记录分行符，用于分隔写入转储文件的用户数据。（仅目标端类型为OBS时需要填写）   取值范围：   - 逗号“,”   - 分号“;”   - 竖线“|”   - 换行符“\\n”   - NULL 
        /// </summary>
        [JsonProperty("record_delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDelimiter { get; set; }

        /// <summary>
        /// 是否转储Key，开启表示转储Key，关闭表示不转储Key。（仅目标端类型为OBS时需要填写）
        /// </summary>
        [JsonProperty("store_keys", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartConnectTaskReqSinkConfig {\n");
            sb.Append("  consumerStrategy: ").Append(ConsumerStrategy).Append("\n");
            sb.Append("  destinationFileType: ").Append(DestinationFileType).Append("\n");
            sb.Append("  deliverTimeInterval: ").Append(DeliverTimeInterval).Append("\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  secretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsPath: ").Append(ObsPath).Append("\n");
            sb.Append("  partitionFormat: ").Append(PartitionFormat).Append("\n");
            sb.Append("  recordDelimiter: ").Append(RecordDelimiter).Append("\n");
            sb.Append("  storeKeys: ").Append(StoreKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartConnectTaskReqSinkConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartConnectTaskReqSinkConfig input)
        {
            if (input == null) return false;
            if (this.ConsumerStrategy != input.ConsumerStrategy || (this.ConsumerStrategy != null && !this.ConsumerStrategy.Equals(input.ConsumerStrategy))) return false;
            if (this.DestinationFileType != input.DestinationFileType || (this.DestinationFileType != null && !this.DestinationFileType.Equals(input.DestinationFileType))) return false;
            if (this.DeliverTimeInterval != input.DeliverTimeInterval || (this.DeliverTimeInterval != null && !this.DeliverTimeInterval.Equals(input.DeliverTimeInterval))) return false;
            if (this.AccessKey != input.AccessKey || (this.AccessKey != null && !this.AccessKey.Equals(input.AccessKey))) return false;
            if (this.SecretKey != input.SecretKey || (this.SecretKey != null && !this.SecretKey.Equals(input.SecretKey))) return false;
            if (this.ObsBucketName != input.ObsBucketName || (this.ObsBucketName != null && !this.ObsBucketName.Equals(input.ObsBucketName))) return false;
            if (this.ObsPath != input.ObsPath || (this.ObsPath != null && !this.ObsPath.Equals(input.ObsPath))) return false;
            if (this.PartitionFormat != input.PartitionFormat || (this.PartitionFormat != null && !this.PartitionFormat.Equals(input.PartitionFormat))) return false;
            if (this.RecordDelimiter != input.RecordDelimiter || (this.RecordDelimiter != null && !this.RecordDelimiter.Equals(input.RecordDelimiter))) return false;
            if (this.StoreKeys != input.StoreKeys || (this.StoreKeys != null && !this.StoreKeys.Equals(input.StoreKeys))) return false;

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
                if (this.ConsumerStrategy != null) hashCode = hashCode * 59 + this.ConsumerStrategy.GetHashCode();
                if (this.DestinationFileType != null) hashCode = hashCode * 59 + this.DestinationFileType.GetHashCode();
                if (this.DeliverTimeInterval != null) hashCode = hashCode * 59 + this.DeliverTimeInterval.GetHashCode();
                if (this.AccessKey != null) hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.SecretKey != null) hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.ObsBucketName != null) hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsPath != null) hashCode = hashCode * 59 + this.ObsPath.GetHashCode();
                if (this.PartitionFormat != null) hashCode = hashCode * 59 + this.PartitionFormat.GetHashCode();
                if (this.RecordDelimiter != null) hashCode = hashCode * 59 + this.RecordDelimiter.GetHashCode();
                if (this.StoreKeys != null) hashCode = hashCode * 59 + this.StoreKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
