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
    public class Attributes 
    {

        /// <summary>
        /// 性别： • male：男性 • female：女性
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dress", NullValueHandling = NullValueHandling.Ignore)]
        public Dress Dress { get; set; }

        /// <summary>
        /// 是否带眼镜： • yes：带眼镜 • dark：带墨镜 • none：未戴眼镜 • unknown：未知
        /// </summary>
        [JsonProperty("glass", NullValueHandling = NullValueHandling.Ignore)]
        public string Glass { get; set; }

        /// <summary>
        /// 是否戴帽子： • yes：戴帽子 • none：未戴帽子 • unknown：未知
        /// </summary>
        [JsonProperty("hat", NullValueHandling = NullValueHandling.Ignore)]
        public string Hat { get; set; }

        /// <summary>
        /// 年龄。
        /// </summary>
        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }

        /// <summary>
        /// 是否戴口罩： • yes：戴口罩 • none：未戴口罩 • unknown：未知
        /// </summary>
        [JsonProperty("mask", NullValueHandling = NullValueHandling.Ignore)]
        public string Mask { get; set; }

        /// <summary>
        /// 胡须： • yes：有胡须 • none：无胡须 • unknown：未知
        /// </summary>
        [JsonProperty("beard", NullValueHandling = NullValueHandling.Ignore)]
        public string Beard { get; set; }

        /// <summary>
        /// 图片类型： • idcard：证件照 • monitor：摄像头监控 • internet photo：网络图片
        /// </summary>
        [JsonProperty("phototype", NullValueHandling = NullValueHandling.Ignore)]
        public string Phototype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public FaceQuality Quality { get; set; }

        /// <summary>
        /// 发型： • long：长发 • short：短发 • unknown：未知
        /// </summary>
        [JsonProperty("hair", NullValueHandling = NullValueHandling.Ignore)]
        public string Hair { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("expression", NullValueHandling = NullValueHandling.Ignore)]
        public AttributesExpression Expression { get; set; }

        /// <summary>
        /// 人脸图片旋转角（顺时针偏转角度），支持0°、90°、180°和270°图片旋转。
        /// </summary>
        [JsonProperty("face_angle", NullValueHandling = NullValueHandling.Ignore)]
        public int? FaceAngle { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attributes {\n");
            sb.Append("  gender: ").Append(Gender).Append("\n");
            sb.Append("  dress: ").Append(Dress).Append("\n");
            sb.Append("  glass: ").Append(Glass).Append("\n");
            sb.Append("  hat: ").Append(Hat).Append("\n");
            sb.Append("  age: ").Append(Age).Append("\n");
            sb.Append("  mask: ").Append(Mask).Append("\n");
            sb.Append("  beard: ").Append(Beard).Append("\n");
            sb.Append("  phototype: ").Append(Phototype).Append("\n");
            sb.Append("  quality: ").Append(Quality).Append("\n");
            sb.Append("  hair: ").Append(Hair).Append("\n");
            sb.Append("  expression: ").Append(Expression).Append("\n");
            sb.Append("  faceAngle: ").Append(FaceAngle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Attributes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Attributes input)
        {
            if (input == null) return false;
            if (this.Gender != input.Gender || (this.Gender != null && !this.Gender.Equals(input.Gender))) return false;
            if (this.Dress != input.Dress || (this.Dress != null && !this.Dress.Equals(input.Dress))) return false;
            if (this.Glass != input.Glass || (this.Glass != null && !this.Glass.Equals(input.Glass))) return false;
            if (this.Hat != input.Hat || (this.Hat != null && !this.Hat.Equals(input.Hat))) return false;
            if (this.Age != input.Age || (this.Age != null && !this.Age.Equals(input.Age))) return false;
            if (this.Mask != input.Mask || (this.Mask != null && !this.Mask.Equals(input.Mask))) return false;
            if (this.Beard != input.Beard || (this.Beard != null && !this.Beard.Equals(input.Beard))) return false;
            if (this.Phototype != input.Phototype || (this.Phototype != null && !this.Phototype.Equals(input.Phototype))) return false;
            if (this.Quality != input.Quality || (this.Quality != null && !this.Quality.Equals(input.Quality))) return false;
            if (this.Hair != input.Hair || (this.Hair != null && !this.Hair.Equals(input.Hair))) return false;
            if (this.Expression != input.Expression || (this.Expression != null && !this.Expression.Equals(input.Expression))) return false;
            if (this.FaceAngle != input.FaceAngle || (this.FaceAngle != null && !this.FaceAngle.Equals(input.FaceAngle))) return false;

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
                if (this.Gender != null) hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.Dress != null) hashCode = hashCode * 59 + this.Dress.GetHashCode();
                if (this.Glass != null) hashCode = hashCode * 59 + this.Glass.GetHashCode();
                if (this.Hat != null) hashCode = hashCode * 59 + this.Hat.GetHashCode();
                if (this.Age != null) hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.Mask != null) hashCode = hashCode * 59 + this.Mask.GetHashCode();
                if (this.Beard != null) hashCode = hashCode * 59 + this.Beard.GetHashCode();
                if (this.Phototype != null) hashCode = hashCode * 59 + this.Phototype.GetHashCode();
                if (this.Quality != null) hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Hair != null) hashCode = hashCode * 59 + this.Hair.GetHashCode();
                if (this.Expression != null) hashCode = hashCode * 59 + this.Expression.GetHashCode();
                if (this.FaceAngle != null) hashCode = hashCode * 59 + this.FaceAngle.GetHashCode();
                return hashCode;
            }
        }
    }
}
