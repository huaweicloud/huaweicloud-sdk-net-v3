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
        /// 
        /// </summary>
        [SDKProperty("name", IsPath = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("namespace", IsPath = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("deleteVolume", IsQuery = true)]
        [JsonProperty("deleteVolume", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("storageType", IsQuery = true)]
        [JsonProperty("storageType", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// 
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
