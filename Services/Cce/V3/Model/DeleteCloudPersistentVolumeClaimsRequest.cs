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
    /// Request Object
    /// </summary>
    public class DeleteCloudPersistentVolumeClaimsRequest 
    {

        /// <summary>
        /// 需要删除的PersistentVolumClaim的名称。 
        /// </summary>
        [SDKProperty("name", IsPath = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 指定PersistentVolumeClaim所在的命名空间。 
        /// </summary>
        [SDKProperty("namespace", IsPath = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 删除PersistentVolumeClaim后是否保留后端关联的云存储。false表示不删除，true表示删除，默认为false。 
        /// </summary>
        [SDKProperty("deleteVolume", IsQuery = true)]
        [JsonProperty("deleteVolume", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteVolume { get; set; }

        /// <summary>
        /// 云存储的类型，和deleteVolume搭配使用。即deleteVolume和storageType必须同时配置。 - bs：EVS云硬盘存储 - nfs：SFS弹性文件存储 - obs：OBS对象存储 - efs：SFS Turbo极速文件存储 
        /// </summary>
        [SDKProperty("storageType", IsQuery = true)]
        [JsonProperty("storageType", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// 集群ID，使用**https://Endpoint/uri**这种URL格式时必须指定此参数。获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 
        /// </summary>
        [SDKProperty("X-Cluster-ID", IsHeader = true)]
        [JsonProperty("X-Cluster-ID", NullValueHandling = NullValueHandling.Ignore)]
        public string XClusterID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteCloudPersistentVolumeClaimsRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  deleteVolume: ").Append(DeleteVolume).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  xClusterID: ").Append(XClusterID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteCloudPersistentVolumeClaimsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteCloudPersistentVolumeClaimsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.DeleteVolume == input.DeleteVolume ||
                    (this.DeleteVolume != null &&
                    this.DeleteVolume.Equals(input.DeleteVolume))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.XClusterID == input.XClusterID ||
                    (this.XClusterID != null &&
                    this.XClusterID.Equals(input.XClusterID))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.DeleteVolume != null)
                    hashCode = hashCode * 59 + this.DeleteVolume.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.XClusterID != null)
                    hashCode = hashCode * 59 + this.XClusterID.GetHashCode();
                return hashCode;
            }
        }
    }
}
