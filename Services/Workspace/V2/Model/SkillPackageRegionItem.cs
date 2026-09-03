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
    /// 技能包区域详情项（用于技能包详情中的 regions 列表）。
    /// </summary>
    public class SkillPackageRegionItem 
    {

        /// <summary>
        /// 区域标识。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// OBS 桶名。
        /// </summary>
        [JsonProperty("obs_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucket { get; set; }

        /// <summary>
        /// OBS 对象键。
        /// </summary>
        [JsonProperty("obs_object_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsObjectKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upload_status", NullValueHandling = NullValueHandling.Ignore)]
        public UploadStatusEnum? UploadStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkillPackageRegionItem {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  obsBucket: ").Append(ObsBucket).Append("\n");
            sb.Append("  obsObjectKey: ").Append(ObsObjectKey).Append("\n");
            sb.Append("  uploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SkillPackageRegionItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SkillPackageRegionItem input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ObsBucket != input.ObsBucket || (this.ObsBucket != null && !this.ObsBucket.Equals(input.ObsBucket))) return false;
            if (this.ObsObjectKey != input.ObsObjectKey || (this.ObsObjectKey != null && !this.ObsObjectKey.Equals(input.ObsObjectKey))) return false;
            if (this.UploadStatus != input.UploadStatus || (this.UploadStatus != null && !this.UploadStatus.Equals(input.UploadStatus))) return false;

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
                if (this.ObsBucket != null) hashCode = hashCode * 59 + this.ObsBucket.GetHashCode();
                if (this.ObsObjectKey != null) hashCode = hashCode * 59 + this.ObsObjectKey.GetHashCode();
                if (this.UploadStatus != null) hashCode = hashCode * 59 + this.UploadStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
