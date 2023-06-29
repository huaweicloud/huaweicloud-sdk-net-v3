using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MixInfo 
    {

        /// <summary>
        /// 合成任务原始视频配置
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public List<InputSetting> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("layout", NullValueHandling = NullValueHandling.Ignore)]
        public MixInfoLayout Layout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixInfo {\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  layout: ").Append(Layout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MixInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MixInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Layout == input.Layout ||
                    (this.Layout != null &&
                    this.Layout.Equals(input.Layout))
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
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Layout != null)
                    hashCode = hashCode * 59 + this.Layout.GetHashCode();
                return hashCode;
            }
        }
    }
}
