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
    /// 模板中构建执行步骤列表
    /// </summary>
    public class QueryTemplateVo 
    {

        /// <summary>
        /// 构建执行的步骤。
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateBuildJobSteps> Steps { get; set; }

        /// <summary>
        /// 构建步骤中的action。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public Object Actions { get; set; }

        /// <summary>
        /// 是否自动更新子模块。
        /// </summary>
        [JsonProperty("auto_update_sub_module", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoUpdateSubModule { get; set; }

        /// <summary>
        /// 配置镜像地址。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 配置镜像源的地址。
        /// </summary>
        [JsonProperty("image_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTemplateVo {\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  autoUpdateSubModule: ").Append(AutoUpdateSubModule).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  imageSource: ").Append(ImageSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTemplateVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTemplateVo input)
        {
            if (input == null) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && !this.Actions.Equals(input.Actions))) return false;
            if (this.AutoUpdateSubModule != input.AutoUpdateSubModule || (this.AutoUpdateSubModule != null && !this.AutoUpdateSubModule.Equals(input.AutoUpdateSubModule))) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.ImageSource != input.ImageSource || (this.ImageSource != null && !this.ImageSource.Equals(input.ImageSource))) return false;

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
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.AutoUpdateSubModule != null) hashCode = hashCode * 59 + this.AutoUpdateSubModule.GetHashCode();
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.ImageSource != null) hashCode = hashCode * 59 + this.ImageSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
