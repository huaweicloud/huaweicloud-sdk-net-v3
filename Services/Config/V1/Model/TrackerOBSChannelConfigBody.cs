using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// OBS设置对象。跨帐号授予OBS桶转储文件的权限请参考《用户指南- 资源记录器- 开启/配置/修改资源记录器》中的“跨帐号授权”内容。
    /// </summary>
    public class TrackerOBSChannelConfigBody 
    {

        /// <summary>
        /// OBS桶名称
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// OBS桶前缀
        /// </summary>
        [JsonProperty("bucket_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketPrefix { get; set; }

        /// <summary>
        /// 区域id
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackerOBSChannelConfigBody {\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  bucketPrefix: ").Append(BucketPrefix).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrackerOBSChannelConfigBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrackerOBSChannelConfigBody input)
        {
            if (input == null) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.BucketPrefix != input.BucketPrefix || (this.BucketPrefix != null && !this.BucketPrefix.Equals(input.BucketPrefix))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;

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
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.BucketPrefix != null) hashCode = hashCode * 59 + this.BucketPrefix.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
