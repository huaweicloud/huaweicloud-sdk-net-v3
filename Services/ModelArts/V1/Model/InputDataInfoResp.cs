using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 数据实际输入信息。枚举值：   - dataset：指定输入为数据集；   - obs：指定输入为OBS路径。
    /// </summary>
    public class InputDataInfoResp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dataset", NullValueHandling = NullValueHandling.Ignore)]
        public InputDataInfoRespDataset Dataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs", NullValueHandling = NullValueHandling.Ignore)]
        public InputDataInfoRespObs Obs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputDataInfoResp {\n");
            sb.Append("  dataset: ").Append(Dataset).Append("\n");
            sb.Append("  obs: ").Append(Obs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputDataInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InputDataInfoResp input)
        {
            if (input == null) return false;
            if (this.Dataset != input.Dataset || (this.Dataset != null && !this.Dataset.Equals(input.Dataset))) return false;
            if (this.Obs != input.Obs || (this.Obs != null && !this.Obs.Equals(input.Obs))) return false;

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
                if (this.Dataset != null) hashCode = hashCode * 59 + this.Dataset.GetHashCode();
                if (this.Obs != null) hashCode = hashCode * 59 + this.Obs.GetHashCode();
                return hashCode;
            }
        }
    }
}
