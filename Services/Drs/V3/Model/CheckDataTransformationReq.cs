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
    /// 校验数据加工规则请求体
    /// </summary>
    public class CheckDataTransformationReq 
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 对象信息，生成加工规则时需要填写。
        /// </summary>
        [JsonProperty("object_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatabaseObjectVO> ObjectInfo { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDataTransformationReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  objectInfo: ").Append(ObjectInfo).Append("\n");
            sb.Append("  transformationInfo: ").Append(TransformationInfo).Append("\n");
            sb.Append("  configTransformation: ").Append(ConfigTransformation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckDataTransformationReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckDataTransformationReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ObjectInfo == input.ObjectInfo ||
                    this.ObjectInfo != null &&
                    input.ObjectInfo != null &&
                    this.ObjectInfo.SequenceEqual(input.ObjectInfo)
                ) && 
                (
                    this.TransformationInfo == input.TransformationInfo ||
                    (this.TransformationInfo != null &&
                    this.TransformationInfo.Equals(input.TransformationInfo))
                ) && 
                (
                    this.ConfigTransformation == input.ConfigTransformation ||
                    (this.ConfigTransformation != null &&
                    this.ConfigTransformation.Equals(input.ConfigTransformation))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ObjectInfo != null)
                    hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                if (this.TransformationInfo != null)
                    hashCode = hashCode * 59 + this.TransformationInfo.GetHashCode();
                if (this.ConfigTransformation != null)
                    hashCode = hashCode * 59 + this.ConfigTransformation.GetHashCode();
                return hashCode;
            }
        }
    }
}
