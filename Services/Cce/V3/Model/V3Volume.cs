using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V3Volume 
    {

        /// <summary>
        /// 磁盘大小，单位为GB  - 系统盘取值范围：40~1024 - 数据盘取值范围：100~32768
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 磁盘类型，取值请参见创建云服务器 中“root_volume字段数据结构说明”。  - SATA：普通IO，是指由SATA存储提供资源的磁盘类型。 - SAS：高IO，是指由SAS存储提供资源的磁盘类型。 - SSD：超高IO，是指由SSD存储提供资源的磁盘类型。
        /// </summary>
        [JsonProperty("volumetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Volumetype { get; set; }

        /// <summary>
        /// 磁盘扩展参数，取值请参见[[创建云服务器](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0020212668.html)](tag:hws)[[创建云服务器](https://support.huaweicloud.com/intl/zh-cn/api-ecs/zh-cn_topic_0020212668.html)](tag:hws_hk)中“extendparam”参数的描述。
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExtendParam { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的存储池的ID。仅用作专属云集群，专属分布式存储DSS的存储池ID，即dssPoolID。  获取方法请参见获取单个专属分布式存储池详情中“表3 响应参数”的ID字段。
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的磁盘存储类型。仅用作专属云集群，固定取值为dss。  
        /// </summary>
        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        /// <summary>
        /// - 使用SDI规格创建虚拟机时请关注该参数，如果该参数值为true，说明创建的为SCSI类型的卷 - 节点池类型为ElasticBMS时，此参数必须填写为true 
        /// </summary>
        [JsonProperty("hw:passthrough", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hwpassthrough { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeMetadata Metadata { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3Volume {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  volumetype: ").Append(Volumetype).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  hwpassthrough: ").Append(Hwpassthrough).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as V3Volume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(V3Volume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Volumetype == input.Volumetype ||
                    (this.Volumetype != null &&
                    this.Volumetype.Equals(input.Volumetype))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    this.ExtendParam != null &&
                    input.ExtendParam != null &&
                    this.ExtendParam.SequenceEqual(input.ExtendParam)
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.ClusterType == input.ClusterType ||
                    (this.ClusterType != null &&
                    this.ClusterType.Equals(input.ClusterType))
                ) && 
                (
                    this.Hwpassthrough == input.Hwpassthrough ||
                    (this.Hwpassthrough != null &&
                    this.Hwpassthrough.Equals(input.Hwpassthrough))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Volumetype != null)
                    hashCode = hashCode * 59 + this.Volumetype.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.Hwpassthrough != null)
                    hashCode = hashCode * 59 + this.Hwpassthrough.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
