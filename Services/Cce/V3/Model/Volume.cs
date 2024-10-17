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
    public class Volume 
    {

        /// <summary>
        /// 磁盘大小，单位为GB  - 系统盘取值范围：40~1024 [- 数据盘取值范围：100~32768](tag:sbc,hk_sbc,ctc,cmcc,g42,tm,hk_tm,hk_g42,hcso) [- 第一块数据盘取值范围：20~32768(当缺省磁盘初始化配置管理参数storage时，数据盘取值范围：100-32768)](tag:hws,hws_hk) [- 第一块数据盘取值范围：100~32768](tag:hcs) [- 其他数据盘取值范围：10~32768(当缺省磁盘初始化配置管理参数storage时，数据盘取值范围：100-32768)](tag:hws,hws_hk,hcs)
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 磁盘类型，取值请参见创建云服务器 中“root_volume字段数据结构说明”。  - SAS：高IO，是指由SAS存储提供资源的磁盘类型。 - SSD：超高IO，是指由SSD存储提供资源的磁盘类型。 - SATA：普通IO，是指由SATA存储提供资源的磁盘类型。EVS已下线SATA磁盘，仅存量节点有此类型的磁盘。 [- ESSD：通用型SSD云硬盘，是指由SSD存储提供资源的磁盘类型。](tag:hws) [- GPSDD：通用型SSD云硬盘，是指由SSD存储提供资源的磁盘类型。](tag:hws) [- ESSD2：极速型SSD V2云硬盘，是指由极速型SSD V2存储提供资源的磁盘类型。](tag:hws) [- GPSSD2：通用型SSD V2云硬盘，是指由通用型SSD V2存储提供资源的磁盘类型。](tag:hws) [&gt; 了解不同磁盘类型的详细信息，链接请参见[创建云服务器](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。](tag:hws)
        /// </summary>
        [JsonProperty("volumetype", NullValueHandling = NullValueHandling.Ignore)]
        public string Volumetype { get; set; }

        /// <summary>
        /// 给云硬盘配置iops，购买GPSSD2、ESSD2类型的云硬盘时必填，其他类型不能设置。 &gt; - 只支持按需计费。 &gt; - 了解GPSSD2、ESSD2类型的iops大小范围，请参见[云硬盘类型及性能介绍里面的云硬盘性能数据表](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        [JsonProperty("iops", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iops { get; set; }

        /// <summary>
        /// 给云硬盘配置吞吐量，单位是MiB/s，购买GPSSD2类型云硬盘时必填，其他类型不能设置。 &gt; - 只支持按需计费。 &gt; - 了解GPSSD2类型的吞吐量大小范围，请参见[云硬盘类型及性能介绍里面的云硬盘性能数据表](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        [JsonProperty("throughput", NullValueHandling = NullValueHandling.Ignore)]
        public int? Throughput { get; set; }

        /// <summary>
        /// 磁盘扩展参数，取值请参见创建云服务器中“extendparam”参数的描述。 [链接请参见[创建云服务器](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0020212668.html)](tag:hws) [链接请参见[创建云服务器](https://support.huaweicloud.com/intl/zh-cn/api-ecs/zh-cn_topic_0020212668.html)](tag:hws_hk) 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> ExtendParam { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的存储池的ID。仅用作专属云集群，专属分布式存储DSS的存储池ID，即dssPoolID。  [获取方法请参见[获取单个专属分布式存储池详情](https://support.huaweicloud.com/api-dss/dss_02_1001.html)中“表3 响应参数”的ID字段。](tag:hws) [获取方法请参见[获取单个专属分布式存储池详情](https://support.huaweicloud.com/intl/zh-cn/api-dss/dss_02_1001.html)中“表3 响应参数”的ID字段。](tag:hws_hk)
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 云服务器系统盘对应的磁盘存储类型。仅用作专属云集群，固定取值为dss。  
        /// </summary>
        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        /// <summary>
        /// - 使用SDI规格创建虚拟机时请关注该参数，如果该参数值为true，说明创建的为SCSI类型的卷 - 节点池类型为ElasticBMS时，此参数必须填写为true - 如存在节点规格涉及本地盘并同时使用云硬盘场景时，请设置磁盘初始化配置管理参数，参见[节点磁盘挂载](node_storage_example.xml)。 
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
            sb.Append("class Volume {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  volumetype: ").Append(Volumetype).Append("\n");
            sb.Append("  iops: ").Append(Iops).Append("\n");
            sb.Append("  throughput: ").Append(Throughput).Append("\n");
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
            return this.Equals(input as Volume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Volume input)
        {
            if (input == null) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Volumetype != input.Volumetype || (this.Volumetype != null && !this.Volumetype.Equals(input.Volumetype))) return false;
            if (this.Iops != input.Iops || (this.Iops != null && !this.Iops.Equals(input.Iops))) return false;
            if (this.Throughput != input.Throughput || (this.Throughput != null && !this.Throughput.Equals(input.Throughput))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && input.ExtendParam != null && !this.ExtendParam.SequenceEqual(input.ExtendParam))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ClusterType != input.ClusterType || (this.ClusterType != null && !this.ClusterType.Equals(input.ClusterType))) return false;
            if (this.Hwpassthrough != input.Hwpassthrough || (this.Hwpassthrough != null && !this.Hwpassthrough.Equals(input.Hwpassthrough))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;

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
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Volumetype != null) hashCode = hashCode * 59 + this.Volumetype.GetHashCode();
                if (this.Iops != null) hashCode = hashCode * 59 + this.Iops.GetHashCode();
                if (this.Throughput != null) hashCode = hashCode * 59 + this.Throughput.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterType != null) hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.Hwpassthrough != null) hashCode = hashCode * 59 + this.Hwpassthrough.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
