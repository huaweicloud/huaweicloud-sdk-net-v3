using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MotionItem 
    {

        /// <summary>
        /// 时间戳，相对时间戳。  单位秒。  保留3位小数。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public float? Timestamp { get; set; }

        /// <summary>
        /// root 3维坐标。
        /// </summary>
        [JsonProperty("root", NullValueHandling = NullValueHandling.Ignore)]
        public List<float?> Root { get; set; }

        /// <summary>
        /// 75个关节点，四元数。
        /// </summary>
        [JsonProperty("joints", NullValueHandling = NullValueHandling.Ignore)]
        public List<float?> Joints { get; set; }

        /// <summary>
        /// 眼动数据
        /// </summary>
        [JsonProperty("eyes", NullValueHandling = NullValueHandling.Ignore)]
        public List<float?> Eyes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MotionItem {\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  root: ").Append(Root).Append("\n");
            sb.Append("  joints: ").Append(Joints).Append("\n");
            sb.Append("  eyes: ").Append(Eyes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MotionItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MotionItem input)
        {
            if (input == null) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.Root != input.Root || (this.Root != null && input.Root != null && !this.Root.SequenceEqual(input.Root))) return false;
            if (this.Joints != input.Joints || (this.Joints != null && input.Joints != null && !this.Joints.SequenceEqual(input.Joints))) return false;
            if (this.Eyes != input.Eyes || (this.Eyes != null && input.Eyes != null && !this.Eyes.SequenceEqual(input.Eyes))) return false;

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
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Root != null) hashCode = hashCode * 59 + this.Root.GetHashCode();
                if (this.Joints != null) hashCode = hashCode * 59 + this.Joints.GetHashCode();
                if (this.Eyes != null) hashCode = hashCode * 59 + this.Eyes.GetHashCode();
                return hashCode;
            }
        }
    }
}
