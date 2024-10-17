using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ivs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoResult 
    {

        /// <summary>
        /// 是否是活体。
        /// </summary>
        [JsonProperty("alive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alive { get; set; }

        /// <summary>
        /// 动作列表。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionsList> Actions { get; set; }

        /// <summary>
        /// 检测出最大人脸的图片base64。
        /// </summary>
        [JsonProperty("picture", NullValueHandling = NullValueHandling.Ignore)]
        public string Picture { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoResult {\n");
            sb.Append("  alive: ").Append(Alive).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  picture: ").Append(Picture).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoResult input)
        {
            if (input == null) return false;
            if (this.Alive != input.Alive || (this.Alive != null && !this.Alive.Equals(input.Alive))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.Picture != input.Picture || (this.Picture != null && !this.Picture.Equals(input.Picture))) return false;

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
                if (this.Alive != null) hashCode = hashCode * 59 + this.Alive.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Picture != null) hashCode = hashCode * 59 + this.Picture.GetHashCode();
                return hashCode;
            }
        }
    }
}
