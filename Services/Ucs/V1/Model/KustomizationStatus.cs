using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KustomizationStatus 
    {

        /// <summary>
        /// 最近一次成功协调的资源版本号，用于标识控制器已处理的对象代
        /// </summary>
        [JsonProperty("observedGeneration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ObservedGeneration { get; set; }

        /// <summary>
        /// 当前对象的状态条件列表
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Conditions { get; set; }

        /// <summary>
        /// 最近一次成功应用的版本号
        /// </summary>
        [JsonProperty("lastAttemptedRevision", NullValueHandling = NullValueHandling.Ignore)]
        public string LastAttemptedRevision { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KustomizationStatus {\n");
            sb.Append("  observedGeneration: ").Append(ObservedGeneration).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  lastAttemptedRevision: ").Append(LastAttemptedRevision).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KustomizationStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KustomizationStatus input)
        {
            if (input == null) return false;
            if (this.ObservedGeneration != input.ObservedGeneration || (this.ObservedGeneration != null && !this.ObservedGeneration.Equals(input.ObservedGeneration))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;
            if (this.LastAttemptedRevision != input.LastAttemptedRevision || (this.LastAttemptedRevision != null && !this.LastAttemptedRevision.Equals(input.LastAttemptedRevision))) return false;

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
                if (this.ObservedGeneration != null) hashCode = hashCode * 59 + this.ObservedGeneration.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.LastAttemptedRevision != null) hashCode = hashCode * 59 + this.LastAttemptedRevision.GetHashCode();
                return hashCode;
            }
        }
    }
}
