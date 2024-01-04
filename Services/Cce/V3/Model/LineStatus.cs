using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LineStatus 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("startPoint", NullValueHandling = NullValueHandling.Ignore)]
        public TaskType StartPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endPoint", NullValueHandling = NullValueHandling.Ignore)]
        public TaskType EndPoint { get; set; }
        /// <summary>
        /// 表示是否为关键线路（关键线路未执行无法取消升级流程）
        /// </summary>
        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public string Critical { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineStatus {\n");
            sb.Append("  startPoint: ").Append(StartPoint).Append("\n");
            sb.Append("  endPoint: ").Append(EndPoint).Append("\n");
            sb.Append("  critical: ").Append(Critical).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LineStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LineStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartPoint == input.StartPoint ||
                    (this.StartPoint != null &&
                    this.StartPoint.Equals(input.StartPoint))
                ) && 
                (
                    this.EndPoint == input.EndPoint ||
                    (this.EndPoint != null &&
                    this.EndPoint.Equals(input.EndPoint))
                ) && 
                (
                    this.Critical == input.Critical ||
                    (this.Critical != null &&
                    this.Critical.Equals(input.Critical))
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
                if (this.StartPoint != null)
                    hashCode = hashCode * 59 + this.StartPoint.GetHashCode();
                if (this.EndPoint != null)
                    hashCode = hashCode * 59 + this.EndPoint.GetHashCode();
                if (this.Critical != null)
                    hashCode = hashCode * 59 + this.Critical.GetHashCode();
                return hashCode;
            }
        }
    }
}
