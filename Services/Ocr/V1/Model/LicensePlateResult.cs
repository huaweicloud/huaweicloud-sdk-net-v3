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
    public class LicensePlateResult 
    {

        /// <summary>
        /// 车牌内容。 
        /// </summary>
        [JsonProperty("plate_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PlateNumber { get; set; }

        /// <summary>
        /// 当前版本支持的车牌底色类型：  - blue: 蓝色  - green: 绿色（小型新能源车牌）  - black: 黑色  - white: 白色  - yellow: 黄色  - yellow_green: 黄绿（大型新能源车牌） 
        /// </summary>
        [JsonProperty("plate_color", NullValueHandling = NullValueHandling.Ignore)]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌的区域位置信息，列表形式，包含文字区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("plate_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PlateLocation { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicensePlateResult {\n");
            sb.Append("  plateNumber: ").Append(PlateNumber).Append("\n");
            sb.Append("  plateColor: ").Append(PlateColor).Append("\n");
            sb.Append("  plateLocation: ").Append(PlateLocation).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LicensePlateResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LicensePlateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlateNumber == input.PlateNumber ||
                    (this.PlateNumber != null &&
                    this.PlateNumber.Equals(input.PlateNumber))
                ) && 
                (
                    this.PlateColor == input.PlateColor ||
                    (this.PlateColor != null &&
                    this.PlateColor.Equals(input.PlateColor))
                ) && 
                (
                    this.PlateLocation == input.PlateLocation ||
                    this.PlateLocation != null &&
                    input.PlateLocation != null &&
                    this.PlateLocation.SequenceEqual(input.PlateLocation)
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
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
                if (this.PlateNumber != null)
                    hashCode = hashCode * 59 + this.PlateNumber.GetHashCode();
                if (this.PlateColor != null)
                    hashCode = hashCode * 59 + this.PlateColor.GetHashCode();
                if (this.PlateLocation != null)
                    hashCode = hashCode * 59 + this.PlateLocation.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
