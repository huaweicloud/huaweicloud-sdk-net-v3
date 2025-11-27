using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 下载联邦kubeconfig请求体
    /// </summary>
    public class CreateFederationCertRequestBody 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("projectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectID { get; set; }

        /// <summary>
        /// VPC id，必须属于上述项目
        /// </summary>
        [JsonProperty("vpcID", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcID { get; set; }

        /// <summary>
        /// 子网id，必须属于上述vpc
        /// </summary>
        [JsonProperty("subnetID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetID { get; set; }

        /// <summary>
        /// kubeconfig证书有效期，单位为天
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFederationCertRequestBody {\n");
            sb.Append("  projectID: ").Append(ProjectID).Append("\n");
            sb.Append("  vpcID: ").Append(VpcID).Append("\n");
            sb.Append("  subnetID: ").Append(SubnetID).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFederationCertRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFederationCertRequestBody input)
        {
            if (input == null) return false;
            if (this.ProjectID != input.ProjectID || (this.ProjectID != null && !this.ProjectID.Equals(input.ProjectID))) return false;
            if (this.VpcID != input.VpcID || (this.VpcID != null && !this.VpcID.Equals(input.VpcID))) return false;
            if (this.SubnetID != input.SubnetID || (this.SubnetID != null && !this.SubnetID.Equals(input.SubnetID))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.ProjectID != null) hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.VpcID != null) hashCode = hashCode * 59 + this.VpcID.GetHashCode();
                if (this.SubnetID != null) hashCode = hashCode * 59 + this.SubnetID.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
