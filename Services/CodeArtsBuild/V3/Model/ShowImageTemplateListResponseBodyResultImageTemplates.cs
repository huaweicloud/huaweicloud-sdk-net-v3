using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 镜像模版信息
    /// </summary>
    public class ShowImageTemplateListResponseBodyResultImageTemplates 
    {

        /// <summary>
        /// 镜像模版ID
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// swr镜像组织
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// 镜像名
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像label
        /// </summary>
        [JsonProperty("image_label", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageLabel { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonProperty("base_image", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseImage { get; set; }

        /// <summary>
        /// 镜像标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 镜像描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 镜像创建日期
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowImageTemplateListResponseBodyResultImageTemplates {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  organization: ").Append(Organization).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  imageLabel: ").Append(ImageLabel).Append("\n");
            sb.Append("  baseImage: ").Append(BaseImage).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowImageTemplateListResponseBodyResultImageTemplates);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowImageTemplateListResponseBodyResultImageTemplates input)
        {
            if (input == null) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.Organization != input.Organization || (this.Organization != null && !this.Organization.Equals(input.Organization))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.ImageLabel != input.ImageLabel || (this.ImageLabel != null && !this.ImageLabel.Equals(input.ImageLabel))) return false;
            if (this.BaseImage != input.BaseImage || (this.BaseImage != null && !this.BaseImage.Equals(input.BaseImage))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Organization != null) hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ImageLabel != null) hashCode = hashCode * 59 + this.ImageLabel.GetHashCode();
                if (this.BaseImage != null) hashCode = hashCode * 59 + this.BaseImage.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
