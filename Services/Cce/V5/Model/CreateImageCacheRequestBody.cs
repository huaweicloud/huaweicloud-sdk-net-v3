using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V5.Model
{
    /// <summary>
    /// 创建镜像缓存-respuest结构体。
    /// </summary>
    public class CreateImageCacheRequestBody 
    {

        /// <summary>
        /// **参数解释：** 镜像缓存名称。 **约束限制：** 不涉及 **取值范围：** 以小写字母开头，由小写字母、数字、中划线(-)组成，长度范围1-128位，且不能以中划线(-)结尾。镜像缓存名称不可重复。 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像缓存中的容器镜像列表。
        /// </summary>
        [JsonProperty("images", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Images { get; set; }

        /// <summary>
        /// **参数解释：** 镜像缓存后端对应的存储盘大小，单位GiB。缓存对象为解压后的镜像文件，建议镜像缓存大小不低于该缓存中所有容器镜像大小总和的3倍。 **约束限制：** 不涉及 **取值范围：** [20-400] **默认取值：** 20 
        /// </summary>
        [JsonProperty("image_cache_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageCacheSize { get; set; }

        /// <summary>
        /// **参数解释：** 镜像缓存有效的天数,不设置或值为0表示永久有效。镜像缓存到达有效期后自动过期并删除。 **约束限制：** 不涉及 **取值范围：** [0-10000] **默认取值：** 0 
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("building_config", NullValueHandling = NullValueHandling.Ignore)]
        public ImageCacheBuildingConfig BuildingConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateImageCacheRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  images: ").Append(Images).Append("\n");
            sb.Append("  imageCacheSize: ").Append(ImageCacheSize).Append("\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  buildingConfig: ").Append(BuildingConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateImageCacheRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateImageCacheRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Images != input.Images || (this.Images != null && input.Images != null && !this.Images.SequenceEqual(input.Images))) return false;
            if (this.ImageCacheSize != input.ImageCacheSize || (this.ImageCacheSize != null && !this.ImageCacheSize.Equals(input.ImageCacheSize))) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.BuildingConfig != input.BuildingConfig || (this.BuildingConfig != null && !this.BuildingConfig.Equals(input.BuildingConfig))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Images != null) hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.ImageCacheSize != null) hashCode = hashCode * 59 + this.ImageCacheSize.GetHashCode();
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.BuildingConfig != null) hashCode = hashCode * 59 + this.BuildingConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
