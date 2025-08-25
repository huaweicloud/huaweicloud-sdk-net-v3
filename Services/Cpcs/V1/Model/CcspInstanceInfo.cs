using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CcspInstanceInfo 
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// cbc资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例所属的服务
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 实例所属的集群的ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 实例的健康状态
        /// </summary>
        [JsonProperty("is_normal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNormal { get; set; }

        /// <summary>
        /// 实例的服务状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例的镜像名称
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 实例的虚机规格
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// az
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }

        /// <summary>
        /// 超期时间
        /// </summary>
        [JsonProperty("expired_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// 实例的创建时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CcspInstanceInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  isNormal: ").Append(IsNormal).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("  expiredTime: ").Append(ExpiredTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CcspInstanceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CcspInstanceInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.IsNormal != input.IsNormal || (this.IsNormal != null && !this.IsNormal.Equals(input.IsNormal))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.Specification != input.Specification || (this.Specification != null && !this.Specification.Equals(input.Specification))) return false;
            if (this.Az != input.Az || (this.Az != null && !this.Az.Equals(input.Az))) return false;
            if (this.ExpiredTime != input.ExpiredTime || (this.ExpiredTime != null && !this.ExpiredTime.Equals(input.ExpiredTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.IsNormal != null) hashCode = hashCode * 59 + this.IsNormal.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.Specification != null) hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.Az != null) hashCode = hashCode * 59 + this.Az.GetHashCode();
                if (this.ExpiredTime != null) hashCode = hashCode * 59 + this.ExpiredTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
