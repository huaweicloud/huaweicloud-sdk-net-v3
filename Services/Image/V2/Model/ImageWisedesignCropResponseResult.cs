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
    /// 智能设计商品图像裁剪结果信息
    /// </summary>
    public class ImageWisedesignCropResponseResult 
    {

        /// <summary>
        /// 裁剪结果框，有四个整型数值，分别代表左上角横坐标、左上角纵坐标、右下角横坐标、右下角纵坐标，示例：[x_min, y_min, x_max, y_max]
        /// </summary>
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Box { get; set; }

        /// <summary>
        /// 裁剪后图像的64位编码
        /// </summary>
        [JsonProperty("image_base64", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// 请求的任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageWisedesignCropResponseResult {\n");
            sb.Append("  box: ").Append(Box).Append("\n");
            sb.Append("  imageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageWisedesignCropResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageWisedesignCropResponseResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Box == input.Box ||
                    this.Box != null &&
                    input.Box != null &&
                    this.Box.SequenceEqual(input.Box)
                ) && 
                (
                    this.ImageBase64 == input.ImageBase64 ||
                    (this.ImageBase64 != null &&
                    this.ImageBase64.Equals(input.ImageBase64))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.Box != null)
                    hashCode = hashCode * 59 + this.Box.GetHashCode();
                if (this.ImageBase64 != null)
                    hashCode = hashCode * 59 + this.ImageBase64.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
