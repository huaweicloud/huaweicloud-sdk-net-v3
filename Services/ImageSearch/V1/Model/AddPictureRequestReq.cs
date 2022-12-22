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
    /// 添加图片body体
    /// </summary>
    public class AddPictureRequestReq 
    {

        /// <summary>
        /// 图片文件Base64编码字符串，仅支持JPEG/JPG/PNG/BMP格式，图片最小边不小于100px，最大边不超过2048px。
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        /// <summary>
        /// 图片的URL路径，作为图片库中索引图片的ID，是必选参数。  &gt; - 当file字段不为空时，图片从file获取，path作为图片索引ID使用；当file字段不存在或者为空时，图片需要通过下载获取，此时path作为下载图片的地址（当前仅支持从华为云图像搜索服务所在区域的OBS下载图片），同时，path也作为图片索引ID。 
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 图片自定义标签。格式为key：value对，所有图片的key总数最多不超过10个，但是每个key对应的value不限制个数，例如：key为动物，对应的value可以是猫、狗、鸟等多个。  标签名（key）添加方式：   - 登录管理控制台，单击“创建实例”，自定义标签名。    - 登录管理控制台，在“实例管理”页签，单击实例名称，进入“基础信息”页添加自定义标签。 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Object Tags { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddPictureRequestReq {\n");
            sb.Append("  file: ").Append(File).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddPictureRequestReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddPictureRequestReq input)
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
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
