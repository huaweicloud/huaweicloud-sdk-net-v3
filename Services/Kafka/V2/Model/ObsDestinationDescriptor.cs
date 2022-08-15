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
    public class ObsDestinationDescriptor 
    {
        /// <summary>
        /// 转储启动偏移量：   - latest: 从Topic最后端开始消费。   - earliest: 从Topic最前端消息开始消费。  默认是latest。 
        /// </summary>
        /// <value>转储启动偏移量：   - latest: 从Topic最后端开始消费。   - earliest: 从Topic最前端消息开始消费。  默认是latest。 </value>
        [JsonConverter(typeof(EnumClassConverter<ConsumerStrategyEnum>))]
        public class ConsumerStrategyEnum
        {
            /// <summary>
            /// Enum LATEST for value: latest
            /// </summary>
            public static readonly ConsumerStrategyEnum LATEST = new ConsumerStrategyEnum("latest");

            /// <summary>
            /// Enum EARLIEST for value: earliest
            /// </summary>
            public static readonly ConsumerStrategyEnum EARLIEST = new ConsumerStrategyEnum("earliest");

            private static readonly Dictionary<string, ConsumerStrategyEnum> StaticFields =
            new Dictionary<string, ConsumerStrategyEnum>()
            {
                { "latest", LATEST },
                { "earliest", EARLIEST },
            };

            private string Value;

            public ConsumerStrategyEnum(string value)
            {
                Value = value;
            }

            public static ConsumerStrategyEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ConsumerStrategyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConsumerStrategyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ConsumerStrategyEnum a, ConsumerStrategyEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ConsumerStrategyEnum a, ConsumerStrategyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 转储文件格式。当前只支持text。 
        /// </summary>
        /// <value>转储文件格式。当前只支持text。 </value>
        [JsonConverter(typeof(EnumClassConverter<DestinationFileTypeEnum>))]
        public class DestinationFileTypeEnum
        {
            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            public static readonly DestinationFileTypeEnum TEXT = new DestinationFileTypeEnum("TEXT");

            private static readonly Dictionary<string, DestinationFileTypeEnum> StaticFields =
            new Dictionary<string, DestinationFileTypeEnum>()
            {
                { "TEXT", TEXT },
            };

            private string Value;

            public DestinationFileTypeEnum(string value)
            {
                Value = value;
            }

            public static DestinationFileTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as DestinationFileTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DestinationFileTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DestinationFileTypeEnum a, DestinationFileTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DestinationFileTypeEnum a, DestinationFileTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 转存的topic列表名称，支持多个topic同时放置，以逗号“,”分隔。同时支持正则表达式。 例如topic1,topic2。 
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public string Topics { get; set; }

        /// <summary>
        /// 转存topic的正则表达式，与topics必须二选一，不能同时都设置或者“.*”。 
        /// </summary>
        [JsonProperty("topics_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicsRegex { get; set; }

        /// <summary>
        /// 转储启动偏移量：   - latest: 从Topic最后端开始消费。   - earliest: 从Topic最前端消息开始消费。  默认是latest。 
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public ConsumerStrategyEnum ConsumerStrategy { get; set; }
        /// <summary>
        /// 转储文件格式。当前只支持text。 
        /// </summary>
        [JsonProperty("destination_file_type", NullValueHandling = NullValueHandling.Ignore)]
        public DestinationFileTypeEnum DestinationFileType { get; set; }
        /// <summary>
        /// 访问密钥AK。 
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 访问密钥SK。 
        /// </summary>
        [JsonProperty("secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }

        /// <summary>
        /// 存储该通道数据的OBS桶名称。 
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// 存储在obs的路径，默认可以不填。 取值范围：英文字母、数字、下划线、中划线和斜杠，最大长度为64个字符。 默认配置为空。 
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
        /// 根据用户配置的时间，周期性的将数据导入OBS，若某个时间段内无数据，则此时间段不会生成打包文件。 取值范围：30～900 单位：秒。 &gt; 使用OBS通道转储流式数据时该参数为必选配置。 
        /// </summary>
        [JsonProperty("deliver_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeliverTimeInterval { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsDestinationDescriptor {\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  topicsRegex: ").Append(TopicsRegex).Append("\n");
            sb.Append("  consumerStrategy: ").Append(ConsumerStrategy).Append("\n");
            sb.Append("  destinationFileType: ").Append(DestinationFileType).Append("\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  secretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsPath: ").Append(ObsPath).Append("\n");
            sb.Append("  partitionFormat: ").Append(PartitionFormat).Append("\n");
            sb.Append("  recordDelimiter: ").Append(RecordDelimiter).Append("\n");
            sb.Append("  deliverTimeInterval: ").Append(DeliverTimeInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsDestinationDescriptor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsDestinationDescriptor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Topics == input.Topics ||
                    (this.Topics != null &&
                    this.Topics.Equals(input.Topics))
                ) && 
                (
                    this.TopicsRegex == input.TopicsRegex ||
                    (this.TopicsRegex != null &&
                    this.TopicsRegex.Equals(input.TopicsRegex))
                ) && 
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
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
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
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.TopicsRegex != null)
                    hashCode = hashCode * 59 + this.TopicsRegex.GetHashCode();
                if (this.ConsumerStrategy != null)
                    hashCode = hashCode * 59 + this.ConsumerStrategy.GetHashCode();
                if (this.DestinationFileType != null)
                    hashCode = hashCode * 59 + this.DestinationFileType.GetHashCode();
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.SecretKey != null)
                    hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
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
                return hashCode;
            }
        }
    }
}
