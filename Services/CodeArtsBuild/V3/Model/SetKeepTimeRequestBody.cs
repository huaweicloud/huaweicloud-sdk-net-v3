using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 设置回收站中的任务保留时间接口请求体
    /// </summary>
    public class SetKeepTimeRequestBody 
    {

        /// <summary>
        /// 回收站中的任务保留时间
        /// </summary>
        [JsonProperty("keep_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetKeepTimeRequestBody {\n");
            sb.Append("  keepTime: ").Append(KeepTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetKeepTimeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetKeepTimeRequestBody input)
        {
            if (input == null) return false;
            if (this.KeepTime != input.KeepTime || (this.KeepTime != null && !this.KeepTime.Equals(input.KeepTime))) return false;

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
                if (this.KeepTime != null) hashCode = hashCode * 59 + this.KeepTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
