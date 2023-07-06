using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据加工详情
    /// </summary>
    public class DataTransformationInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transformation_info", NullValueHandling = NullValueHandling.Ignore)]
        public TransformationInfo TransformationInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config_transformation", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigTransformationVo ConfigTransformation { get; set; }

        /// <summary>
        /// 数据加工对象。
        /// </summary>
        [JsonProperty("data_transformation_object_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataTransformationObjectVO> DataTransformationObjectInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataTransformationInfo {\n");
            sb.Append("  transformationInfo: ").Append(TransformationInfo).Append("\n");
            sb.Append("  configTransformation: ").Append(ConfigTransformation).Append("\n");
            sb.Append("  dataTransformationObjectInfos: ").Append(DataTransformationObjectInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataTransformationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataTransformationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransformationInfo == input.TransformationInfo ||
                    (this.TransformationInfo != null &&
                    this.TransformationInfo.Equals(input.TransformationInfo))
                ) && 
                (
                    this.ConfigTransformation == input.ConfigTransformation ||
                    (this.ConfigTransformation != null &&
                    this.ConfigTransformation.Equals(input.ConfigTransformation))
                ) && 
                (
                    this.DataTransformationObjectInfos == input.DataTransformationObjectInfos ||
                    this.DataTransformationObjectInfos != null &&
                    input.DataTransformationObjectInfos != null &&
                    this.DataTransformationObjectInfos.SequenceEqual(input.DataTransformationObjectInfos)
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
                if (this.TransformationInfo != null)
                    hashCode = hashCode * 59 + this.TransformationInfo.GetHashCode();
                if (this.ConfigTransformation != null)
                    hashCode = hashCode * 59 + this.ConfigTransformation.GetHashCode();
                if (this.DataTransformationObjectInfos != null)
                    hashCode = hashCode * 59 + this.DataTransformationObjectInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
