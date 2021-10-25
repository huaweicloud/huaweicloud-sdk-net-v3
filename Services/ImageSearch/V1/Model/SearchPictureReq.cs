using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchPictureReq 
    {

        /// <summary>
        /// 图片文件Base64编码字符串，仅支持JPEG/JPG/PNG/BMP格式，图片最小边不小于100px，最大边不超过2048px。该参数与path二选一，如果两个参数都存在，则以file为主。 
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        /// <summary>
        /// 图片的URL路径，图片库中的图片索引ID。该参数与file二选一，如果两个参数都存在，则以file为主。 
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 返回被检索图像的数量，取值为1~100的整数，默认为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量，指定搜索结果返回起始位置，取值为大于或等于0的整数，默认为0。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 图片自定义标签，最多不超过10个，格式为key：value对。 标签名（key）添加方式：   - 登录管理控制台，单击“创建实例”，自定义标签名。   - 登录管理控制台，在“实例管理”页签，单击实例名称，进入“基础信息”页添加自定义标签。 使用图片标签搜索时该参数必选。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Object Tags { get; set; }

        /// <summary>
        /// 是否用图片中指定区域（参数box）进行搜索。默认为false，该参数目前仅对某些特定模型有效，其他模型暂不支持目标检测。 - true：用图片中指定区域（参数box）进行搜索。 - false：用全图进行搜索。
        /// </summary>
        [JsonProperty("is_crop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCrop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public SearchBoxDetail Box { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchPictureReq {\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  isCrop: ").Append(IsCrop).Append("\n");
            sb.Append("  box: ").Append(Box).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchPictureReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchPictureReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.IsCrop == input.IsCrop ||
                    (this.IsCrop != null &&
                    this.IsCrop.Equals(input.IsCrop))
                ) && 
                (
                    this.Box == input.Box ||
                    (this.Box != null &&
                    this.Box.Equals(input.Box))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.IsCrop != null)
                    hashCode = hashCode * 59 + this.IsCrop.GetHashCode();
                if (this.Box != null)
                    hashCode = hashCode * 59 + this.Box.GetHashCode();
                return hashCode;
            }
        }
    }
}
