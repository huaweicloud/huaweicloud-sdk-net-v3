using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 维护时间窗结构体
    /// </summary>
    public class MaintainWindows 
    {

        /// <summary>
        /// 序号。
        /// </summary>
        [JsonProperty("seq", NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; }

        /// <summary>
        /// 是否为默认时间段。
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// 维护时间窗开始时间
        /// </summary>
        [JsonProperty("begin", NullValueHandling = NullValueHandling.Ignore)]
        public string Begin { get; set; }

        /// <summary>
        /// 维护时间窗结束时间。
        /// </summary>
        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public string End { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaintainWindows {\n");
            sb.Append("  seq: ").Append(Seq).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  begin: ").Append(Begin).Append("\n");
            sb.Append("  end: ").Append(End).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MaintainWindows);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MaintainWindows input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Seq == input.Seq ||
                    (this.Seq != null &&
                    this.Seq.Equals(input.Seq))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Begin == input.Begin ||
                    (this.Begin != null &&
                    this.Begin.Equals(input.Begin))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
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
                if (this.Seq != null)
                    hashCode = hashCode * 59 + this.Seq.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Begin != null)
                    hashCode = hashCode * 59 + this.Begin.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
                return hashCode;
            }
        }
    }
}
