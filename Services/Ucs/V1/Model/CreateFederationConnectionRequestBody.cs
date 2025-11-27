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
    /// 创建联邦网络连接请求体
    /// </summary>
    public class CreateFederationConnectionRequestBody 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("projectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectID { get; set; }

        /// <summary>
        /// 虚拟私有云id，必须位于上述项目中
        /// </summary>
        [JsonProperty("vpcID", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcID { get; set; }

        /// <summary>
        /// 子网的网络id，必须位于上述虚拟私有云中
        /// </summary>
        [JsonProperty("subnetID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFederationConnectionRequestBody {\n");
            sb.Append("  projectID: ").Append(ProjectID).Append("\n");
            sb.Append("  vpcID: ").Append(VpcID).Append("\n");
            sb.Append("  subnetID: ").Append(SubnetID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFederationConnectionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFederationConnectionRequestBody input)
        {
            if (input == null) return false;
            if (this.ProjectID != input.ProjectID || (this.ProjectID != null && !this.ProjectID.Equals(input.ProjectID))) return false;
            if (this.VpcID != input.VpcID || (this.VpcID != null && !this.VpcID.Equals(input.VpcID))) return false;
            if (this.SubnetID != input.SubnetID || (this.SubnetID != null && !this.SubnetID.Equals(input.SubnetID))) return false;

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
                return hashCode;
            }
        }
    }
}
