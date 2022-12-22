using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class BatchCreatePublicipsV2RequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BatchBandwidth Bandwidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publicip", NullValueHandling = NullValueHandling.Ignore)]
        public BatchPublicIp Publicip { get; set; }

        /// <summary>
        /// 批量创建EIP的个数
        /// </summary>
        [JsonProperty("publicip_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicipNumber { get; set; }

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreatePublicipsV2RequestBody {\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  publicip: ").Append(Publicip).Append("\n");
            sb.Append("  publicipNumber: ").Append(PublicipNumber).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreatePublicipsV2RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreatePublicipsV2RequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
                ) && 
                (
                    this.Publicip == input.Publicip ||
                    (this.Publicip != null &&
                    this.Publicip.Equals(input.Publicip))
                ) && 
                (
                    this.PublicipNumber == input.PublicipNumber ||
                    (this.PublicipNumber != null &&
                    this.PublicipNumber.Equals(input.PublicipNumber))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.Publicip != null)
                    hashCode = hashCode * 59 + this.Publicip.GetHashCode();
                if (this.PublicipNumber != null)
                    hashCode = hashCode * 59 + this.PublicipNumber.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
