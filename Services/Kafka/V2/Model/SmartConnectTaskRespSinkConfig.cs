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
    public class SmartConnectTaskRespSinkConfig 
    {

        /// <summary>
        /// **参数解释**： 转储启动偏移量。（仅目标端类型为OBS时会显示） **取值范围**： - latest：获取最新的数据。 - earliest：获取最早的数据。
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerStrategy { get; set; }

        /// <summary>
        /// **参数解释**： 转储文件格式。当前只支持TEXT。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("destination_file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationFileType { get; set; }

        /// <summary>
        /// **参数解释**： 数据转储周期（秒）。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("deliver_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeliverTimeInterval { get; set; }

        /// <summary>
        /// **参数解释**： 转储地址。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// **参数解释**： 转储目录。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("obs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPath { get; set; }

        /// <summary>
        /// **参数解释**： 时间目录格式。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("partition_format", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionFormat { get; set; }

        /// <summary>
        /// **参数解释**： 记录分行符。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("record_delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDelimiter { get; set; }

        /// <summary>
        /// **参数解释**： 存储Key。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("store_keys", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreKeys { get; set; }

        /// <summary>
        /// **参数解释**： 每个传输文件多大后就开始上传，单位为byte；默认值5242880。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("obs_part_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ObsPartSize { get; set; }

        /// <summary>
        /// **参数解释**： 刷写数量。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("flush_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlushSize { get; set; }

        /// <summary>
        /// **参数解释**： 时区。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// **参数解释**： schema_generator类，默认为\&quot;io.confluent.connect.storage.hive.schema.DefaultSchemaGenerator\&quot;。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("schema_generator_class", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaGeneratorClass { get; set; }

        /// <summary>
        /// **参数解释**： partitioner类，默认\&quot;io.confluent.connect.storage.partitioner.TimeBasedPartitioner\&quot;。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("partitioner_class", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionerClass { get; set; }

        /// <summary>
        /// **参数解释**： 值转换器，默认为\&quot;org.apache.kafka.connect.converters.ByteArrayConverter\&quot;。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("value_converter", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueConverter { get; set; }

        /// <summary>
        /// **参数解释**： 键转换器，默认为\&quot;org.apache.kafka.connect.converters.ByteArrayConverter\&quot;。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("key_converter", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyConverter { get; set; }

        /// <summary>
        /// **参数解释**： 键值分隔符，默认为\&quot;:\&quot;。（仅目标端类型为OBS时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("kv_delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string KvDelimiter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartConnectTaskRespSinkConfig {\n");
            sb.Append("  consumerStrategy: ").Append(ConsumerStrategy).Append("\n");
            sb.Append("  destinationFileType: ").Append(DestinationFileType).Append("\n");
            sb.Append("  deliverTimeInterval: ").Append(DeliverTimeInterval).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsPath: ").Append(ObsPath).Append("\n");
            sb.Append("  partitionFormat: ").Append(PartitionFormat).Append("\n");
            sb.Append("  recordDelimiter: ").Append(RecordDelimiter).Append("\n");
            sb.Append("  storeKeys: ").Append(StoreKeys).Append("\n");
            sb.Append("  obsPartSize: ").Append(ObsPartSize).Append("\n");
            sb.Append("  flushSize: ").Append(FlushSize).Append("\n");
            sb.Append("  timezone: ").Append(Timezone).Append("\n");
            sb.Append("  schemaGeneratorClass: ").Append(SchemaGeneratorClass).Append("\n");
            sb.Append("  partitionerClass: ").Append(PartitionerClass).Append("\n");
            sb.Append("  valueConverter: ").Append(ValueConverter).Append("\n");
            sb.Append("  keyConverter: ").Append(KeyConverter).Append("\n");
            sb.Append("  kvDelimiter: ").Append(KvDelimiter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartConnectTaskRespSinkConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartConnectTaskRespSinkConfig input)
        {
            if (input == null) return false;
            if (this.ConsumerStrategy != input.ConsumerStrategy || (this.ConsumerStrategy != null && !this.ConsumerStrategy.Equals(input.ConsumerStrategy))) return false;
            if (this.DestinationFileType != input.DestinationFileType || (this.DestinationFileType != null && !this.DestinationFileType.Equals(input.DestinationFileType))) return false;
            if (this.DeliverTimeInterval != input.DeliverTimeInterval || (this.DeliverTimeInterval != null && !this.DeliverTimeInterval.Equals(input.DeliverTimeInterval))) return false;
            if (this.ObsBucketName != input.ObsBucketName || (this.ObsBucketName != null && !this.ObsBucketName.Equals(input.ObsBucketName))) return false;
            if (this.ObsPath != input.ObsPath || (this.ObsPath != null && !this.ObsPath.Equals(input.ObsPath))) return false;
            if (this.PartitionFormat != input.PartitionFormat || (this.PartitionFormat != null && !this.PartitionFormat.Equals(input.PartitionFormat))) return false;
            if (this.RecordDelimiter != input.RecordDelimiter || (this.RecordDelimiter != null && !this.RecordDelimiter.Equals(input.RecordDelimiter))) return false;
            if (this.StoreKeys != input.StoreKeys || (this.StoreKeys != null && !this.StoreKeys.Equals(input.StoreKeys))) return false;
            if (this.ObsPartSize != input.ObsPartSize || (this.ObsPartSize != null && !this.ObsPartSize.Equals(input.ObsPartSize))) return false;
            if (this.FlushSize != input.FlushSize || (this.FlushSize != null && !this.FlushSize.Equals(input.FlushSize))) return false;
            if (this.Timezone != input.Timezone || (this.Timezone != null && !this.Timezone.Equals(input.Timezone))) return false;
            if (this.SchemaGeneratorClass != input.SchemaGeneratorClass || (this.SchemaGeneratorClass != null && !this.SchemaGeneratorClass.Equals(input.SchemaGeneratorClass))) return false;
            if (this.PartitionerClass != input.PartitionerClass || (this.PartitionerClass != null && !this.PartitionerClass.Equals(input.PartitionerClass))) return false;
            if (this.ValueConverter != input.ValueConverter || (this.ValueConverter != null && !this.ValueConverter.Equals(input.ValueConverter))) return false;
            if (this.KeyConverter != input.KeyConverter || (this.KeyConverter != null && !this.KeyConverter.Equals(input.KeyConverter))) return false;
            if (this.KvDelimiter != input.KvDelimiter || (this.KvDelimiter != null && !this.KvDelimiter.Equals(input.KvDelimiter))) return false;

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
                if (this.ObsBucketName != null) hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsPath != null) hashCode = hashCode * 59 + this.ObsPath.GetHashCode();
                if (this.PartitionFormat != null) hashCode = hashCode * 59 + this.PartitionFormat.GetHashCode();
                if (this.RecordDelimiter != null) hashCode = hashCode * 59 + this.RecordDelimiter.GetHashCode();
                if (this.StoreKeys != null) hashCode = hashCode * 59 + this.StoreKeys.GetHashCode();
                if (this.ObsPartSize != null) hashCode = hashCode * 59 + this.ObsPartSize.GetHashCode();
                if (this.FlushSize != null) hashCode = hashCode * 59 + this.FlushSize.GetHashCode();
                if (this.Timezone != null) hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.SchemaGeneratorClass != null) hashCode = hashCode * 59 + this.SchemaGeneratorClass.GetHashCode();
                if (this.PartitionerClass != null) hashCode = hashCode * 59 + this.PartitionerClass.GetHashCode();
                if (this.ValueConverter != null) hashCode = hashCode * 59 + this.ValueConverter.GetHashCode();
                if (this.KeyConverter != null) hashCode = hashCode * 59 + this.KeyConverter.GetHashCode();
                if (this.KvDelimiter != null) hashCode = hashCode * 59 + this.KvDelimiter.GetHashCode();
                return hashCode;
            }
        }
    }
}
