using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 技能包区域信息（企业自研技能，含上传状态）。服务端根据 slug+version+packageName+region 自动构造 OBS 路径。
    /// </summary>
    public class PackageRegionWithStatusInfo 
    {

        /// <summary>
        /// 区域标识（如 cn-north-7）。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upload_status", NullValueHandling = NullValueHandling.Ignore)]
        public UploadStatusEnum UploadStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageRegionWithStatusInfo {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  uploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageRegionWithStatusInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageRegionWithStatusInfo input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.UploadStatus != input.UploadStatus) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.UploadStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
