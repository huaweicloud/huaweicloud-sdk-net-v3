using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 修改日志接入请求体
    /// </summary>
    public class UpdateAccessConfigRequestBody 
    {

        /// <summary>
        /// 日志接入ID
        /// </summary>
        [JsonProperty("access_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessConfigId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_config_detail", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigDeatilCreate AccessConfigDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("host_group_info", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigHostGroupIdList HostGroupInfo { get; set; }

        /// <summary>
        /// 标签信息。KEY不能重复,最多20个标签
        /// </summary>
        [JsonProperty("access_config_tag", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessConfigTag> AccessConfigTag { get; set; }

        /// <summary>
        /// 日志拆分
        /// </summary>
        [JsonProperty("log_split", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogSplit { get; set; }

        /// <summary>
        /// 二进制采集
        /// </summary>
        [JsonProperty("binary_collect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BinaryCollect { get; set; }

        /// <summary>
        /// CCE集群ID，CCE类型时，为必填
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAccessConfigRequestBody {\n");
            sb.Append("  accessConfigId: ").Append(AccessConfigId).Append("\n");
            sb.Append("  accessConfigDetail: ").Append(AccessConfigDetail).Append("\n");
            sb.Append("  hostGroupInfo: ").Append(HostGroupInfo).Append("\n");
            sb.Append("  accessConfigTag: ").Append(AccessConfigTag).Append("\n");
            sb.Append("  logSplit: ").Append(LogSplit).Append("\n");
            sb.Append("  binaryCollect: ").Append(BinaryCollect).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAccessConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAccessConfigRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessConfigId == input.AccessConfigId ||
                    (this.AccessConfigId != null &&
                    this.AccessConfigId.Equals(input.AccessConfigId))
                ) && 
                (
                    this.AccessConfigDetail == input.AccessConfigDetail ||
                    (this.AccessConfigDetail != null &&
                    this.AccessConfigDetail.Equals(input.AccessConfigDetail))
                ) && 
                (
                    this.HostGroupInfo == input.HostGroupInfo ||
                    (this.HostGroupInfo != null &&
                    this.HostGroupInfo.Equals(input.HostGroupInfo))
                ) && 
                (
                    this.AccessConfigTag == input.AccessConfigTag ||
                    this.AccessConfigTag != null &&
                    input.AccessConfigTag != null &&
                    this.AccessConfigTag.SequenceEqual(input.AccessConfigTag)
                ) && 
                (
                    this.LogSplit == input.LogSplit ||
                    (this.LogSplit != null &&
                    this.LogSplit.Equals(input.LogSplit))
                ) && 
                (
                    this.BinaryCollect == input.BinaryCollect ||
                    (this.BinaryCollect != null &&
                    this.BinaryCollect.Equals(input.BinaryCollect))
                ) && 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
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
                if (this.AccessConfigId != null)
                    hashCode = hashCode * 59 + this.AccessConfigId.GetHashCode();
                if (this.AccessConfigDetail != null)
                    hashCode = hashCode * 59 + this.AccessConfigDetail.GetHashCode();
                if (this.HostGroupInfo != null)
                    hashCode = hashCode * 59 + this.HostGroupInfo.GetHashCode();
                if (this.AccessConfigTag != null)
                    hashCode = hashCode * 59 + this.AccessConfigTag.GetHashCode();
                if (this.LogSplit != null)
                    hashCode = hashCode * 59 + this.LogSplit.GetHashCode();
                if (this.BinaryCollect != null)
                    hashCode = hashCode * 59 + this.BinaryCollect.GetHashCode();
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
