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
    public class AutoIdDocClassificationResult 
    {

        /// <summary>
        /// 证件的类型，支持的证件类型如表1所示：   **表1* 支持的证件类型 | 证件类型               | 类型描述                 | | - -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- - | | peru_id_card           | 秘鲁身份证               | | cambodian_id_card      | 柬文身份证               | | hongkong_id_card       | 香港身份证               | | macao_id_card          | 澳门身份证               | | myanmar_driver_license | 缅文驾驶证               | | myanmar_id_card        | 缅文身份证               | | passport               | 护照                     | | thailand_id_card       | 泰文身份证               | | id_card                | 中华人民共和国居民身份证 | 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 证件的位置。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 证件位置的置信度。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_result", NullValueHandling = NullValueHandling.Ignore)]
        public AutoIdDocClassificationAlarmResult AlarmResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public AutoIdDocClassificationAlarmConfidence AlarmConfidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoIdDocClassificationResult {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  alarmResult: ").Append(AlarmResult).Append("\n");
            sb.Append("  alarmConfidence: ").Append(AlarmConfidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoIdDocClassificationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoIdDocClassificationResult input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Location != input.Location || (this.Location != null && input.Location != null && !this.Location.SequenceEqual(input.Location))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.AlarmResult != input.AlarmResult || (this.AlarmResult != null && !this.AlarmResult.Equals(input.AlarmResult))) return false;
            if (this.AlarmConfidence != input.AlarmConfidence || (this.AlarmConfidence != null && !this.AlarmConfidence.Equals(input.AlarmConfidence))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.AlarmResult != null) hashCode = hashCode * 59 + this.AlarmResult.GetHashCode();
                if (this.AlarmConfidence != null) hashCode = hashCode * 59 + this.AlarmConfidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
