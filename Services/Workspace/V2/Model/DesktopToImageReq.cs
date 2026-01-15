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
    /// 桌面转镜像请求。
    /// </summary>
    public class DesktopToImageReq 
    {

        /// <summary>
        /// 镜像名称。
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像描述信息。
        /// </summary>
        [JsonProperty("image_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageDescription { get; set; }

        /// <summary>
        /// 用于制作镜像的云桌面的InstanceID。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 是否执行系统封装步骤。
        /// </summary>
        [JsonProperty("execute_sysprep", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteSysprep { get; set; }

        /// <summary>
        /// 镜像标签列表。
        /// </summary>
        [JsonProperty("image_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagKeyValue> ImageTags { get; set; }

        /// <summary>
        /// 表示当前镜像所属的企业项目。取值为0或无该值，表示属于default企业项目。取值为UUID，表示属于该UUID对应的企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 当不封装镜像时,用此字段来区分是否删除用户信息，默认为false。不删除用户信息：false，删除用户信息：true。
        /// </summary>
        [JsonProperty("is_clear_data", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsClearData { get; set; }

        /// <summary>
        /// 表示镜像支持的最大内存，单位为MB。
        /// </summary>
        [JsonProperty("max_ram", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxRam { get; set; }

        /// <summary>
        /// 表示镜像支持的最小内存，单位为MB，默认为0，表示不受限制。
        /// </summary>
        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public string MinRam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopToImageReq {\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  imageDescription: ").Append(ImageDescription).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  executeSysprep: ").Append(ExecuteSysprep).Append("\n");
            sb.Append("  imageTags: ").Append(ImageTags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  isClearData: ").Append(IsClearData).Append("\n");
            sb.Append("  maxRam: ").Append(MaxRam).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopToImageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopToImageReq input)
        {
            if (input == null) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.ImageDescription != input.ImageDescription || (this.ImageDescription != null && !this.ImageDescription.Equals(input.ImageDescription))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.ExecuteSysprep != input.ExecuteSysprep || (this.ExecuteSysprep != null && !this.ExecuteSysprep.Equals(input.ExecuteSysprep))) return false;
            if (this.ImageTags != input.ImageTags || (this.ImageTags != null && input.ImageTags != null && !this.ImageTags.SequenceEqual(input.ImageTags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.IsClearData != input.IsClearData || (this.IsClearData != null && !this.IsClearData.Equals(input.IsClearData))) return false;
            if (this.MaxRam != input.MaxRam || (this.MaxRam != null && !this.MaxRam.Equals(input.MaxRam))) return false;
            if (this.MinRam != input.MinRam || (this.MinRam != null && !this.MinRam.Equals(input.MinRam))) return false;

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
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ImageDescription != null) hashCode = hashCode * 59 + this.ImageDescription.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.ExecuteSysprep != null) hashCode = hashCode * 59 + this.ExecuteSysprep.GetHashCode();
                if (this.ImageTags != null) hashCode = hashCode * 59 + this.ImageTags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsClearData != null) hashCode = hashCode * 59 + this.IsClearData.GetHashCode();
                if (this.MaxRam != null) hashCode = hashCode * 59 + this.MaxRam.GetHashCode();
                if (this.MinRam != null) hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                return hashCode;
            }
        }
    }
}
