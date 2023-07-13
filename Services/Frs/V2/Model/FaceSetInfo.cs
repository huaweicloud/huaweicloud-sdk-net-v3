using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FaceSetInfo 
    {

        /// <summary>
        /// 人脸库当中的人脸数量。
        /// </summary>
        [JsonProperty("face_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? FaceNumber { get; set; }

        /// <summary>
        /// 用户的自定义字段。
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExternalFields { get; set; }

        /// <summary>
        /// 人脸库ID，随机生成的包含八个字符的字符串。
        /// </summary>
        [JsonProperty("face_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetId { get; set; }

        /// <summary>
        /// 人脸库名称。
        /// </summary>
        [JsonProperty("face_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetName { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateDate { get; set; }

        /// <summary>
        /// 人脸库最大的容量。
        /// </summary>
        [JsonProperty("face_set_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? FaceSetCapacity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceSetInfo {\n");
            sb.Append("  faceNumber: ").Append(FaceNumber).Append("\n");
            sb.Append("  externalFields: ").Append(ExternalFields).Append("\n");
            sb.Append("  faceSetId: ").Append(FaceSetId).Append("\n");
            sb.Append("  faceSetName: ").Append(FaceSetName).Append("\n");
            sb.Append("  createDate: ").Append(CreateDate).Append("\n");
            sb.Append("  faceSetCapacity: ").Append(FaceSetCapacity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceSetInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FaceSetInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceNumber == input.FaceNumber ||
                    (this.FaceNumber != null &&
                    this.FaceNumber.Equals(input.FaceNumber))
                ) && 
                (
                    this.ExternalFields == input.ExternalFields ||
                    (this.ExternalFields != null &&
                    this.ExternalFields.Equals(input.ExternalFields))
                ) && 
                (
                    this.FaceSetId == input.FaceSetId ||
                    (this.FaceSetId != null &&
                    this.FaceSetId.Equals(input.FaceSetId))
                ) && 
                (
                    this.FaceSetName == input.FaceSetName ||
                    (this.FaceSetName != null &&
                    this.FaceSetName.Equals(input.FaceSetName))
                ) && 
                (
                    this.CreateDate == input.CreateDate ||
                    (this.CreateDate != null &&
                    this.CreateDate.Equals(input.CreateDate))
                ) && 
                (
                    this.FaceSetCapacity == input.FaceSetCapacity ||
                    (this.FaceSetCapacity != null &&
                    this.FaceSetCapacity.Equals(input.FaceSetCapacity))
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
                if (this.FaceNumber != null)
                    hashCode = hashCode * 59 + this.FaceNumber.GetHashCode();
                if (this.ExternalFields != null)
                    hashCode = hashCode * 59 + this.ExternalFields.GetHashCode();
                if (this.FaceSetId != null)
                    hashCode = hashCode * 59 + this.FaceSetId.GetHashCode();
                if (this.FaceSetName != null)
                    hashCode = hashCode * 59 + this.FaceSetName.GetHashCode();
                if (this.CreateDate != null)
                    hashCode = hashCode * 59 + this.CreateDate.GetHashCode();
                if (this.FaceSetCapacity != null)
                    hashCode = hashCode * 59 + this.FaceSetCapacity.GetHashCode();
                return hashCode;
            }
        }
    }
}
