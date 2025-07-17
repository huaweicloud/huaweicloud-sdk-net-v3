using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLayoutResponse : SdkResponse
    {

        /// <summary>
        /// 结果码。 * 0：成功 * 非0：失败 
        /// </summary>
        [JsonProperty("returnCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReturnCode { get; set; }

        /// <summary>
        /// 结果描述。 * Success：成功 * 其他：失败原因 
        /// </summary>
        [JsonProperty("returnDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnDesc { get; set; }

        /// <summary>
        /// 多画面布局。
        /// </summary>
        [JsonProperty("picLayouts", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestPicLayout> PicLayouts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLayoutResponse {\n");
            sb.Append("  returnCode: ").Append(ReturnCode).Append("\n");
            sb.Append("  returnDesc: ").Append(ReturnDesc).Append("\n");
            sb.Append("  picLayouts: ").Append(PicLayouts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLayoutResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLayoutResponse input)
        {
            if (input == null) return false;
            if (this.ReturnCode != input.ReturnCode || (this.ReturnCode != null && !this.ReturnCode.Equals(input.ReturnCode))) return false;
            if (this.ReturnDesc != input.ReturnDesc || (this.ReturnDesc != null && !this.ReturnDesc.Equals(input.ReturnDesc))) return false;
            if (this.PicLayouts != input.PicLayouts || (this.PicLayouts != null && input.PicLayouts != null && !this.PicLayouts.SequenceEqual(input.PicLayouts))) return false;

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
                if (this.ReturnCode != null) hashCode = hashCode * 59 + this.ReturnCode.GetHashCode();
                if (this.ReturnDesc != null) hashCode = hashCode * 59 + this.ReturnDesc.GetHashCode();
                if (this.PicLayouts != null) hashCode = hashCode * 59 + this.PicLayouts.GetHashCode();
                return hashCode;
            }
        }
    }
}
