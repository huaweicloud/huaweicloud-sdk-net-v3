using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ThailandLicensePlateItem 
    {

        /// <summary>
        /// 车牌内容。 
        /// </summary>
        [JsonProperty("plate_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PlateNumber { get; set; }

        /// <summary>
        /// 车牌的区域位置信息，列表形式，包含文字区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("plate_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PlateLocation { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。注：置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 车牌所属府 
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThailandLicensePlateItem {\n");
            sb.Append("  plateNumber: ").Append(PlateNumber).Append("\n");
            sb.Append("  plateLocation: ").Append(PlateLocation).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  province: ").Append(Province).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThailandLicensePlateItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThailandLicensePlateItem input)
        {
            if (input == null) return false;
            if (this.PlateNumber != input.PlateNumber || (this.PlateNumber != null && !this.PlateNumber.Equals(input.PlateNumber))) return false;
            if (this.PlateLocation != input.PlateLocation || (this.PlateLocation != null && input.PlateLocation != null && !this.PlateLocation.SequenceEqual(input.PlateLocation))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.Province != input.Province || (this.Province != null && !this.Province.Equals(input.Province))) return false;

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
                if (this.PlateNumber != null) hashCode = hashCode * 59 + this.PlateNumber.GetHashCode();
                if (this.PlateLocation != null) hashCode = hashCode * 59 + this.PlateLocation.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Province != null) hashCode = hashCode * 59 + this.Province.GetHashCode();
                return hashCode;
            }
        }
    }
}
