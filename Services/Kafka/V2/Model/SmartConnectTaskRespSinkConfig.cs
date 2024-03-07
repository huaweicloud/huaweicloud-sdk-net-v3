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
        /// Redis实例地址。（仅目标端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("redis_address", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisAddress { get; set; }

        /// <summary>
        /// Redis实例类型。（仅目标端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("redis_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisType { get; set; }

        /// <summary>
        /// DCS实例ID。（仅目标端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("dcs_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DcsInstanceId { get; set; }

        /// <summary>
        /// 目标数据库，默认为-1。（仅目标端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("target_db", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetDb { get; set; }

        /// <summary>
        /// 转储启动偏移量，latest为获取最新的数据，earliest为获取最早的数据。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerStrategy { get; set; }

        /// <summary>
        /// 转储文件格式。当前只支持TEXT。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("destination_file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationFileType { get; set; }

        /// <summary>
        /// 记数据转储周期（秒）。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("deliver_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeliverTimeInterval { get; set; }

        /// <summary>
        /// 转储地址。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// 转储目录。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("obs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsPath { get; set; }

        /// <summary>
        /// 时间目录格式。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("partition_format", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionFormat { get; set; }

        /// <summary>
        /// 记录分行符。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("record_delimiter", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordDelimiter { get; set; }

        /// <summary>
        /// 存储Key。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("store_keys", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreKeys { get; set; }

        /// <summary>
        /// 每个传输文件多大后就开始上传，单位为byte；默认值5242880。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("obs_part_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ObsPartSize { get; set; }

        /// <summary>
        /// flush_size。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("flush_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlushSize { get; set; }

        /// <summary>
        /// 时区。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }

        /// <summary>
        /// connector类，默认为\&quot;com.huawei.dms.connector.obs.OBSSinkConnector\&quot;。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("connector_class", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectorClass { get; set; }

        /// <summary>
        /// storage类，默认为com.huawei.dms.connector.obs.storage.OBSStorage\&quot;。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("storage_class", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageClass { get; set; }

        /// <summary>
        /// format类，默认为\&quot;com.huawei.dms.connector.obs.format.bytearray.ByteArrayFormat\&quot;。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("format_class", NullValueHandling = NullValueHandling.Ignore)]
        public string FormatClass { get; set; }

        /// <summary>
        /// schema_generator类，默认为\&quot;io.confluent.connect.storage.hive.schema.DefaultSchemaGenerator\&quot;。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("schema_generator_class", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaGeneratorClass { get; set; }

        /// <summary>
        /// partitioner类，默认\&quot;io.confluent.connect.storage.partitioner.TimeBasedPartitioner\&quot;。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("partitioner_class", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionerClass { get; set; }

        /// <summary>
        /// value_converter，默认为\&quot;org.apache.kafka.connect.converters.ByteArrayConverter\&quot;。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("value_converter", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueConverter { get; set; }

        /// <summary>
        /// key_converter，默认为\&quot;org.apache.kafka.connect.converters.ByteArrayConverter\&quot;。（仅目标端类型为OBS时会显示）
        /// </summary>
        [JsonProperty("key_converter", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyConverter { get; set; }

        /// <summary>
        /// kv_delimiter，默认为\&quot;:\&quot;。（仅目标端类型为OBS时会显示）
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
            sb.Append("  redisAddress: ").Append(RedisAddress).Append("\n");
            sb.Append("  redisType: ").Append(RedisType).Append("\n");
            sb.Append("  dcsInstanceId: ").Append(DcsInstanceId).Append("\n");
            sb.Append("  targetDb: ").Append(TargetDb).Append("\n");
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
            sb.Append("  connectorClass: ").Append(ConnectorClass).Append("\n");
            sb.Append("  storageClass: ").Append(StorageClass).Append("\n");
            sb.Append("  formatClass: ").Append(FormatClass).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.RedisAddress == input.RedisAddress ||
                    (this.RedisAddress != null &&
                    this.RedisAddress.Equals(input.RedisAddress))
                ) && 
                (
                    this.RedisType == input.RedisType ||
                    (this.RedisType != null &&
                    this.RedisType.Equals(input.RedisType))
                ) && 
                (
                    this.DcsInstanceId == input.DcsInstanceId ||
                    (this.DcsInstanceId != null &&
                    this.DcsInstanceId.Equals(input.DcsInstanceId))
                ) && 
                (
                    this.TargetDb == input.TargetDb ||
                    (this.TargetDb != null &&
                    this.TargetDb.Equals(input.TargetDb))
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
                    this.DeliverTimeInterval == input.DeliverTimeInterval ||
                    (this.DeliverTimeInterval != null &&
                    this.DeliverTimeInterval.Equals(input.DeliverTimeInterval))
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
                    this.StoreKeys == input.StoreKeys ||
                    (this.StoreKeys != null &&
                    this.StoreKeys.Equals(input.StoreKeys))
                ) && 
                (
                    this.ObsPartSize == input.ObsPartSize ||
                    (this.ObsPartSize != null &&
                    this.ObsPartSize.Equals(input.ObsPartSize))
                ) && 
                (
                    this.FlushSize == input.FlushSize ||
                    (this.FlushSize != null &&
                    this.FlushSize.Equals(input.FlushSize))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.ConnectorClass == input.ConnectorClass ||
                    (this.ConnectorClass != null &&
                    this.ConnectorClass.Equals(input.ConnectorClass))
                ) && 
                (
                    this.StorageClass == input.StorageClass ||
                    (this.StorageClass != null &&
                    this.StorageClass.Equals(input.StorageClass))
                ) && 
                (
                    this.FormatClass == input.FormatClass ||
                    (this.FormatClass != null &&
                    this.FormatClass.Equals(input.FormatClass))
                ) && 
                (
                    this.SchemaGeneratorClass == input.SchemaGeneratorClass ||
                    (this.SchemaGeneratorClass != null &&
                    this.SchemaGeneratorClass.Equals(input.SchemaGeneratorClass))
                ) && 
                (
                    this.PartitionerClass == input.PartitionerClass ||
                    (this.PartitionerClass != null &&
                    this.PartitionerClass.Equals(input.PartitionerClass))
                ) && 
                (
                    this.ValueConverter == input.ValueConverter ||
                    (this.ValueConverter != null &&
                    this.ValueConverter.Equals(input.ValueConverter))
                ) && 
                (
                    this.KeyConverter == input.KeyConverter ||
                    (this.KeyConverter != null &&
                    this.KeyConverter.Equals(input.KeyConverter))
                ) && 
                (
                    this.KvDelimiter == input.KvDelimiter ||
                    (this.KvDelimiter != null &&
                    this.KvDelimiter.Equals(input.KvDelimiter))
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
                if (this.RedisAddress != null)
                    hashCode = hashCode * 59 + this.RedisAddress.GetHashCode();
                if (this.RedisType != null)
                    hashCode = hashCode * 59 + this.RedisType.GetHashCode();
                if (this.DcsInstanceId != null)
                    hashCode = hashCode * 59 + this.DcsInstanceId.GetHashCode();
                if (this.TargetDb != null)
                    hashCode = hashCode * 59 + this.TargetDb.GetHashCode();
                if (this.ConsumerStrategy != null)
                    hashCode = hashCode * 59 + this.ConsumerStrategy.GetHashCode();
                if (this.DestinationFileType != null)
                    hashCode = hashCode * 59 + this.DestinationFileType.GetHashCode();
                if (this.DeliverTimeInterval != null)
                    hashCode = hashCode * 59 + this.DeliverTimeInterval.GetHashCode();
                if (this.ObsBucketName != null)
                    hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsPath != null)
                    hashCode = hashCode * 59 + this.ObsPath.GetHashCode();
                if (this.PartitionFormat != null)
                    hashCode = hashCode * 59 + this.PartitionFormat.GetHashCode();
                if (this.RecordDelimiter != null)
                    hashCode = hashCode * 59 + this.RecordDelimiter.GetHashCode();
                if (this.StoreKeys != null)
                    hashCode = hashCode * 59 + this.StoreKeys.GetHashCode();
                if (this.ObsPartSize != null)
                    hashCode = hashCode * 59 + this.ObsPartSize.GetHashCode();
                if (this.FlushSize != null)
                    hashCode = hashCode * 59 + this.FlushSize.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.ConnectorClass != null)
                    hashCode = hashCode * 59 + this.ConnectorClass.GetHashCode();
                if (this.StorageClass != null)
                    hashCode = hashCode * 59 + this.StorageClass.GetHashCode();
                if (this.FormatClass != null)
                    hashCode = hashCode * 59 + this.FormatClass.GetHashCode();
                if (this.SchemaGeneratorClass != null)
                    hashCode = hashCode * 59 + this.SchemaGeneratorClass.GetHashCode();
                if (this.PartitionerClass != null)
                    hashCode = hashCode * 59 + this.PartitionerClass.GetHashCode();
                if (this.ValueConverter != null)
                    hashCode = hashCode * 59 + this.ValueConverter.GetHashCode();
                if (this.KeyConverter != null)
                    hashCode = hashCode * 59 + this.KeyConverter.GetHashCode();
                if (this.KvDelimiter != null)
                    hashCode = hashCode * 59 + this.KvDelimiter.GetHashCode();
                return hashCode;
            }
        }
    }
}
