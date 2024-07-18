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
    public class AutopilotClusterExtendParam 
    {

        /// <summary>
        /// 集群所属的企业项目ID。 &gt;   - 需要开通企业项目功能后才可配置企业项目。 &gt;   - 集群所属的企业项目与集群下所关联的其他云服务资源所属的企业项目必须保持一致。 
        /// </summary>
        [JsonProperty("enterpriseProjectId", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 记录集群通过何种升级方式升级到当前版本。 
        /// </summary>
        [JsonProperty("upgradefrom", NullValueHandling = NullValueHandling.Ignore)]
        public string Upgradefrom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutopilotClusterExtendParam {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  upgradefrom: ").Append(Upgradefrom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutopilotClusterExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutopilotClusterExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Upgradefrom == input.Upgradefrom ||
                    (this.Upgradefrom != null &&
                    this.Upgradefrom.Equals(input.Upgradefrom))
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
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Upgradefrom != null)
                    hashCode = hashCode * 59 + this.Upgradefrom.GetHashCode();
                return hashCode;
            }
        }
    }
}
