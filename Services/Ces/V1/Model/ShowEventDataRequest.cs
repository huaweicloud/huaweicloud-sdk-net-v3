using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowEventDataRequest 
    {

        /// <summary>
        /// 指标命名空间，如：弹性云服务器的命名空间为SYS.ECS，文档数据库的命名空间为SYS.DDS，各服务的命名空间可查看：“[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 指标的第一层维度，目前最大支持4个维度，维度编号从0开始；维度格式为dim.0&#x3D;key,value，如mongodb_cluster_id,4270ff17-aba3-4138-89fa-820594c39755；key为指标的维度信息，如：文档数据库服务，则第一层维度为mongodb_cluster_id，value为文档数据库实例ID；各服务资源的指标维度名称可查看：“[服务指标维度](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("dim.0", IsQuery = true)]
        [JsonProperty("dim.0", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim0 { get; set; }

        /// <summary>
        /// 指标的第二层维度，目前最大支持4个维度，维度编号从0开始；维度格式为dim.1&#x3D;key,value，如mongos_instance_id,c65d39d7-185c-4616-9aca-ad65703b15f9；key为指标的维度信息，如：文档数据库服务，则第二层维度为mongos_instance_id，value为文档数据库集群实例下的mongos节点ID；各资源的指标维度名称可查看：“[服务指标维度](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("dim.1", IsQuery = true)]
        [JsonProperty("dim.1", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim1 { get; set; }

        /// <summary>
        /// 指标的第三层维度，目前最大支持4个维度，维度编号从0开始；维度格式为dim.2&#x3D;key,value，如mongod_primary_instance_id,5f9498e9-36f8-4317-9ea1-ebe28cba99b4；key为指标的维度信息，如：文档数据库服务，则第三层维度为mongod_primary_instance_id，value为文档数据库实例下的主节点ID；各资源的指标维度名称可查看：“[服务指标维度](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("dim.2", IsQuery = true)]
        [JsonProperty("dim.2", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim2 { get; set; }

        /// <summary>
        /// 指标的第四层维度，目前最大支持4个维度，维度编号从0开始；维度格式为dim.3&#x3D;key,value，如mongod_secondary_instance_id,b46fa2c7-aac6-4ae3-9337-f4ea97f885cb；key为指标的维度信息，如：文档数据库服务，则第四层维度为mongod_secondary_instance_id，value为文档数据库实例下的备节点ID；各资源的指标维度名称可查看：“[服务指标维度](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [SDKProperty("dim.3", IsQuery = true)]
        [JsonProperty("dim.3", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim3 { get; set; }

        /// <summary>
        /// 事件类型，只允许字母、下划线、中划线，字母开头，长度不超过64，如instance_host_info。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 查询数据起始时间，UNIX时间戳，单位毫秒；如：1607146998177。
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// 查询数据截止时间UNIX时间戳，单位毫秒。from必须小于to；如：1607150598177。
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEventDataRequest {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dim0: ").Append(Dim0).Append("\n");
            sb.Append("  dim1: ").Append(Dim1).Append("\n");
            sb.Append("  dim2: ").Append(Dim2).Append("\n");
            sb.Append("  dim3: ").Append(Dim3).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEventDataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEventDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Dim0 == input.Dim0 ||
                    (this.Dim0 != null &&
                    this.Dim0.Equals(input.Dim0))
                ) && 
                (
                    this.Dim1 == input.Dim1 ||
                    (this.Dim1 != null &&
                    this.Dim1.Equals(input.Dim1))
                ) && 
                (
                    this.Dim2 == input.Dim2 ||
                    (this.Dim2 != null &&
                    this.Dim2.Equals(input.Dim2))
                ) && 
                (
                    this.Dim3 == input.Dim3 ||
                    (this.Dim3 != null &&
                    this.Dim3.Equals(input.Dim3))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Dim0 != null)
                    hashCode = hashCode * 59 + this.Dim0.GetHashCode();
                if (this.Dim1 != null)
                    hashCode = hashCode * 59 + this.Dim1.GetHashCode();
                if (this.Dim2 != null)
                    hashCode = hashCode * 59 + this.Dim2.GetHashCode();
                if (this.Dim3 != null)
                    hashCode = hashCode * 59 + this.Dim3.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                return hashCode;
            }
        }
    }
}
