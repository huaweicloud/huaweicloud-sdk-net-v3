using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 素材信息。
    /// </summary>
    public class Material 
    {

        /// <summary>
        /// 素材ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 更新者。
        /// </summary>
        [JsonProperty("lastUpdatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("updateTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 素材名称。
        /// </summary>
        [JsonProperty("materialName", NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialName { get; set; }

        /// <summary>
        /// 素材分辨率。
        /// </summary>
        [JsonProperty("materialResolution", NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialResolution { get; set; }

        /// <summary>
        /// 素材大小（含单位）。
        /// </summary>
        [JsonProperty("materialSizeStr", NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialSizeStr { get; set; }

        /// <summary>
        /// 素材云盘存储文件下载地址。
        /// </summary>
        [JsonProperty("filePath", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Material {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  lastUpdatedBy: ").Append(LastUpdatedBy).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  materialName: ").Append(MaterialName).Append("\n");
            sb.Append("  materialResolution: ").Append(MaterialResolution).Append("\n");
            sb.Append("  materialSizeStr: ").Append(MaterialSizeStr).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Material);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Material input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.LastUpdatedBy != input.LastUpdatedBy || (this.LastUpdatedBy != null && !this.LastUpdatedBy.Equals(input.LastUpdatedBy))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.MaterialName != input.MaterialName || (this.MaterialName != null && !this.MaterialName.Equals(input.MaterialName))) return false;
            if (this.MaterialResolution != input.MaterialResolution || (this.MaterialResolution != null && !this.MaterialResolution.Equals(input.MaterialResolution))) return false;
            if (this.MaterialSizeStr != input.MaterialSizeStr || (this.MaterialSizeStr != null && !this.MaterialSizeStr.Equals(input.MaterialSizeStr))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LastUpdatedBy != null) hashCode = hashCode * 59 + this.LastUpdatedBy.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.MaterialName != null) hashCode = hashCode * 59 + this.MaterialName.GetHashCode();
                if (this.MaterialResolution != null) hashCode = hashCode * 59 + this.MaterialResolution.GetHashCode();
                if (this.MaterialSizeStr != null) hashCode = hashCode * 59 + this.MaterialSizeStr.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                return hashCode;
            }
        }
    }
}
