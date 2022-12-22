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
    /// 转存目标的描述。
    /// </summary>
    public class ShowSinkTaskDetailRespObsDestinationDescriptor 
    {

        /// <summary>
        /// 消费启动策略：  - latest：从Topic最后端开始消费。  - earliest: 从Topic最前端消息开始消费。  默认是latest。 
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerStrategy { get; set; }

        /// <summary>
        /// 转储文件格式。目前只支持text格式。 
        /// </summary>
        [JsonProperty("destination_file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationFileType { get; set; }

        /// <summary>
        /// 存储该通道数据的OBS桶名称。 
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// 存储在obs的路径。 
        /// </summary>
        [JsonProperty("obs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPath { get; set; }

        /// <summary>
        /// 将转储文件的生成时间使用“yyyy/MM/dd/HH/mm”格式生成分区字符串，用来定义写到OBS的Object文件所在的目录层次结构。   - N/A：置空，不使用日期时间目录。   - yyyy：年   - yyyy/MM：年/月   - yyyy/MM/dd：年/月/日   - yyyy/MM/dd/HH：年/月/日/时   - yyyy/MM/dd/HH/mm：年/月/日/时/分，例如：2017/11/10/14/49，目录结构就是“2017 &gt; 11 &gt; 10 &gt; 14 &gt; 49”，“2017”表示最外层文件夹。  默认值：空 &gt; 数据转储成功后，存储的目录结构为“obs_bucket_path/file_prefix/partition_format”。默认时间是GMT+8 时间 
        /// </summary>
        [JsonProperty("partition_format", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionFormat { get; set; }

        /// <summary>
        /// 转储文件的记录分隔符，用于分隔写入转储文件的用户数据。 取值范围：   - 逗号“,”   - 分号“;”   - 竖线“|”   - 换行符“\\n”   - NULL  默认值：换行符“\\n”。 
        /// </summary>
        [JsonProperty("record_delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDelimiter { get; set; }

        /// <summary>
        /// 根据用户配置的时间，周期性的将数据导入OBS，若某个时间段内无数据，则此时间段不会生成打包文件。 取值范围：30～900 缺省值：300 单位：秒。 &gt; 使用OBS通道转储流式数据时该参数为必选配置。 
        /// </summary>
        [JsonProperty("deliver_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeliverTimeInterval { get; set; }

        /// <summary>
        /// 每个传输文件多大后就开始上传，单位为byte。 默认值5242880。 
        /// </summary>
        [JsonProperty("obs_part_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? ObsPartSize { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSinkTaskDetailRespObsDestinationDescriptor {\n");
            sb.Append("  consumerStrategy: ").Append(ConsumerStrategy).Append("\n");
            sb.Append("  destinationFileType: ").Append(DestinationFileType).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsPath: ").Append(ObsPath).Append("\n");
            sb.Append("  partitionFormat: ").Append(PartitionFormat).Append("\n");
            sb.Append("  recordDelimiter: ").Append(RecordDelimiter).Append("\n");
            sb.Append("  deliverTimeInterval: ").Append(DeliverTimeInterval).Append("\n");
            sb.Append("  obsPartSize: ").Append(ObsPartSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSinkTaskDetailRespObsDestinationDescriptor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSinkTaskDetailRespObsDestinationDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerStrategy == input.ConsumerStrategy ||
                    (this.ConsumerStrategy != null &&
                    this.ConsumerStrategy.Equals(input.ConsumerStrategy))
                ) && 
                (
                    this.DestinationFileType == input.DestinationFileType ||
                    (this.DestinationFileType != null &&
                    this.DestinationFileType.Equals(input.DestinationFileType))
                ) && 
                (
                    this.ObsBucketName == input.ObsBucketName ||
                    (this.ObsBucketName != null &&
                    this.ObsBucketName.Equals(input.ObsBucketName))
                ) && 
                (
                    this.ObsPath == input.ObsPath ||
                    (this.ObsPath != null &&
                    this.ObsPath.Equals(input.ObsPath))
                ) && 
                (
                    this.PartitionFormat == input.PartitionFormat ||
                    (this.PartitionFormat != null &&
                    this.PartitionFormat.Equals(input.PartitionFormat))
                ) && 
                (
                    this.RecordDelimiter == input.RecordDelimiter ||
                    (this.RecordDelimiter != null &&
                    this.RecordDelimiter.Equals(input.RecordDelimiter))
                ) && 
                (
                    this.DeliverTimeInterval == input.DeliverTimeInterval ||
                    (this.DeliverTimeInterval != null &&
                    this.DeliverTimeInterval.Equals(input.DeliverTimeInterval))
                ) && 
                (
                    this.ObsPartSize == input.ObsPartSize ||
                    (this.ObsPartSize != null &&
                    this.ObsPartSize.Equals(input.ObsPartSize))
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
                if (this.ConsumerStrategy != null)
                    hashCode = hashCode * 59 + this.ConsumerStrategy.GetHashCode();
                if (this.DestinationFileType != null)
                    hashCode = hashCode * 59 + this.DestinationFileType.GetHashCode();
                if (this.ObsBucketName != null)
                    hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsPath != null)
                    hashCode = hashCode * 59 + this.ObsPath.GetHashCode();
                if (this.PartitionFormat != null)
                    hashCode = hashCode * 59 + this.PartitionFormat.GetHashCode();
                if (this.RecordDelimiter != null)
                    hashCode = hashCode * 59 + this.RecordDelimiter.GetHashCode();
                if (this.DeliverTimeInterval != null)
                    hashCode = hashCode * 59 + this.DeliverTimeInterval.GetHashCode();
                if (this.ObsPartSize != null)
                    hashCode = hashCode * 59 + this.ObsPartSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
