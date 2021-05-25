using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 附件信息
    /// </summary>
    public class ScalingPolicyV2MetaData 
    {

        /// <summary>
        /// 伸缩带宽策略中带宽对应的共享类型
        /// </summary>
        [JsonProperty("metadata_bandwidth_share_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataBandwidthShareType { get; set; }

        /// <summary>
        /// 伸缩带宽策略中带宽对应的EIP的ID
        /// </summary>
        [JsonProperty("metadata_eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataEipId { get; set; }

        /// <summary>
        /// 伸缩带宽策略中带宽对应的EIP地址
        /// </summary>
        [JsonProperty("metadata_eip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MetadataEipAddress { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingPolicyV2MetaData {\n");
            sb.Append("  metadataBandwidthShareType: ").Append(MetadataBandwidthShareType).Append("\n");
            sb.Append("  metadataEipId: ").Append(MetadataEipId).Append("\n");
            sb.Append("  metadataEipAddress: ").Append(MetadataEipAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingPolicyV2MetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingPolicyV2MetaData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetadataBandwidthShareType == input.MetadataBandwidthShareType ||
                    (this.MetadataBandwidthShareType != null &&
                    this.MetadataBandwidthShareType.Equals(input.MetadataBandwidthShareType))
                ) && 
                (
                    this.MetadataEipId == input.MetadataEipId ||
                    (this.MetadataEipId != null &&
                    this.MetadataEipId.Equals(input.MetadataEipId))
                ) && 
                (
                    this.MetadataEipAddress == input.MetadataEipAddress ||
                    (this.MetadataEipAddress != null &&
                    this.MetadataEipAddress.Equals(input.MetadataEipAddress))
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
                if (this.MetadataBandwidthShareType != null)
                    hashCode = hashCode * 59 + this.MetadataBandwidthShareType.GetHashCode();
                if (this.MetadataEipId != null)
                    hashCode = hashCode * 59 + this.MetadataEipId.GetHashCode();
                if (this.MetadataEipAddress != null)
                    hashCode = hashCode * 59 + this.MetadataEipAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
