using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 风格额外信息
    /// </summary>
    public class StyleExtraMeta 
    {

        /// <summary>
        /// 是否支持照片建模
        /// </summary>
        [JsonProperty("picture_modeling_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PictureModelingEnable { get; set; }

        /// <summary>
        /// 是否支持模型编辑
        /// </summary>
        [JsonProperty("edit_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EditEnable { get; set; }

        /// <summary>
        /// 编辑使用引擎
        /// </summary>
        [JsonProperty("edit_engine", NullValueHandling = NullValueHandling.Ignore)]
        public string EditEngine { get; set; }

        /// <summary>
        /// 照片建模算法调用的模型类型
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StyleExtraMeta {\n");
            sb.Append("  pictureModelingEnable: ").Append(PictureModelingEnable).Append("\n");
            sb.Append("  editEnable: ").Append(EditEnable).Append("\n");
            sb.Append("  editEngine: ").Append(EditEngine).Append("\n");
            sb.Append("  modelId: ").Append(ModelId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StyleExtraMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StyleExtraMeta input)
        {
            if (input == null) return false;
            if (this.PictureModelingEnable != input.PictureModelingEnable || (this.PictureModelingEnable != null && !this.PictureModelingEnable.Equals(input.PictureModelingEnable))) return false;
            if (this.EditEnable != input.EditEnable || (this.EditEnable != null && !this.EditEnable.Equals(input.EditEnable))) return false;
            if (this.EditEngine != input.EditEngine || (this.EditEngine != null && !this.EditEngine.Equals(input.EditEngine))) return false;
            if (this.ModelId != input.ModelId || (this.ModelId != null && !this.ModelId.Equals(input.ModelId))) return false;

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
                if (this.PictureModelingEnable != null) hashCode = hashCode * 59 + this.PictureModelingEnable.GetHashCode();
                if (this.EditEnable != null) hashCode = hashCode * 59 + this.EditEnable.GetHashCode();
                if (this.EditEngine != null) hashCode = hashCode * 59 + this.EditEngine.GetHashCode();
                if (this.ModelId != null) hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                return hashCode;
            }
        }
    }
}
