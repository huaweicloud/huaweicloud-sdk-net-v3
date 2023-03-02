using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// This is a auto crerate Body Object
    /// </summary>
    public class ImageWisedesignCombineBody 
    {

        /// <summary>
        /// 图层标识，范围5个图层以内, 0 代表背景层
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 图层左上角的横坐标位置，单位为px，默认为0
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public int? X { get; set; }

        /// <summary>
        /// 图层左上角的纵坐标位置，单位为px，默认为0
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public int? Y { get; set; }

        /// <summary>
        /// 图层宽度，单位为px，默认为上传图片的宽度
        /// </summary>
        [JsonProperty("w", NullValueHandling = NullValueHandling.Ignore)]
        public int? W { get; set; }

        /// <summary>
        /// 图层高度，单位为px，默认为上传图片的高度
        /// </summary>
        [JsonProperty("h", NullValueHandling = NullValueHandling.Ignore)]
        public int? H { get; set; }

        /// <summary>
        /// 是否水平翻转，默认值为false
        /// </summary>
        [JsonProperty("flipx", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Flipx { get; set; }

        /// <summary>
        /// 是否垂直翻转，默认值为false
        /// </summary>
        [JsonProperty("flipy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Flipy { get; set; }

        /// <summary>
        /// 图层旋转角度，范围[-180, +180]，默认为0
        /// </summary>
        [JsonProperty("rotate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rotate { get; set; }

        /// <summary>
        /// 图层透明度，范围[0, 1]，默认为1
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public float? Opacity { get; set; }

        /// <summary>
        /// 非背景图的图像数据，base64编码，要求base64编码最长边最大3000px，支持JPG/PNG/BMP/JPEG格式
        /// </summary>
        [JsonProperty("image_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// 与image_base64二选一  图片的URL路径，目前支持：  - 公网HTTP/HTTPS URL  - 华为云OBS提供的URL，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。详请参见[[配置OBS服务的访问权限](https://support.huaweicloud.com/api-moderation/moderation_03_0020.html)](tag:hc)[[配置OBS服务的访问权限](https://support.huaweicloud.com/intl/zh-cn/api-moderation/moderation_03_0020.html)](tag:hk)。  &gt; - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 &gt; - 请保证被检测图片所在的存储服务稳定可靠，建议您使用华为云OBS存储。 &gt; - lmage不支持跨区域OBS，OBS的区域需要和服务保持一致。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("backgroundattrs", NullValueHandling = NullValueHandling.Ignore)]
        public ImageWisedesignCombineBodyBackgroundattrs Backgroundattrs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageWisedesignCombineBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  x: ").Append(X).Append("\n");
            sb.Append("  y: ").Append(Y).Append("\n");
            sb.Append("  w: ").Append(W).Append("\n");
            sb.Append("  h: ").Append(H).Append("\n");
            sb.Append("  flipx: ").Append(Flipx).Append("\n");
            sb.Append("  flipy: ").Append(Flipy).Append("\n");
            sb.Append("  rotate: ").Append(Rotate).Append("\n");
            sb.Append("  opacity: ").Append(Opacity).Append("\n");
            sb.Append("  imageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  backgroundattrs: ").Append(Backgroundattrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageWisedesignCombineBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageWisedesignCombineBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.W == input.W ||
                    (this.W != null &&
                    this.W.Equals(input.W))
                ) && 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
                ) && 
                (
                    this.Flipx == input.Flipx ||
                    (this.Flipx != null &&
                    this.Flipx.Equals(input.Flipx))
                ) && 
                (
                    this.Flipy == input.Flipy ||
                    (this.Flipy != null &&
                    this.Flipy.Equals(input.Flipy))
                ) && 
                (
                    this.Rotate == input.Rotate ||
                    (this.Rotate != null &&
                    this.Rotate.Equals(input.Rotate))
                ) && 
                (
                    this.Opacity == input.Opacity ||
                    (this.Opacity != null &&
                    this.Opacity.Equals(input.Opacity))
                ) && 
                (
                    this.ImageBase64 == input.ImageBase64 ||
                    (this.ImageBase64 != null &&
                    this.ImageBase64.Equals(input.ImageBase64))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Backgroundattrs == input.Backgroundattrs ||
                    (this.Backgroundattrs != null &&
                    this.Backgroundattrs.Equals(input.Backgroundattrs))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.W != null)
                    hashCode = hashCode * 59 + this.W.GetHashCode();
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.Flipx != null)
                    hashCode = hashCode * 59 + this.Flipx.GetHashCode();
                if (this.Flipy != null)
                    hashCode = hashCode * 59 + this.Flipy.GetHashCode();
                if (this.Rotate != null)
                    hashCode = hashCode * 59 + this.Rotate.GetHashCode();
                if (this.Opacity != null)
                    hashCode = hashCode * 59 + this.Opacity.GetHashCode();
                if (this.ImageBase64 != null)
                    hashCode = hashCode * 59 + this.ImageBase64.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Backgroundattrs != null)
                    hashCode = hashCode * 59 + this.Backgroundattrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
